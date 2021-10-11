using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            SetNumber("1");
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            SetNumber("2");
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            SetNumber("3");
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            SetNumber("4");
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            SetNumber("5");
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            SetNumber("6");
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            SetNumber("7");
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            SetNumber("8");
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            SetNumber("9");
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            result.Content = "0";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {

            Setoperator("+");

        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Setoperator("-");
        }

        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            Setoperator("*");
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Setoperator("/");
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            string c = (string)result.Content;
            Calculate();
        }

        void Setoperator(string op)
        {
            string c = (string)result.Content;
            if (c.Substring(c.Length - 1, 1) == ".")
                result.Content = result.Content + "0 " + op + " ";
            else
            {
                if (c.EndsWith(" "))
                    result.Content = c.Substring(0, c.IndexOf(" ")) + " " + op + " ";

                else
                {
                    if (c.Contains("+") || c.Contains("*") || c.Contains("-") || c.Contains("/"))
                        Calculate();

                    result.Content = result.Content + " " + op + " ";
                }
            }
        }

        void SetNumber(String num)
        {

            if ((string)result.Content == "0")
                result.Content = num;
            else
            {
                result.Content += num;
            }
        }


        void Calculate()
        {
            string c = (string)result.Content;
            string[] tokens = c.Split(' ');
            float a = float.Parse(tokens[0]);
            float b = float.Parse(tokens[2]);
            float res = 0;

            if (tokens[1] == "+")
                res = a + b;
            else if (tokens[1] == "-")
                res = a - b;
            else if (tokens[1] == "*")
                res = a * b;
            else if (tokens[1] == "/")
                res = a / b;
            result.Content = res.ToString();
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            result.Content += "0";
        }

    }
}
