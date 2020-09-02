using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using BE;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DalImp : IDal
    {
        public async Task<User> AddUSer(User _user)
        {
           
            try
            {
                User resUser = new User();
                using (var db = new ProjectContext())
                {
                    resUser = db.Users.Add(_user);
                    //await db.SaveChangesAsync();
                    db.SaveChanges();
                }
                return resUser;
                
            }
            catch (Exception)
            {
                return null;
            }
        }

        //public  void AddUSerS(User _user)
        //{

           
        //        using (var db = new ProjectContext())
        //        {
        //            db.Users.Add(_user);
        //            db.SaveChanges();
        //        }

      
        //}

        public String XmlFood(String text)
        {
            String name = "https://api.nal.usda.gov/ndb/search/?format=xml&q="+text+ "&max=25&offset=0&api_key=h63evBKsX8Ykk1kF6hXQre68bQbJbY0bavAhjtIH";
            WebRequest request = WebRequest.Create(name);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(dataStream);
            String output = streamReader.ReadToEnd();
            return output;
        }

        public List<FoodObj> GetAllFood(String xml)
        {
            XmlDocument xDoc = new XmlDocument();
            List<FoodObj> foods = new List<FoodObj>();
            xDoc.LoadXml(xml);
            XmlElement root = xDoc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("item");
            FoodObj foodObj = new FoodObj();
            foreach (XmlNode node in nodes)
            {
                foreach (XmlNode node1 in node)
                {
                    if (node1.Name == "name")
                        foodObj.Name=node1.FirstChild.Value;
                    if (node1.Name == "ndbno")
                        foodObj.Ndbno = int.Parse(node1.FirstChild.Value);
                }
                foods.Add(foodObj);
                foodObj = new FoodObj();

            }
            return foods;

        }
        

        public User CheckUser(ExistUser existUser)
        {
            using (var db = new ProjectContext())
            {
                var query = db.Users.SqlQuery("select * from dbo.Users where UserName = @p0 and Password = @p1;", existUser.UserName, existUser.Password);
                User currentUser;
                try { currentUser = query.FirstAsync().Result.Clone(); }
                catch { return null; }

                return currentUser;
            }
            
        }

        public async Task<Food> AddFood(Food food)
        {
            try
            {
                Food resfood = new Food();
               //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectContext, Configuration>());
                using (var db = new ProjectContext())
                {
                    resfood = db.Foods.Add(food);
                     db.SaveChanges();
                }
                return resfood;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GetNutrientsOfFood(string name)
        {

            String xml = XmlFood(name);
            XmlDocument xDoc = new XmlDocument();
            List<String> foods = new List<String>();
            xDoc.LoadXml(xml);
            XmlElement root = xDoc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("item");
            int ndbno=0;
            XmlNode node= nodes.Item(0);
            foreach (XmlNode node1 in node)
            {
                if (node1.Name == "ndbno")
                {
                    ndbno = int.Parse(node1.FirstChild.Value);
                }
            }
            String address = "https://api.nal.usda.gov/ndb/reports/?ndbno=" + ndbno + "&type=b&format=xml&api_key=h63evBKsX8Ykk1kF6hXQre68bQbJbY0bavAhjtIH";
            WebRequest request = WebRequest.Create(address);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(dataStream);
            String output = streamReader.ReadToEnd();
            return output;
        }

        public bool UpdateWeight(User user)
        {
            using (var db = new ProjectContext())
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=BE.ProjectContext;Integrated Security=True;Connect Timeout=30");

                connection.Open();
                var query = "update dbo.Users set Weight="+ user.Weight +" , GramsToLose="+ user.GramsToLose + " where UserName='"+ user.UserName +"' ;";
                SqlCommand sqlCommand = new SqlCommand(query,connection);
                int res;
                try { res=sqlCommand.ExecuteNonQuery(); }
                catch {
                    connection.Close();
                    return false;
                }
                connection.Close();
                return res==1;
            }
        }

        public DataTable ShowFood(User user)
        {
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=BE.ProjectContext;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string query = string.Format("select NameFood,Meal,Amount,Day,Calories from dbo.Foods where UserName = '{0}' order by Day, Meal, NameFood; ",user.UserName);//textbox1.Text 
            SqlDataAdapter a = new SqlDataAdapter(query, conn);
            DataTable x = new DataTable();
            a.Fill(x);
            conn.Close();
            return x;
        }

        public int DayCalories(User user)
        {

            double bmr;
            double cal=0;
            int age = DateTime.Now.Year-user.BirthYear;
            if (user.Gender == true)//male
                bmr = 66 + user.Weight * 13.8 + user.Height * 5 - age * 6.8;
            else//female
                bmr = 655 + user.Weight * 9.6 + user.Height * 1.8 - age * 4.7;
            switch(user.ActivityLevel)
            {
                case EActivityLevel.Sedentary:
                    cal = bmr * 1.2;
                    break;
                case EActivityLevel.LightlyActive:
                    cal = bmr * 1.375;
                    break;
                case EActivityLevel.Moderatetely:
                    cal = bmr * 1.55;
                    break;
                case EActivityLevel.VeryActive:
                    cal = bmr * 1.725;
                    break;
                case EActivityLevel.ExtraActive:
                    cal = bmr * 1.9;
                    break;

            }
            var dayCal= (int)cal - user.GramsToLose;
            var day = DateTime.Now.DayOfWeek.ToString();
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=BE.ProjectContext;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string query = string.Format("select sum(Calories) from dbo.Foods where UserName='{0}' and Day='{1}'; ", user.UserName,day);//textbox1.Text 
            SqlDataAdapter a = new SqlDataAdapter(query, conn);
            DataTable x = new DataTable();
            a.Fill(x);
            conn.Close();
            if (x.Rows[0][0].ToString() == "")
                return dayCal;
            var existCal = int.Parse(x.Rows[0][0].ToString());
            return dayCal - existCal;
        }
        public double LostGrams(User user, String day)
        {

            double bmr;
            double cal = 0;
            int age = DateTime.Now.Year - user.BirthYear;
            if (user.Gender == true)//male
                bmr = 66 + user.Weight * 13.8 + user.Height * 5 - age * 6.8;
            else//female
                bmr = 655 + user.Weight * 9.6 + user.Height * 1.8 - age * 4.7;
            switch (user.ActivityLevel)
            {
                case EActivityLevel.Sedentary:
                    cal = bmr * 1.2;
                    break;
                case EActivityLevel.LightlyActive:
                    cal = bmr * 1.375;
                    break;
                case EActivityLevel.Moderatetely:
                    cal = bmr * 1.55;
                    break;
                case EActivityLevel.VeryActive:
                    cal = bmr * 1.725;
                    break;
                case EActivityLevel.ExtraActive:
                    cal = bmr * 1.9;
                    break;

            }
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=BE.ProjectContext;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string query = string.Format("select sum(Calories) from dbo.Foods where UserName='{0}' and Day='{1}'; ", user.UserName, day);//textbox1.Text 
            SqlDataAdapter a = new SqlDataAdapter(query, conn);
            DataTable x = new DataTable();
            a.Fill(x);
            conn.Close();
            if (x.Rows[0][0].ToString() == "")
                return cal/7.0;
        
            var existCal = double.Parse(x.Rows[0][0].ToString());
            return (cal - existCal)/7.0;
        }
        public void resetFood(string userId)
        {
            using (var db = new ProjectContext())
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=BE.ProjectContext;Integrated Security=True;Connect Timeout=30");

                connection.Open();
                var query = "delete from dbo.Foods where UserName = '" + userId + "';";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                int res;
                try { res = sqlCommand.ExecuteNonQuery(); }
                catch
                {
                    connection.Close();
                }
                connection.Close();
                
            }
        }

        public bool checkUser(string userName)
        {
            using (var db = new ProjectContext())
            {
                var query = db.Users.SqlQuery("select * from dbo.Users where UserName = @p0;", userName);
                User currentUser;
                try { currentUser = query.FirstAsync().Result.Clone(); }
                catch { return true; }

                return false;
            }
        }
    }
}