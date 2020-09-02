using PL.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace PL.UserControls
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>

    public partial class RegisterUC : UserControl
    {
        public RegisterUC_VM RegisterUC_VM { get; set; }
        public MainWindow mainWindow { get; set; }
        public RegisterUC(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
            RegisterUC_VM = new RegisterUC_VM(this);
            this.DataContext = RegisterUC_VM;
            InitializeComponent();
            
           
     
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            registerGrid.Children.Clear();
        }

    }
}
