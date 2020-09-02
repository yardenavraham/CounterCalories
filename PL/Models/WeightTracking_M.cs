using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PL.Models
{
    public class WeightTracking_M
    {
        private readonly IBl _bl = new FactoryBl().GetInstance();

        public double LostGrams(User user, String day)
        {
            return _bl.LostGrams(user,day);
            
        }
    }
}
