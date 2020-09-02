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
    public class RegisterUC_Model
    {
        private readonly IBl _bl = new FactoryBl().GetInstance();

        public User User { get; set; } = new User();

        public void AddUser()
        {
            var res = _bl.AddUser(User);
            var message = res != null ?
                $"The User: {res.UserName}\nFrom: {res.Name}\nSaved Successfully!" :
                "Something went wrong when trying to add user!";
            MessageBox.Show(message);

        }

        public bool checkUser(string userName)
        {
            return _bl.checkUser(userName);
        }
    }
}
