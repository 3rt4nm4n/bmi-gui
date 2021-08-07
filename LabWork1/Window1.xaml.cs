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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }


        private void resultButton_Click(object sender, RoutedEventArgs e) //when clicked a message box will pop up telling the user if number of activities are enough or not
        {
            int numOfActivities = activiesListBox.SelectedItems.Count;
            if (numOfActivities >= 2) 
                MessageBox.Show(numOfActivities + " activities! Healthy!"); //if the number of activities are greater than 2 the message box will show up the number of activities and healthy
            else if (numOfActivities < 2)
                MessageBox.Show("Not Enough Activity!"); //if the number of activities are less than 2 the message box will show up that it is not enough 
        }

        private void visitBHWButton_Click(object sender, RoutedEventArgs e) ////when the user clicks show the web page this function will automatically open the link in the default browser
        {
            System.Diagnostics.Process.Start("https://www.who.int/behealthy"); //here the link the browser will open is shown
        }

        private void backToMenuButton_Click(object sender, RoutedEventArgs e) //when clicked user is brought back to the menu
        {
            MainWindow mw = new MainWindow(); //create new form of mainwindow
            mw.Show(); //goes back to mainwindow
            this.Close(); //closes current page
        }

       
    }
}
