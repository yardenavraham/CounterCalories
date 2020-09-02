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

namespace PL.views
{
    /// <summary>
    /// Interaction logic for MainUC.xaml
    /// </summary>
    public partial class Home_UC : UserControl
    {
        public Home_VM Home_VM;
        public Home_UC(User _user)
        {
            Home_VM = new Home_VM(_user);
            InitializeComponent();
            HomeGrid.DataContext = Home_VM;
            name.Content = "Hi " + _user.Name + "!";

        }
    }
}
