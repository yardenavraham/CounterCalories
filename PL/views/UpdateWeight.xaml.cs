using BE;
using PL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for UpdateWeight.xaml
    /// </summary>
    public partial class UpdateWeight : UserControl
    {
        User currentUser = new User();

        public UpdateWeight_VM updateWeight_vm { get; set; }
        public UpdateWeight(User _currentUser)
        {
            currentUser = _currentUser;
            InitializeComponent();
            updateWeight_vm = new UpdateWeight_VM(currentUser,this);
            this.DataContext = updateWeight_vm;
        }

        
    }
}
