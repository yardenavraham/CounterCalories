using BE;
using PL.commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PL
{
    public class Main_VM
    {
        public MainWindow mainWindow;
        public event PropertyChangedEventHandler PropertyChanged;

        public Main_Model MainModel { get; set; }

        private RelayCommand<object[]> _SignInCommand;
        public RelayCommand<object[]> SignInCommand
        {
            get { return _SignInCommand; }
            set
            {
                _SignInCommand = value;
            }
        }
        private ExistUser ExistUserModel;
        public ExistUser ExistUser
        {
            get { return ExistUserModel; }
            set
            {
                ExistUserModel = value;
            }
        }
        public Main_VM(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
            MainModel = new Main_Model();
            SignInCommand = new RelayCommand<Object[]>(values =>
            {
                
                var existUser = new ExistUser();
                existUser.UserName = values[0].ToString();
                var passwordBox = values[1] as PasswordBox;
                existUser.Password = passwordBox.Password.ToString();
                MainModel.ExistUser = existUser;

               

                if (MainModel.ExistUser.UserName == "" ||
                MainModel.ExistUser.Password == "")
                    return;
                var currentUser = MainModel.CheckUser();


                if (currentUser!=null)
                {
                    mainWindow.Container.Children.Clear();
                    var ChooseActionUC = new ChooseActionUC(currentUser);
                    mainWindow.Container.Children.Add(ChooseActionUC);
                }
                else
                {
                    MessageBox.Show("Your user or password is incorrect");
                }
            },
                //if have more condition to add report 
                values =>
                {
                    return values!=null;
                });
        }
    }
}
