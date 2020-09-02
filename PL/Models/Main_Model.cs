using BL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Main_Model
    {
        private readonly IBl _bl = new FactoryBl().GetInstance();

        public ExistUser ExistUser { get; set; } = new ExistUser();


        public User CheckUser()
        {
            return _bl.CheckUser(ExistUser);
        }

        
    }
}
