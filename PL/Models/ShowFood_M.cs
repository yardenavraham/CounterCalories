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
    public class ShowFood_M
    {
        private readonly IBl _bl = new FactoryBl().GetInstance();
        public User user = new User();

        public DataTable ShowFood()
        {
            return _bl.ShowFood(user);
            
        }
    }
}
