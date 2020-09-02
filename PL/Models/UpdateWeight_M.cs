using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PL.Models
{
    public class UpdateWeight_M
    {
        private readonly IBl _bl = new FactoryBl().GetInstance();
        public User user = new User();

        public void UpdateWeight()
        {          
            var res = _bl.UpdateWeight(user);
            _bl.resetFood(user.UserName);
            var message = res ?
                $"The weight of: {user.UserName}\nUpdated Successfully!" :
                "Something went wrong when trying to update the weight!";
            MessageBox.Show(message);
        }
    }
}
