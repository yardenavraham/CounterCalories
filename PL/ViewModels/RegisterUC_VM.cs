using PL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.commands;
using PL.UserControls;
using System.Windows;

namespace PL.ViewModels
{
    public class RegisterUC_VM : INotifyPropertyChanged
    {
        public RegisterUC_VM(RegisterUC _registerUC)
        {
            registerUC = _registerUC;
            RegisterModel = new RegisterUC_Model();
            //userModel = RegisterModel.User.Clone() as User;
            AddSignUpCommand = new RelayCommand<Object[]>(values =>
           {

               var user = new User();
               try
               {
                   for(int i=0;i<7;i++)
                   {
                       if (values[i].ToString() == "")
                           throw new Exception();
                   }
                   for (int i = 7; i < 9; i++)
                   {
                       if (values[i].ToString() == "-1")
                           throw new Exception();
                   }

               }
               catch (Exception ex)
               {
                   MessageBox.Show("Please fill all the fields");
                   return;
               }
               if(!RegisterModel.checkUser(values[0].ToString()))
               {
                   MessageBox.Show("The user name already exist");
                   return;
               }

               user.UserName = values[0].ToString();
               user.Name = values[1].ToString();
               user.Password = values[2].ToString();
               try
               {
                   user.BirthYear = int.Parse(values[3].ToString());
                   if (user.BirthYear < 0)
                       throw new Exception();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("Incorrect birth year");
                   return;
               }
               try
               {
                   user.Height = int.Parse(values[4].ToString());
                   if (user.Height <= 0)
                       throw new Exception();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("Incorrect height");
                   return;
               }
               try
               {
                   user.Weight = int.Parse(values[5].ToString());
                   if (user.Weight <= 0)
                       throw new Exception();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("Incorrect weight");
                   return;
               }
               try
               {
                   user.GramsToLose = int.Parse(values[6].ToString());
                   if (user.GramsToLose < 0)
                       throw new Exception();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("Incorrect grams to lose");
                   return;
               }
               user.Gender = values[7].ToString().Equals("0");
               user.ActivityLevel = (EActivityLevel)Enum.Parse(typeof(EActivityLevel), values[8].ToString());
                            
               RegisterModel.User = user;
               RegisterModel.AddUser();
               registerUC.registerGrid.Children.Clear();
           },
                //if have more condition to add report 
                user =>
                {
                    return user != null;
                });
        }
        RegisterUC registerUC;
        public event PropertyChangedEventHandler PropertyChanged;

        public RegisterUC_Model RegisterModel { get; set; }

        private RelayCommand<Object[]> _addSignUpCommand;
        public RelayCommand<Object[]> AddSignUpCommand
        {
            get { return _addSignUpCommand; }
            set
            {
                _addSignUpCommand = value;
                //OnPropertyChanged();
            }
        }


        //private User userModel;
        //public User User
        //{
        //    get { return userModel; }
        //    set
        //    {
        //        OnPropertyChanged();
        //        userModel = value;
        //    }
        //}

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
