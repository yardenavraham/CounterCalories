using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using BE;
using BL;


namespace PL
{
    /// <summary>
    /// Interaction logic for AddFoodUC.xaml
    /// </summary>
    public partial class AddFoodUC : UserControl
    {
        User currentUser = new User();
        
        public AddFood_VM addFood_vm { get; set; }
        public AddFoodUC(User _currentUser)
        {
            currentUser = _currentUser;
            InitializeComponent();
            addFood_vm = new AddFood_VM(currentUser,this);
            this.DataContext = addFood_vm;



        }

       
    }

}
