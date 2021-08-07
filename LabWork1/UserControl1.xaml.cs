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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e) //when clicked program calculates the BMI result of the user and at the same time depending on the result color of result box changes
        {
            double h=double.Parse(heightTextBox.Text);     //getting the user's height inputs in meters
            double w=double.Parse(weightTextBox.Text);    //getting the user's weight inputs in kilogram
            double res;                                  //BMI=H/W^2

           
            res = w / Math.Pow(h, 2); //calculating bmi of the user

            resultTextBox.Text = Convert.ToString(w/Math.Pow(h,2)); //here the result box will show the result which is converted into string. 

            if (res > 25 || res < 18.5)
                resultTextBox.Background = Brushes.Red; //if the result is greater than 25 or less than 18.5 the background color of resultbox turn red.
            else
                resultTextBox.Background = Brushes.Green; //if the result is less than 25 or greater than 18.5 the background color of resultbox turn green.
        }
    }
}
