using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace PL
{
    /// <summary>
    /// Interaction logic for AutoCompleteUC.xaml
    /// </summary>
    public partial class AutoCompleteUC : UserControl
    {
        public BL.IBl bl { get; set; }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(AutoCompleteUC), new PropertyMetadata(""));


        public AutoCompleteUC()
        {
            InitializeComponent();
            textInput.DataContext = this;
            bl = new FactoryBl().GetInstance();
        }

        void run(object text)
        {
            if (text != null)
            {
                try
                {
                    String food = bl.XmlFood(text.ToString());
                    List<FoodObj> result = bl.GetAllFood(food); //= BL.FactoryBl.GetBL().GetPlaceAutoComplete(text.ToString());
                    Action<List<FoodObj>> action = setListInvok;//point to function
                    Dispatcher.BeginInvoke(action, new object[] { result }); //The dispatcher wants to use BeginInvok to perform an action function
                }
                catch (Exception)
                { }
            }
        }

        private void setListInvok(List<FoodObj> list)
        {
            this.textComboBox.ItemsSource = null;

            if (list.Count > 0 && list[0].Name.CompareTo(Text) != 0)
            {
              FoodObj foodObj = new FoodObj();
                this.AutoCompleteGrid.DataContext = foodObj;
                this.textComboBox.ItemsSource = list;
                textComboBox.DisplayMemberPath = "Name";
                textComboBox.SelectedValuePath = "Name";
                textComboBox.IsDropDownOpen = true;
            }
            else
            {
                textComboBox.IsDropDownOpen = false;
            }
        }


        private void textInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            Thread thread = new Thread(run);
            thread.Start(Text);
        }

        private void textComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FoodObj item = (FoodObj)(textComboBox.SelectedItem);
            if (item != null)
            {
                this.Text = item.Name.ToString();
                textComboBox.IsDropDownOpen = false;
            }
        }



        private void textInput_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Down)
            {
                this.textComboBox.Focus();

            }
        }

        private void textComboBox_PreviewKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Up)

                if (this.textComboBox.SelectedIndex == 0)
                    this.textInput.Focus();
        }
    }
}
