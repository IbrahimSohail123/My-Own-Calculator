using System;
using System.CodeDom;
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

namespace OfficialCalculatorFor2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string op = "";
        private string num1 = "";
        private string numplus = "";
        private string num2 = "";
        private bool startNewNumber = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        // How All Button 0 - 9 Work
        private void InputButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string inputText = button.Content.ToString();
            if (startNewNumber)
            {
                ResultOfEQUATION.Content = inputText;

                startNewNumber = false;
            }
            else
            {
                ResultOfEQUATION.Content = ResultOfEQUATION.Content + inputText;
            }
        }

        // All Operators
        private void Buttonx_Click(object sender, RoutedEventArgs e)
        {
            startNewNumber = true;

            op = "x";
            num1 = ResultOfEQUATION.Content.ToString();
        }

        private void buttonplus_Click(object sender, RoutedEventArgs e)
        {

            startNewNumber = true;

            op = "+";
            num1 = ResultOfEQUATION.Content.ToString();
        }

        private void Buttonminus_Click(object sender, RoutedEventArgs e)
        {
            startNewNumber = true;

            op = "-";
            num1 = ResultOfEQUATION.Content.ToString();
        }

        private void Buttonslash_Click(object sender, RoutedEventArgs e)
        {
            startNewNumber = true;

            op = "÷";
            num1 = ResultOfEQUATION.Content.ToString();
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            num1.Contains("");
            num2.Contains("");
            ResultOfEQUATION.Content = "";
        }

        private void ButtonDOT_Click(object sender, RoutedEventArgs e)
        {
            startNewNumber = false;

            ResultOfEQUATION.Content = ResultOfEQUATION.Content + ".";
        }

        // Calculate The User Equation
        private void Buttonequals_Click(object sender, RoutedEventArgs e)
        {
            float result = 0.0f;

            num2 = ResultOfEQUATION.Content.ToString();


            if (op == "x")
            {
                try
                {
                    result = float.Parse(num1) * float.Parse(num2);
                }
                catch (FormatException)
                {
                    result = Convert.ToInt32(ResultOfEQUATION.Content);
                }
            }

            if (op == "+")
            {
                num2 = ResultOfEQUATION.Content.ToString();

                try
                {
                    result = float.Parse(num1) + float.Parse(num2);
                }
                catch (FormatException)
                {
                    ResultOfEQUATION.Content = "";
                }
            }
            else if (op == "-")
            {
                num2 = ResultOfEQUATION.Content.ToString();

                try
                {
                    result = Convert.ToInt32(num1) - Convert.ToInt32(num2);
                }
                catch (FormatException)
                {
                    ResultOfEQUATION.Content = "";
                }
            }
            else if (op == "÷")
            {
                num2 = ResultOfEQUATION.Content.ToString();

                try
                {
                    result = Convert.ToInt32(num1) / Convert.ToInt32(num2);
                }
                catch (FormatException)
                {
                    ResultOfEQUATION.Content = "";
                }
            }

            ResultOfEQUATION.Content = result;
        }

       
    }
}