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

namespace DimensionCalculator
{
    /// <summary>
    /// Interaction logic for Standard.xaml
    /// </summary>
    public partial class Standard : Window
    {
        //Global Variables
        private bool calculationPerformed = false;
        private bool screenClear = true;
        private double result = 0.0;
        private double leftOperand = 0.0;
        private double rightOperand = 0.0;
        private char selectedOperator = ' ';
        private char lastUsedOperator = ' ';
        
        public Standard()
        {
            InitializeComponent();
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            IOScreen.Text = "0";
            screenClear = true;
            result = 0.0;
            leftOperand = 0.0;
            rightOperand = 0.0;
            ErrorField.Text = "";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            IOScreen.Text = "0";
            calculationScreen.Text = "";
            calculationPerformed = false;
            screenClear = true;
            result = 0.0;
            leftOperand = 0.0;
            rightOperand = 0.0;
            ErrorField.Text = "";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            calculationPerformed = false;
            ErrorField.Text = "";

            if (screenClear || (IOScreen.Text.Equals("0")))
            {
                IOScreen.Text = "1";
                screenClear = false;
            }
            else
            {
                IOScreen.Text += "1";
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            calculationPerformed = false;
            ErrorField.Text = "";

            if (screenClear || (IOScreen.Text.Equals("0")))
            {
                IOScreen.Text = "2";
                screenClear = false;
            }
            else
            {
                IOScreen.Text += "2";
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            calculationPerformed = false;
            ErrorField.Text = "";

            if (screenClear || (IOScreen.Text.Equals("0")))
            {
                IOScreen.Text = "3";
                screenClear = false;
            }
            else
            {
                IOScreen.Text += "3";
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            calculationPerformed = false;
            ErrorField.Text = "";

            if (screenClear || (IOScreen.Text.Equals("0")))
            {
                IOScreen.Text = "4";
                screenClear = false;
            }
            else
            {
                IOScreen.Text += "4";
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            calculationPerformed = false;
            ErrorField.Text = "";

            if (screenClear || (IOScreen.Text.Equals("0")))
            {
                IOScreen.Text = "5";
                screenClear = false;
            }
            else
            {
                IOScreen.Text += "5";
            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            calculationPerformed = false;
            ErrorField.Text = "";

            if (screenClear || (IOScreen.Text.Equals("0")))
            {
                IOScreen.Text = "6";
                screenClear = false;
            }
            else
            {
                IOScreen.Text += "6";
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            calculationPerformed = false;
            ErrorField.Text = "";

            if (screenClear || (IOScreen.Text.Equals("0")))
            {
                IOScreen.Text = "7";
                screenClear = false;
            }
            else
            {
                IOScreen.Text += "7";
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            calculationPerformed = false;
            ErrorField.Text = "";

            if (screenClear || (IOScreen.Text.Equals("0")))
            {
                IOScreen.Text = "8";
                screenClear = false;
            }
            else
            {
                IOScreen.Text += "8";
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            calculationPerformed = false;
            ErrorField.Text = "";

            if (screenClear || (IOScreen.Text.Equals("0")))
            {
                IOScreen.Text = "9";
                screenClear = false;
            }
            else
            {
                IOScreen.Text += "9";
            }
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            calculationPerformed = false;
            ErrorField.Text = "";

            if (IOScreen.Text.Equals("0"))
            {
                //Do Nothing
            }
            else if (screenClear)
            {
                IOScreen.Text = "0";
            }
            else
            {
                IOScreen.Text += "0";
            }
        }

        private void backSpace_Click(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            if (IOScreen.Text.Length == 1)
            {
                IOScreen.Text = "0";
                screenClear = true;
            }
            else if (screenClear)
            {
                //Do Nothing
            }
            else
            {
                int i = IOScreen.Text.Length;
                IOScreen.Text = IOScreen.Text.Substring(0, i - 1);
            }
        }

        private void percentage_Click(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            IOScreen.Text = double.Parse(IOScreen.Text) / 100 + "";
            screenClear = true;
        }

        private void squareRoot_Click(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            IOScreen.Text = Math.Round(Math.Sqrt(double.Parse(IOScreen.Text)), 3) + "";
            screenClear = true;
        }

        private void dividion_Click(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            if (calculationScreen.Text == "")
            {
                leftOperand = double.Parse(IOScreen.Text);
                calculationScreen.Text += leftOperand + " ÷ ";
                screenClear = true;
                selectedOperator = '/';
                lastUsedOperator = '/';
            }
            else
            {
                selectedOperator = lastUsedOperator;
                perfomCalculation();
                selectedOperator = '/';
                lastUsedOperator = '/';
                calculationScreen.Text += " ÷ ";
                leftOperand = result;
            }
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            if (calculationScreen.Text == "")
            {
                leftOperand = double.Parse(IOScreen.Text);
                calculationScreen.Text += leftOperand + " × ";
                screenClear = true;
                selectedOperator = '*';
                lastUsedOperator = '*';
            }
            else
            {
                selectedOperator = lastUsedOperator;
                perfomCalculation();
                selectedOperator = '*';
                lastUsedOperator = '*';
                calculationScreen.Text += " × ";
                leftOperand = result;
            }
           
        }

        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            if (calculationScreen.Text == "")
            {
                leftOperand = double.Parse(IOScreen.Text);
                calculationScreen.Text += leftOperand + " - ";
                screenClear = true;
                selectedOperator = '-';
                lastUsedOperator = '-';
            }
            else
            {
                selectedOperator = lastUsedOperator;
                perfomCalculation();
                selectedOperator = '-';
                lastUsedOperator = '-';
                calculationScreen.Text += " - ";
                leftOperand = result;
            }
        }

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            if (calculationScreen.Text == "")
            {
                leftOperand = double.Parse(IOScreen.Text);
                calculationScreen.Text += leftOperand + " + ";
                screenClear = true;
                selectedOperator = '+';
                lastUsedOperator = '+';
            }
            else
            {
                selectedOperator = lastUsedOperator;
                perfomCalculation();
                selectedOperator = '+';
                lastUsedOperator = '+';
                calculationScreen.Text += " + ";
                leftOperand = result;
            }
            
        }

        private void equalTo_Click(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            if (selectedOperator == ' ')
            {
                performUniformCalculation();
                calculationScreen.Text = "";
            }
            else
            {
                perfomCalculation();
                calculationScreen.Text = "";
            }
            

        }

        private void decimal_Click(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            if(screenClear)
            {
                IOScreen.Text = "0.";
                screenClear = false;
                
            }
            else if (IOScreen.Text.Contains('.'))
            {
                //Do Nothing
            }
            else
            {
                IOScreen.Text += ".";
            }
        }

        private void remainder_Click(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            if (calculationScreen.Text == "")
            {
                leftOperand = double.Parse(IOScreen.Text);
                calculationScreen.Text += leftOperand + " % ";
                screenClear = true;
                selectedOperator = '%';
                lastUsedOperator = '%';
            }
            else
            {
                selectedOperator = lastUsedOperator;
                perfomCalculation();
                selectedOperator = '%';
                lastUsedOperator = '%';
                calculationScreen.Text += " % ";
                leftOperand = result;
            }
        }

        private void perfomCalculation()
        {
            switch (selectedOperator)
            {
                case '+':
                    rightOperand = double.Parse(IOScreen.Text);
                    calculationScreen.Text += rightOperand + "";
                    result = leftOperand + rightOperand;
                    IOScreen.Text = result + "";
                    selectedOperator = ' ';
                    screenClear = true;
                    calculationPerformed = true;
                    break;

                case '-':
                    rightOperand = double.Parse(IOScreen.Text);
                    calculationScreen.Text += rightOperand + "";
                    result = leftOperand - rightOperand;
                    IOScreen.Text = result + "";
                    selectedOperator = ' ';
                    screenClear = true;
                    calculationPerformed = true;
                    break;

                case '*':
                    rightOperand = double.Parse(IOScreen.Text);
                    calculationScreen.Text += rightOperand + "";
                    result = leftOperand * rightOperand;
                    IOScreen.Text = result + "";
                    selectedOperator = ' ';
                    screenClear = true;
                    calculationPerformed = true;
                    break;

                case '/':
                    rightOperand = double.Parse(IOScreen.Text);

                    if (rightOperand == 0)
                    {
                        ErrorField.Text = "Cannot Divide By Zero";
                    }
                    else
                    {
                        result = Math.Round((leftOperand / rightOperand), 3);
                        calculationScreen.Text += rightOperand + "";
                        IOScreen.Text = result + "";
                        selectedOperator = ' ';
                        screenClear = true;
                        calculationPerformed = true;
                    }

                    break;

                case '%':
                    rightOperand = double.Parse(IOScreen.Text);

                    if (rightOperand == 0)
                    {
                        ErrorField.Text = "Cannot Divide By Zero";
                    }
                    else
                    {
                        result = leftOperand % rightOperand;
                        calculationScreen.Text += rightOperand + "";
                        IOScreen.Text = result + "";
                        selectedOperator = ' ';
                        screenClear = true;
                        calculationPerformed = true;
                    }

                    break;

                default:
                    break;
            }

        }

        private void performUniformCalculation()
        {
            if (!calculationPerformed)
            {
                //Do Nothing
            }
            else
            {
                switch (lastUsedOperator)
                {
                    case '+':
                        leftOperand = result;
                        result = leftOperand + rightOperand;
                        IOScreen.Text = result + "";
                        selectedOperator = ' ';
                        screenClear = true;
                        calculationPerformed = true;
                        break;

                    case '-':
                        leftOperand = result;
                        result = leftOperand - rightOperand;
                        IOScreen.Text = result + "";
                        selectedOperator = ' ';
                        screenClear = true;
                        calculationPerformed = true;
                        break;

                    case '*':
                        leftOperand = result;
                        result = leftOperand * rightOperand;
                        IOScreen.Text = result + "";
                        selectedOperator = ' ';
                        screenClear = true;
                        calculationPerformed = true;
                        break;

                    case '/':

                        if (rightOperand == 0)
                        {
                            ErrorField.Text = "Cannot Divide By Zero";
                        }
                        else
                        {
                            leftOperand = result;
                            result = Math.Round((leftOperand / rightOperand), 3);
                            IOScreen.Text = result + "";
                            selectedOperator = ' ';
                            screenClear = true;
                            calculationPerformed = true;
                        }
                        
                        break;

                    default:
                        break;
                }
            }
            
        }



        private void Basic_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Interest_Click(object sender, RoutedEventArgs e)
        {
            CInterest interest = new CInterest();
            interest.Show();
            this.Close();

            basicSubItem.IsChecked = false;
            interestSubItem.IsChecked = true;
            exchangeSubItem.IsCheckable = false;
        }

        private void Exchange_Click(object sender, RoutedEventArgs e)
        {
            Exchange exchange = new Exchange();
            exchange.Show();
            this.Close();

            basicSubItem.IsChecked = false;
            interestSubItem.IsChecked = false;
            exchangeSubItem.IsCheckable = true;
        }

        private void Manual_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
        }

        //Keyboard keys
        private void keyboardKeyUp(object sender, KeyEventArgs e)
        {


            if ((e.Key == Key.D1) || (e.Key == Key.NumPad1))
            {
                one_Click(sender, e);
            }
            else if ((e.Key == Key.D2) || (e.Key == Key.NumPad2))
            {
                two_Click(sender, e);
            }
            else if ((e.Key == Key.D3) || (e.Key == Key.NumPad3))
            {
                three_Click(sender, e);
            }
            else if ((e.Key == Key.D4) || (e.Key == Key.NumPad4))
            {
                four_Click(sender, e);
            }
            else if ((e.Key == Key.D5) || (e.Key == Key.NumPad5))
            {
                five_Click(sender, e);
            }
            else if ((e.Key == Key.D6) || (e.Key == Key.NumPad6))
            {
                six_Click(sender, e);
            }
            else if ((e.Key == Key.D7) || (e.Key == Key.NumPad7))
            {
                seven_Click(sender, e);
            }
            else if ((e.Key == Key.D8) || (e.Key == Key.NumPad8))
            {
                eight_Click(sender, e);
            }
            else if ((e.Key == Key.D9) || (e.Key == Key.NumPad9))
            {
                nine_Click(sender, e);
            }
            else if ((e.Key == Key.D0) || (e.Key == Key.NumPad0))
            {
                zero_Click(sender, e);
            }
            else if ((e.Key == Key.Decimal))
            {
                decimal_Click(sender, e);
            }
            else if ((e.Key == Key.Add))
            {
                addition_Click(sender, e);
            }
            else if ((e.Key == Key.Subtract))
            {
                subtraction_Click(sender, e);
            }
            else if ((e.Key == Key.Multiply))
            {
                multiplication_Click(sender, e);
            }
            else if ((e.Key == Key.Divide))
            {
                dividion_Click(sender, e);
            }
            else if ((e.Key == Key.Back))
            {
                backSpace_Click(sender, e);
            }
            else if (e.Key == Key.Enter)
            {
                equalTo_Click(sender, e);
            }
            else if (e.Key == Key.Delete)
            {
                CE_Click(sender, e);
            }
            else if (e.Key == Key.Escape)
            {
                C_Click(sender, e);
            }

        }

        
        
    }
}
