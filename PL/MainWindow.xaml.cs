
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BE;
using BL;
using PL.UserControls;
using System.Data.SqlClient;
using System.Data;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BL.IBl bl { get; set; }
        public Main_VM Main_VM { get; set; }

        public MainWindow()
        {
            Main_VM = new Main_VM(this);
            this.DataContext = Main_VM;
            InitializeComponent();
            bl = new FactoryBl().GetInstance();
            //string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=BE.ProjectContext;Integrated Security=True;Connect Timeout=30";
            //SqlConnection conn = new SqlConnection(connStr);
            //conn.Open();
            ////idstudent={0} AND Name={1} AND Surname={2} AND Middlename={3} AND House={4} AND Street={5} AND Telephone={6}
            //string BETA = string.Format("select NameFood,Meal,Amount,Day,Calories from dbo.Foods where UserName = 's' order by Day, Meal, NameFood; ");//textbox1.Text 
            //SqlDataAdapter a = new SqlDataAdapter(BETA, conn);
            //DataTable x = new DataTable();
            //a.Fill(x);//<-there is an exception
            
            //this.datagrid.DataContext = x;
            //conn.Close();
            
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var RegisterUC = new RegisterUC(this);
            Container.Children.Add(RegisterUC);
        }

        
    }
}
