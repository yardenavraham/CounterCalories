using BE;
using PL.commands;
using PL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PL.ViewModels
{
    public class UpdateWeight_VM: INotifyPropertyChanged
    {
        public UpdateWeight_VM(User _currentUser,UpdateWeight _updateWeight)
        {
            updateWeight = _updateWeight;
            currentUser = _currentUser;
            UpdateWeight_M = new UpdateWeight_M();
            SaveCommand = new RelayCommand<Object[]>(values =>
            {
                currentUser.Weight = int.Parse(values[0].ToString());
                currentUser.GramsToLose = int.Parse(values[1].ToString());

                UpdateWeight_M.user = currentUser;
                UpdateWeight_M.UpdateWeight();
                //updateWeight.panelWeight.Children.Clear();
            },
                //if have more condition to add report 
                values =>
                {
                    return values != null;
                });
        }
        public UpdateWeight updateWeight;
        public User currentUser = new User();

        public event PropertyChangedEventHandler PropertyChanged;

        public UpdateWeight_M UpdateWeight_M { get; set; }

        private RelayCommand<Object[]> _saveCommand;
        public RelayCommand<Object[]> SaveCommand
        {
            get { return _saveCommand; }
            set
            {
                _saveCommand = value;
                OnPropertyChanged();
            }
        }




        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
