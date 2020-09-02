using BE;
using PL.ViewModels;
using PL.views;
using System.Windows;
using System.Windows.Controls;


namespace PL
{
    /// <summary>
    /// Interaction logic for ChooseAction.xaml
    /// </summary>
    public partial class ChooseActionUC : UserControl
    {
        User currentUser = new User();
        public ChooseAction_VM chooseAction_VM;
        public ChooseActionUC(User _currentUser)
        {
            currentUser = _currentUser;
            chooseAction_VM = new ChooseAction_VM(currentUser);
            InitializeComponent();
           
            panel.DataContext = chooseAction_VM;
        }

        

        
    }
}
