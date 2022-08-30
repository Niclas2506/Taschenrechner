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

namespace Rechner
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

        
        
private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = "";
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "0";
        }

        private void Button_Ergebnis_Click(object sender, RoutedEventArgs e)
        {

            try {

            string[] result = Anzeige.Text.Split(" ");
            int numberOne = Convert.ToInt32(result[0]);
            int numberTwo = Convert.ToInt32(result[2]);
            string arithmetricOperator = result[1];
            if(arithmetricOperator == "+")
            {
                int additionResult = numberOne + numberTwo;
                Anzeige.Text = additionResult.ToString();
            }
            if (arithmetricOperator == "-")
            {
                int subtractitionResult = numberOne - numberTwo;
                Anzeige.Text = subtractitionResult.ToString();
            }
            if (arithmetricOperator == "/")
            {
                int divisionresult = numberOne / numberTwo;
                Anzeige.Text = divisionresult.ToString();  
            }
            if (arithmetricOperator == "*")
            {
                int multiplicationResult = numberOne * numberTwo;
                Anzeige.Text = multiplicationResult.ToString();
            }
            }catch(Exception)
            {
                Anzeige.Text = "Error";
            }

        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + " + ";
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "1";
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "2";
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "3";
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + " - ";
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "4";
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "5";
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "6";
        }

        private void Button_Geteilt_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + " / ";
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "7";
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "8";
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "9";
        }

        private void Button_Mal_Click(object sender, RoutedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + " * ";
        }

        private void Anzeige_TextChanged(object sender, TextChangedEventArgs e)
        {
            Anzeige.Text = Anzeige.Text + "";
        }
    }
}