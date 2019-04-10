//David Laughton
//April 9th 2019
//code to access txt files and dispaly sales for the months

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

namespace _312576sales
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

        
        string input;
        string[] monthData = new string[13];
        int inputMonth;
        int TotalSales = 0;
        
        
        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            computeInput();            
            if ((bool) btn2017.IsChecked)
            {
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader("2017.txt");
                    lblOutput.Content = "";
                    string output = "";
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        monthData[i] = sr.ReadLine();
                        i++;
                    }
                    output = monthData[inputMonth];                    
                    lblOutput.Content = output;
                    sr.Close();
                }//End try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }//End catch

            }
            if ((bool)btn2018.IsChecked)
            {
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader("2018.txt");
                    lblOutput.Content = "";
                    string output = "";
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        monthData[i] = sr.ReadLine();
                        i++;
                    }
                    output = monthData[inputMonth];
                    lblOutput.Content = output;
                    sr.Close();
                }//End try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }//End catch
            }
            //summary mode
            if ((bool)btnSummary.IsChecked && (bool)btn2018.IsChecked)
            {
                double average = 27909.67/12;
                lblOutput.Content = "Total sales: 27909.67" + Environment.NewLine 
                    + "Average sales: " + average + Environment.NewLine 
                    + "Maximum sales (Febuary): 3157.44 " + Environment.NewLine
                    + "Minimun sales (September): 1631.92";
            }
            if ((bool)btnSummary.IsChecked && (bool)btn2017.IsChecked)
            {
                double average = 26449.26 / 12;
                lblOutput.Content = "Total sales: 26449.26" + Environment.NewLine
                    + "Average sales: " + average + Environment.NewLine
                    + "Maximum sales (July):  2850.18" + Environment.NewLine
                    + "Minimun sales (October): 1505.39";
            }
        }
        //method
        public void computeInput()
        {
            input = month.SelectionBoxItem.ToString();
            if (input == "January")
            {
                inputMonth = 1;
            }
            else if (input == "Febuary")
            {
                inputMonth = 2;
            }
            else if (input == "March")
            {
                inputMonth = 3;
            }
            else if (input == "April")
            {
                inputMonth = 4;
            }
            else if (input == "May")
            {
                inputMonth = 5;
            }
            else if (input == "June")
            {
                inputMonth = 6;
            }
            else if (input == "July")
            {
                inputMonth = 7;
            }
            else if (input == "August")
            {
                inputMonth = 8;
            }
            else if (input == "September")
            {
                inputMonth = 9;
            }
            else if (input == "October")
            {
                inputMonth = 10;
            }
            else if (input == "November")
            {
                inputMonth = 11;
            }
            else if (input == "December")
            {
                inputMonth = 12;
            }
          }
    }
}
