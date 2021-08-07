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
using System.Windows.Shapes;

namespace LabWork1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
           
        }

        private void backToMenuButton_Click(object sender, RoutedEventArgs e) //when clicked forwards user to menu
        {
           
            MainWindow mw = new MainWindow(); //create new form
            mw.Show(); //shows the other page
            this.Close(); //this closes the current page 
        }

        private void showWebPageButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.who.int/behealthy"); //when the user clicks show the web page this function will automatically open the link in the default browser

        }
    }
}
