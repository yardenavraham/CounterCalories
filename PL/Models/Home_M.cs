using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Models
{
    public class Home_M
    {
        private readonly IBl _bl = new FactoryBl().GetInstance();

        public int DayCalories(User user) => _bl.DayCalories(user);
    }
}
