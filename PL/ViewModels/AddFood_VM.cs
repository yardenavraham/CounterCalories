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

namespace PL
{
    public class AddFood_VM : INotifyPropertyChanged
    {
        public AddFood_VM(User _currentUser, AddFoodUC _addFoodUC)
        {
            addFoodUC = _addFoodUC;
            currentUser = _currentUser;
            Food = new Food();
            AddFood_M = new AddFood_M();
            SaveCommand = new RelayCommand<Object[]>(values=>
            {
                Food.NameFood = values[0].ToString().Split(',').First();
                Food.Amount= int.Parse(values[1].ToString());
                Food.Meal = values[2].ToString();
                Food.Day = DateTime.Today.DayOfWeek.ToString();
                //EMeal _meal;
                //Enum.TryParse<EMeal>(values[2].ToString(), out _meal);
                //Food.Meal = _meal;
                //DayOfWeek _day;
                //Enum.TryParse<DayOfWeek>(values[3].ToString(), out _day);
                //Food.Day = _day;
                Food.UserName = currentUser.UserName;
                Food.Calories = 0;
                if (Food.NameFood == "" || Food.Amount == 0 || Food.Meal == null)
                    return;
                AddFood_M.food = Food;
                AddFood_M.AddFood();
                
            },
                //if have more condition to add report 
                food =>
                {
                    return food != null;
                });
        }
        public AddFoodUC addFoodUC;

        public User currentUser = new User();

        public event PropertyChangedEventHandler PropertyChanged;

        public AddFood_M AddFood_M { get; set; }

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
        public Food Food { get; set; }


        

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
