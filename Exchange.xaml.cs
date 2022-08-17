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
    /// Interaction logic for Exchange.xaml
    /// </summary>
    public partial class Exchange : Window
    {
        string fromCurrency = "";
        string toCurrency = "";

        public Exchange()
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
            CInterest interest = new CInterest();
            interest.Show();
            this.Close();

            basicSubItem.IsChecked = false;
            interestSubItem.IsChecked = true;
            exchangeSubItem.IsCheckable = false;
        }

        private void Exchange_Click(object sender, RoutedEventArgs e)
        {
            //Do Nothing
        }

        private void Manual_Click(object sender, RoutedEventArgs e)
        {

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
        }


        //Combo box selections
        private void ZAR1_Selected(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            resultTextBox.Text = "";
            rateTextBox.Text = "Optional";
            fromCurrencyLabel.Text = "R";
            fromCurrency = "ZAR";
        }
        private void ZAR2_Selected(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            resultTextBox.Text = "";
            rateTextBox.Text = "Optional";
            toCurrencyLabel.Text = "R";
            toCurrency = "ZAR";
        }

        private void USD1_Selected(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            resultTextBox.Text = "";
            rateTextBox.Text = "Optional";
            fromCurrencyLabel.Text = "$";
            fromCurrency = "USD";
        }
        private void USD2_Selected(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            resultTextBox.Text = "";
            rateTextBox.Text = "Optional";
            toCurrencyLabel.Text = "$";
            toCurrency = "USD";
        }

        private void JPY1_Selected(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            resultTextBox.Text = "";
            rateTextBox.Text = "Optional";
            fromCurrencyLabel.Text = "¥";
            fromCurrency = "JPY";
        }
        private void JPY2_Selected(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            resultTextBox.Text = "";
            rateTextBox.Text = "Optional";
            toCurrencyLabel.Text = "¥";
            toCurrency = "JPY";
        }

        private void BWP1_Selected(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            resultTextBox.Text = "";
            rateTextBox.Text = "Optional";
            fromCurrencyLabel.Text = "P";
            fromCurrency = "BWP";
        }
        private void BWP2_Selected(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            resultTextBox.Text = "";
            rateTextBox.Text = "Optional"; ;
            toCurrencyLabel.Text = "P";
            toCurrency = "BWP";
        }

        private void GBP1_Selected(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            resultTextBox.Text = "";
            rateTextBox.Text = "Optional";
            fromCurrencyLabel.Text = "£";
            fromCurrency = "GBP";
        }
        private void GBP2_Selected(object sender, RoutedEventArgs e)
        {
            ErrorField.Text = "";
            resultTextBox.Text = "";
            rateTextBox.Text = "Optional";
            toCurrencyLabel.Text = "£";
            toCurrency = "GBP";
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            if (fromCurrency.Equals(""))
            {
                ErrorField.Text = "Please Select the currency to convert FROM";
            }
            else if(amountTextBox.Text.Equals("")){
                ErrorField.Text = "Please Enter amount to convert";
            }
            else if (toCurrency.Equals(""))
            {
                ErrorField.Text = "Please Select the currency to convert TO";
            }
            else
            {
                CExchange exchange = new CExchange(fromCurrency, toCurrency, amountTextBox.Text, rateTextBox.Text);

                resultTextBox.Text = "" + exchange.calculateExchange();
            }

            
        }

        private void amountTextBox_Click(object sender, RoutedEventArgs e)
        {
            amountTextBox.Text = "";
            ErrorField.Text = "";
            resultTextBox.Text = "";
        }

        private void rateTextBox_Click(object sender, RoutedEventArgs e)
        {
            rateTextBox.Text = "";
            resultTextBox.Text = "";
        }

        private void checkText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }


    }
}
