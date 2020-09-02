using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows;

namespace PL
{
    public class AddFood_M
    {
        private readonly IBl _bl = new FactoryBl().GetInstance();

        public Food food { get; set; } = new Food();

        public void AddFood()
        {
            food.Nutrients = _bl.GetNutrientsOfFood(food.NameFood);
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(food.Nutrients);
            XmlNodeList nutrientsList = xDoc.SelectNodes("/report/food/nutrients/nutrient");
            bool flag = false;
            for (int i = 0; i < nutrientsList.Count; i++)
            {
                foreach (var item in (nutrientsList[i]).Attributes)//go over the attributes of the current nutrient
                {
                    if ((((XmlAttribute)item).Name).Equals("name") && (((XmlAttribute)item).Value) == "Energy")//save the name
                    {

                        flag = true;

                    }
                    if (flag && (((XmlAttribute)item).Name).Equals("value"))//save the value
                    {

                        food.Calories = int.Parse(((XmlAttribute)item).Value)*food.Amount;
                        break;
                    }

                }
                if (flag)
                    break;
            }
            
            if(!flag)
            {
                MessageBox.Show("There are no details about calories for this food, no calories will be added to your daily calorie amount");
                food.Calories = 0;
            }
            var res = _bl.AddFood(food);
            var message = res != null ?
                $"The Food: {res.UserName}\nFrom: {res.UserName}\nMeal: {res.Meal}\nSaved Successfully!" :
                "Something went wrong when trying to add food!";
            MessageBox.Show(message);
        }
    }
}
