using BE;
using PL.commands;
using PL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PL.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<User> CurrentUsers { get; set; }

        private UsersModel CurrentModel;

      //  public RegisterCommand Register { get; set; }

        public UserViewModel()
        {
            CurrentModel = new UsersModel();//צריך קריטריונים לטעינת הנתונים
            CurrentUsers = new ObservableCollection<User>();
           // Register = new RegisterCommand(this);
            CurrentUsers.CollectionChanged += CurrentUsers_CollectionChanged;

        }

        private void CurrentUsers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // כאן לדאוג לעדכן את המודל אם התווסף משתמש חדש
        }

        public void RegisterUsers()
        {
            List<User> NewUsers = CurrentModel.CurrentUsers;
            CurrentUsers.Clear();
            foreach (var User in NewUsers)
            {
                CurrentUsers.Add(User);
            }

        }
    }
}
