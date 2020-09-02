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
    public partial class WeightTrackingUC : UserControl
    {
        public WeightTracking_VM weightTracking;
        public WeightTrackingUC(User user)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTkzNTY0QDMxMzcyZTM0MmUzMGJhVUpBN3ppditUbUZtSnhjVkdycFBydG9GYnU1dXd2cUtZQXpnK0dEYWc9");

            weightTracking = new WeightTracking_VM(user);
            DataContext = weightTracking;
            InitializeComponent();

        }
      
    }
}
