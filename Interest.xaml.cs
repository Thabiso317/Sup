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
using System.Text.RegularExpressions;

namespace DimensionCalculator
{
    /// <summary>
    /// Interaction logic for Interest.xaml
    /// </summary>
    public partial class CInterest : Window
    {
        

        private double StartAmount;
        private double Interest;
        private double Period;

        public CInterest()
        {
            InitializeComponent();
        }

        private void Basic_Click(object sender, RoutedEventArgs e)
        {
            Standard basic = new Standard();
            basic.Show();
            this.Close();


            basicSubItem.IsChecked = true;
            interestSubItem.IsChecked = false;
            exchangeSubItem.IsCheckable = false;
        }

        private void Interest_Click(object sender, RoutedEventArgs e)
        {
            //Do nothing
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

        private void compInterestButton_Click(object sender, RoutedEventArgs e)
        {
            double principle;
            double EndAmount;
            if (!principleTextBox.Text.Equals(""))
            {
                principle = double.Parse(principleTextBox.Text);
            }
            else
            {
                
                ErrorField.Text = "Please Enter Start Amount Correctly";
                return;
                
            }

            StartAmount = principle;

            double rate;
            if (!rateTextBox.Text.Equals(""))
            {
                rate = double.Parse(rateTextBox.Text) / 100;
            }
            else
            {
                ErrorField.Text = "Please Enter Interest Correctly";
                return;
            }

            Interest = rate;

            double term;

            if (!periodTextBox.Text.Equals(""))
            {
                if ((bool)monthsRadioButton.IsChecked)
                {
                    term = double.Parse(periodTextBox.Text) / 12;
                }
                else
                {
                    term = double.Parse(periodTextBox.Text);
                }
            }
            else
            {
                EndAmount = CalculateInterest(StartAmount, Interest);
                compInterestTextBox.Text = EndAmount + "";
                return;
            }

            Period = term;


            double compoundings;
            if ((bool)compMonthlyRB.IsChecked)
            {
                compoundings = 12;
            }
            else if ((bool)compQuaterlyRB.IsChecked)
            {
                compoundings = 4;
            }
            else if ((bool)compSemi_AnnuallyRB.IsChecked)
            {
                compoundings = 2;
            }
            else
            {
                compoundings = 1;
            }

            
            //finalAmount = principle + principle*(1 + n/compundings)^(term*coumpoundings)
            EndAmount = CalculateInterest(StartAmount, Interest, Period, compoundings);

            compInterestTextBox.Text = EndAmount + "";

        }

        private void simpleInterestButton_Click(object sender, RoutedEventArgs e)
        {
            double principle;
            double EndAmount;

            if (!principleTextBox.Text.Equals(""))
            {
               principle  = double.Parse(principleTextBox.Text);
            }
            else
            {
                ErrorField.Text = "Please Enter Start Amount Correctly";
                return;
            }

            StartAmount = principle;

            double rate;
            if (!rateTextBox.Text.Equals(""))
            {
                rate = double.Parse(rateTextBox.Text) / 100;
            }
            else
            {
                ErrorField.Text = "Please Enter Interest Correctly";
                return;
            }

            Interest = rate;
            
            double term;

            if (!periodTextBox.Text.Equals(""))
            {
                if ((bool)monthsRadioButton.IsChecked)
                {
                    term = double.Parse(periodTextBox.Text) / 12;
                }
                else
                {
                    term = double.Parse(periodTextBox.Text);
                }
            }
            else
            {
                EndAmount = CalculateInterest(StartAmount, Interest);
                simpleInterestTextBox.Text = EndAmount + "";
                return;
            }

            Period = term;

            EndAmount = CalculateInterest(StartAmount, Interest, Period);

            simpleInterestTextBox.Text = EndAmount + "";

        }
        
        public double CalculateInterest(double SAmount, double intrst)
        {
            double EndAmount = Math.Round((SAmount + (SAmount * intrst * 1)), 2);
            StartAmount = 0;
            Period = 0;
            Interest = 0;

            return EndAmount;
        }
        public double CalculateInterest(double SAmount, double intrst, double prd)
        {
            double EndAmount = Math.Round((SAmount + (SAmount * intrst * prd)), 2);
            StartAmount = 0;
            Period = 0;
            Interest = 0;


            return EndAmount;
        }
        public double CalculateInterest(double SAmount, double intrst, double prd, double cmpndngs)
        {
            //finalAmount = principle + principle*(1 + n/compundings)^(term*coumpoundings)
            double EndAmount = Math.Round((SAmount + (SAmount * Math.Pow((1 + (intrst / cmpndngs)), prd * cmpndngs))), 2);
            StartAmount = 0;
            Period = 0;
            Interest = 0;

            return EndAmount;
        }

        private void isTextAllowed(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.-]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void principleTextBoxClick(object sender, RoutedEventArgs e)
        {
            principleTextBox.Text = "";
            ErrorField.Text = "";
        }

        private void rateTextBoxClick(object sender, RoutedEventArgs e)
        {
            rateTextBox.Text = "";
            ErrorField.Text = "";
        }

        private void periodTextBoxClick(object sender, RoutedEventArgs e)
        {
            periodTextBox.Text = "";
            ErrorField.Text = "";
        }

    }
}
