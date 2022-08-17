using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionCalculator
{
    class CExchange
    {
        string fromCurrency;
        string toCurrency;
        double fromAmount;
        string stringRate;
        double doubleRate;

        public CExchange(string fromC, string toC, string amount, string rate)
        {
            fromCurrency = fromC;
            toCurrency = toC;
            fromAmount = double.Parse(amount);
            stringRate = rate;

        }

        public double calculateExchange()
        {
            double finalAmount = 0;
            switch (fromCurrency)
            {
                    //From South African Rand
                case "ZAR":
                    switch (toCurrency)
                    {
                            //To South African Rand
                        case "ZAR":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 1.00;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = fromAmount * doubleRate;
                            break;

                            //To United States Dollar
                        case "USD":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 14.43;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                            //To Japanese Yen
                        case "JPY":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 0.13;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                            //To Botswana Pula
                        case "BWP":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 1.35;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                            //To Pound Sterling
                        case "GBP":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 20.85;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                    }
                    break;

                    //From 
                case "USD":
                    switch (toCurrency)
                    {
                            //To South African
                        case "ZAR":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 14.43;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To United States Dollar
                        case "USD":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 1.00;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                            //Japanese Yen
                        case "JPY":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 111.13;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To Botswana Pula
                        case "BWP":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 10.70;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                        //To Pound Sterling
                        case "GBP":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 1.44;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                    }
                    break;

                    //From Japanese Yen
                case "JPY":
                    switch (toCurrency)
                    {
                            //To South African Rand
                        case "ZAR":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 0.13;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To United States Dollar
                        case "USD":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 111.13;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                            //To Japanese Yen
                        case "JPY":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 1.00;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To Botswana Pula
                        case "BWP":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 10.39;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                            //To Pound Sterling
                        case "GBP":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 160.64;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                    }
                    break;

                //From Botswana Pula
                case "BWP":
                    switch (toCurrency)
                    {
                            //To South African Rand
                        case "ZAR":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 1.35;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To United States Dollar
                        case "USD":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 10.70;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                            //To Japanese Yen
                        case "JPY":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 10.39;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To Botswana Pula
                        case "BWP":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 1.00;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To Pound Sterling
                        case "GBP":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 15.46;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                    }
                    break;

                    //From Pound Sterling
                case "GBP":
                    switch (toCurrency)
                    {
                            //To South African Rand
                        case "ZAR":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 20.85;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To United States Dollar
                        case "USD":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 1.44;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To Japanese Yen
                        case "JPY":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 160.64;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To Botswana Pula
                        case "BWP":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 15.46;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount * doubleRate), 2);
                            break;

                            //To Pound Sterling
                        case "GBP":
                            if (stringRate.Equals("Optional") || stringRate.Equals(""))
                            {
                                doubleRate = 1.00;
                            }
                            else
                            {
                                doubleRate = double.Parse(stringRate);
                            }

                            finalAmount = Math.Round((fromAmount / doubleRate), 2);
                            break;

                    }
                    break;

            }

            return finalAmount;
        }
    }
}

