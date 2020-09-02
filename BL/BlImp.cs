using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;

namespace BL
{
    internal class BlImp : IBl
    {
        private IDal _dal = new FactoryDal().GetInstance();

        public Food AddFood(Food food)
        {
            var res = _dal.AddFood(food).Result;
            return res;
        }

        public User AddUser(User _user)
        {
            var res=_dal.AddUSer(_user).Result;
            return res;
        }

        public User CheckUser(ExistUser existUser)
        {
            return _dal.CheckUser(existUser);
        }
        public void resetFood(string userId)
        {
             _dal.resetFood(userId);
        }

        public int DayCalories(User user)
        {
            return _dal.DayCalories(user);
        }

        public List<FoodObj> GetAllFood(string name)
        {
            return _dal.GetAllFood(name);
        }

        public string GetNutrientsOfFood(string name)
        {
            return _dal.GetNutrientsOfFood(name);
        }

        public DataTable ShowFood(User user)
        {
            return _dal.ShowFood(user);
        }

        public bool UpdateWeight(User user)
        {
            return _dal.UpdateWeight(user);
        }

        public string XmlFood(string v)
        {
            return _dal.XmlFood(v);
        }

        public bool checkUser(string userName)
        {
            return _dal.checkUser(userName);
        }
        public double  LostGrams(User user, String day)
        {
            return _dal.LostGrams(user,day);
        }
    }
}
