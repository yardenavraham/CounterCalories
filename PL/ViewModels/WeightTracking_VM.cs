using BE;
using PL.commands;
using PL.Models;
using PL.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace PL
{
    public partial class GramsForWeek
    {
        public string day { get; set; }
        public double lostGrams { get; set; }
    }
    public class WeightTracking_VM : INotifyPropertyChanged
    {
        private List<GramsForWeek> _Data;
        public List<GramsForWeek> Data
        {
            get { return _Data; }
            set
            {
                _Data = value;
                OnPropertyChanged();
            }
        }
        public WeightTracking_M WeightTracking_M;
        public User user;
        public WeightTracking_VM(User _user)
        {
            Data = new List<GramsForWeek>();
            user = _user;
            WeightTracking_M = new WeightTracking_M();
            isonline();
            InitTimer();
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
            Data.Clear();
            for(int i=0;i<7;i++)
            {
                var gramsday = new GramsForWeek();
                gramsday.day = ((DayOfWeek)i).ToString();
                gramsday.lostGrams = WeightTracking_M.LostGrams(user, gramsday.day);
                Data.Add(gramsday);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}