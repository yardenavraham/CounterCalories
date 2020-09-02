using BE;
using PL.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for ShowFoodUC.xaml
    /// </summary>
    public partial class ShowFoodUC : UserControl
    {
        public ShowFood_VM showFood_VM;
        public ShowFoodUC(User user)
        {

            showFood_VM = new ShowFood_VM(user, this);
            DataContext = showFood_VM;
            InitializeComponent();

        }
      
    }
}
