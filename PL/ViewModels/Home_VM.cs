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
using System.Timers;
using System.Windows.Controls;

namespace PL.ViewModels
{
    
    public class Home_VM:INotifyPropertyChanged
    {
        public User user { get; set; }
        public Home_VM(User _user)
        {
            user = _user;
            Home_M = new Home_M();
            DayCalories(user);
            InitTimer();
        }
        public void DayCalories(User user)
        {
            dayCal = Home_M.DayCalories(user);
        }
        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Elapsed += new ElapsedEventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            isonline();
        }
        public void isonline()
        {
            DayCalories(user);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public Home_M Home_M { get; set; }
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
       
        protected virtual void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
