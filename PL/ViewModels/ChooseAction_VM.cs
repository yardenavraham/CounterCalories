using BE;
using PL.Models;
using PL.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PL.ViewModels
{
    
    public class ChooseAction_VM
    {
        
        public ChooseAction_VM(User user)
        {
            chooseAction_M = new ChooseAction_M();
            DayCalories(user);
            Home = new Home_UC(user);
            AddFood = new AddFoodUC(user);
            Weight = new UpdateWeight(user);
            ShowFood = new ShowFoodUC(user);
            weightTracking = new WeightTrackingUC(user);
        }
        public void DayCalories(User user)
        {
            dayCal = chooseAction_M.DayCalories(user);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public ChooseAction_M chooseAction_M { get; set; }
        private int _dayCal;
        public int dayCal
        {
            get { return _dayCal; }
            set
            {
                _dayCal = value;
                NotifyPropertyChanged();
            }
        }
        private UserControl _Home;
        public UserControl Home
        {
            get { return _Home; }
            set
            {
                _Home = value;
                NotifyPropertyChanged();
            }
        }
        private UserControl _AddFood;
        public UserControl AddFood
        {
            get { return _AddFood; }
            set
            {
                _AddFood = value;
                NotifyPropertyChanged();
            }
        }
        private UserControl _weight;
        public UserControl Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                NotifyPropertyChanged();
            }
        }
        private UserControl _ShowFood;
        public UserControl ShowFood
        {
            get { return _ShowFood; }
            set
            {
                _ShowFood = value;
                NotifyPropertyChanged();
            }
        }
        private UserControl _weightTracking;
        public UserControl weightTracking
        {
            get { return _weightTracking; }
            set
            {
                _weightTracking = value;
                NotifyPropertyChanged();
            }
        }
        protected virtual void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
