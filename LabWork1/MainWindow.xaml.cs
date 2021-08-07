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

namespace LabWork1
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
        private void Button1_Click(object sender, RoutedEventArgs e) //when clicked user is brought to 1st window and current one gets closed
        {
            Window1 win1 = new Window1(); //creates new form
            win1.Show();                 //shows first window
            this.Close();               //closes current page
        }
        private void Button2_Click(object sender, RoutedEventArgs e) //when clicked user is brought to 2nd window and current one gets closed
        {
            Window2 win2 = new Window2(); //creates new form
            win2.Show();                 //shows second window
            this.Close();               //closes current page
        }
        private void Button3_Click(object sender, RoutedEventArgs e) //when clicked the program gets closed
        {
            this.Close(); //closes the program
        }
    }
}
