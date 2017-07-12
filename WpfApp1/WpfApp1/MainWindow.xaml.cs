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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void TextBoxDate()
        {
            string month = datePicker.SelectedDate.Value.ToString("MMMM");
            int day = datePicker.SelectedDate.Value.Day;
            string year = datePicker.SelectedDate.Value.ToString("yyyy");

            textBox.Text = month + " " + getDaySuffix(day) + ", " + year;
        }

        private string getDaySuffix(int day)
        {
            switch (day)
            {
                case 1:
                case 21:
                case 31:
                    return day + "st";
                case 2:
                case 22:
                    return day + "nd";
                case 3:
                case 23:
                    return day + "rd";
                default:
                    return day + "th";
            }
        }       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBoxDate();
        }
    }
}
