using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDal
    {
        Task<User> AddUSer(User user);
        Task<Food> AddFood(Food food);
        User CheckUser(ExistUser existUser);
        String XmlFood(String text);
        List<FoodObj> GetAllFood(String xml);
        string GetNutrientsOfFood(String name);
        bool UpdateWeight(User user);
        DataTable ShowFood(User user);
        int DayCalories(User user);
        void resetFood(string userId);
        bool checkUser(string userName);
        double LostGrams(User user, String day);
    }
}
