using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBl
    {

        User AddUser(User _user);
        Food AddFood(Food food);
        string XmlFood(string v);
        List<FoodObj> GetAllFood(string address);
        int DayCalories(User user);
        User CheckUser(ExistUser existUser);
        string GetNutrientsOfFood(String name);
        DataTable ShowFood(User user);
        bool UpdateWeight(User user);
        void resetFood(string userId);
        bool checkUser(string userName);
        double LostGrams(User user, String day);

    }
}
