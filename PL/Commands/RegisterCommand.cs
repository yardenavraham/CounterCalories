using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PL.Models;
namespace PL.commands
{
    public class RegisterCommand : ICommand
    {
        public RegisterCommand(object CurrentVM)
        {
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true ;
        }

        public void Execute(object parameter)
        {
            
        }
    }
}
