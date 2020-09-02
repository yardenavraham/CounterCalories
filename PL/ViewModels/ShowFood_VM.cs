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

namespace PL.ViewModels
{
    public class ShowFood_VM:INotifyPropertyChanged
    {
        private DataTable _table;
        public DataTable table
        {
            get { return _table; }
            set
            {
                _table = value;
                OnPropertyChanged();
            }
        }
        public ShowFood_M showFood_M;
        public ShowFoodUC showFoodUC;
        public ShowFood_VM(User _user, ShowFoodUC _showFoodUC)
        {
            //showFoodUC = _showFoodUC;
            //showFood_M = new ShowFood_M();
            //showFood_M.user = _user.Clone();
            //var table = showFood_M.ShowFood();
            //showFoodUC.datagrid.DataContext = table;
            showFood_M = new ShowFood_M();
            showFood_M.user = _user.Clone();
            table = showFood_M.ShowFood();
            InitTimer();
            //_showFood.datagrid.DataContext = table;
            //Refresh = new RelayCommand<Object[]>(values =>
            //{
            //    table = showFood_M.ShowFood();
            //    _showFood.datagrid.DataContext = table;
            //},
            //    //if have more condition to add report 
            //    values =>
            //    {
            //        return values != null;
            //    });
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
            table = showFood_M.ShowFood();
        }
        public void refresh()
        {
            var table = showFood_M.ShowFood();
            showFoodUC.datagrid.DataContext = table;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        //public UpdateWeight_M UpdateWeight_M { get; set; }

        //private RelayCommand<Object[]> _refresh;
        //public RelayCommand<Object[]> Refresh
        //{
        //    get { return _refresh; }
        //    set
        //    {
        //        _refresh = value;
        //        OnPropertyChanged();
        //    }
        //}




        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //protected virtual void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        //{
        //    var handler = PropertyChanged;
        //    if (handler != null)
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
