using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        public char act = ' ';
        public double operand_1 = 0;
        public double operand_2 = 0;
        public int error = 0;
        public int plus_minus = 1;

        public MainPage()
        {
            InitializeComponent();
            Output.Text = "0";
        }

        //Click event for delete button
        private void OnButtonClicked_backspace(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
           
            if (Output.Text == "" || Output.Text == "0")
                return;
            
            if (Output.Text.Length == 1)
            {
                Output.Text = "0";
                return;
            }
            
            Output.Text = Output.Text.Remove(Output.Text.Length - 1, 1);
        }

        //Click event for plus/minus button
        private void OnButtonClicked_plus_minus(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            if (Output.Text == "0")
                return;
            if (Regex.IsMatch(Output.Text, "\\-"))
                Output.Text = Output.Text.Remove(0, 1);
            else
                Output.Text = Output.Text.Insert(0, "-");
        }


        //Click event for number 7 button
        private void OnButtonClicked_7(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            
            if (Output.Text == "0")
                Output.Text = "7";
           
            else
                Output.Text += "7";
        }
        //Click event for number 8 button
        private void OnButtonClicked_8(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            if (Output.Text == "0")
                Output.Text = "8";
            else
                Output.Text += "8";
        }
        //click event for number 9
        private void OnButtonClicked_9(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            if (Output.Text == "0")
                Output.Text = "9";
            else
                Output.Text += "9";
        }
        private void OnButtonClicked_div(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            operand_1 = Convert.ToDouble(Output.Text);
            act = '/';
            Output.Text = "0";
        }
 
        private void OnButtonClicked_4(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            if (Output.Text == "0")
                Output.Text = "4";
            else
                Output.Text += "4";
        }
        private void OnButtonClicked_5(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            if (Output.Text == "0")
                Output.Text = "5";
            else
                Output.Text += "5";
        }
        private void OnButtonClicked_6(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            if (Output.Text == "0")
                Output.Text = "6";
            else
                Output.Text += "6";
        }

        //click event for mulitplication
        private void OnButtonClicked_mul(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            operand_1 = Convert.ToDouble(Output.Text);
            act = '*';
            Output.Text = "0";
        }

        private void OnButtonClicked_1(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            if (Output.Text == "0")
                Output.Text = "1";
            else
                Output.Text += "1";
        }
        private void OnButtonClicked_2(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            if (Output.Text == "0")
                Output.Text = "2";
            else
                Output.Text += "2";
        }
        private void OnButtonClicked_3(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            if (Output.Text == "0")
                Output.Text = "3";
            else
                Output.Text += "3";
        }
        //click event for subtraction
        private void OnButtonClicked_minus(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            operand_1 = Convert.ToDouble(Output.Text);
            act = '-';
            Output.Text = "0";
        }
        private void OnButtonClicked_enter(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
                return;
            }
            operand_2 = Convert.ToDouble(Output.Text);
            switch (act)
            {
                case '+':
                    operand_1 = operand_1 + operand_2;
                    Output.Text = Convert.ToString(operand_1);
                    break;
                case '-':
                    operand_1 = operand_1 - operand_2;
                    Output.Text = Convert.ToString(operand_1);
                    break;
                case '*':
                    operand_1 = operand_1 * operand_2;
                    Output.Text = Convert.ToString(operand_1);
                    break;
                case '/':
                    if (operand_2 == 0)
                    {
                        Output.Text = "Divide by zero is impossible";
                        error = 1;
                        break;
                    }
                    else
                    {
                        operand_1 = operand_1 / operand_2;
                        Output.Text = Convert.ToString(operand_1);
                        break;
                    }
            }
            act = ' ';
        }
        private void OnButtonClicked_0(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
           
            if (Output.Text != "0")
                Output.Text += "0";
        }
        private void OnButtonClicked_dot(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
           
            if (Regex.IsMatch(Output.Text, "\\."))    
                return;
            else
                Output.Text += ".";
        }
        private void OnButtonClicked_plus(object sender, System.EventArgs e)
        {
            if (error == 1)
            {
                Output.Text = "0";
                error = 0;
            }
            operand_1 = Convert.ToDouble(Output.Text);
            act = '+';
            Output.Text = "0";
        }
    }
}