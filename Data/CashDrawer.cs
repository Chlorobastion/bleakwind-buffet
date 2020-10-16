/*
 * Author: Sebastian Neal
 * Class name: CashDrawer.cs
 * Purpose: Class used to represent the cash drawer.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using RoundRegister;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Intermediary class for cash drawer.
    /// </summary>
    public class CashDrawer : INotifyPropertyChanged
    {
        /// <summary>
        /// Event triggered when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variable to store total price of the order.
        /// </summary>
        private double orderPrice;

        /// <summary>
        /// Constructor for cash drawer.
        /// </summary>
        /// <param name="price">Total price of the current order.</param>
        public CashDrawer(double price)
        {
            orderPrice = price;
        }

        /// <summary>
        /// Getter for total price of the order.
        /// </summary>
        public double OrderPrice
        {
            get
            {
                return orderPrice;
            }
        }

        /// <summary>
        /// Property for pennies in the cash drawer.
        /// </summary>
        public int Pennies
        {
            get
            {
                return RoundRegister.CashDrawer.Pennies;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Pennies = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pennies"));
                }
            }
        }

        /// <summary>
        /// Property for nickels in the cash drawer.
        /// </summary>
        public int Nickels
        {
            get
            {
                return RoundRegister.CashDrawer.Nickels;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Nickels = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickels"));
                }
            }
        }

        /// <summary>
        /// Property for Dimes in the cash drawer.
        /// </summary>
        public int Dimes
        {
            get
            {
                return RoundRegister.CashDrawer.Dimes;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Dimes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimes"));
                }
            }
        }

        /// <summary>
        /// Property for Quarters in the cash drawer.
        /// </summary>
        public int Quarters
        {
            get
            {
                return RoundRegister.CashDrawer.Quarters;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Quarters = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarters"));
                }
            }
        }

        /// <summary>
        /// Property for HalfDollars in the cash drawer.
        /// </summary>
        public int HalfDollars
        {
            get
            {
                return RoundRegister.CashDrawer.HalfDollars;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.HalfDollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollars"));
                }
            }
        }

        /// <summary>
        /// Property for Dollars in the cash drawer.
        /// </summary>
        public int Dollars
        {
            get
            {
                return RoundRegister.CashDrawer.Dollars;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Dollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
                }
            }
        }

        /// <summary>
        /// Property for Ones in the cash drawer.
        /// </summary>
        public int Ones
        {
            get
            {
                return RoundRegister.CashDrawer.Ones;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Ones = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
                }
            }
        }

        /// <summary>
        /// Property for Twos in the cash drawer.
        /// </summary>
        public int Twos
        {
            get
            {
                return RoundRegister.CashDrawer.Twos;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Twos = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos"));
                }
            }
        }

        /// <summary>
        /// Property for Fives in the cash drawer.
        /// </summary>
        public int Fives
        {
            get
            {
                return RoundRegister.CashDrawer.Fives;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Fives = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
                }
            }
        }

        /// <summary>
        /// Property for Tens in the cash drawer.
        /// </summary>
        public int Tens
        {
            get
            {
                return RoundRegister.CashDrawer.Tens;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Tens = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
                }
            }
        }

        /// <summary>
        /// Property for Twenties in the cash drawer.
        /// </summary>
        public int Twenties
        {
            get
            {
                return RoundRegister.CashDrawer.Twenties;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Twenties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
                }
            }
        }

        /// <summary>
        /// Property for Fifties in the cash drawer.
        /// </summary>
        public int Fifties
        {
            get
            {
                return RoundRegister.CashDrawer.Fifties;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Fifties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
                }
            }
        }

        /// <summary>
        /// Property for hundreds in the cash drawer.
        /// </summary>
        public int Hundreds
        {
            get
            {
                return RoundRegister.CashDrawer.Hundreds;
            }
            set
            {
                if (value >= 0)
                {
                    RoundRegister.CashDrawer.Hundreds = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
                }
            }
        }

        /// <summary>
        /// Property for total in the cash drawer.
        /// </summary>
        public double Total
        {
            get
            {
                return RoundRegister.CashDrawer.Total;
            }
        }

        /// <summary>
        /// Private backing variable for pennies used by customer to pay for order.
        /// </summary>
        private int customerPennies = 0;

        /// <summary>
        /// Property for pennies used by the customer.
        /// </summary>
        public int CustomerPennies
        {
            get
            {
                return customerPennies;
            }
            set
            {
                if (value >= 0)
                {
                    customerPennies = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerPennies"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));

                }
            }
        }

        /// <summary>
        /// Private backing variable for nickels used by customer to pay for order.
        /// </summary>
        private int customerNickels = 0;

        /// <summary>
        /// Property for nickels used by the customer.
        /// </summary>
        public int CustomerNickels
        {
            get
            {
                return customerNickels;
            }
            set
            {
                if (value >= 0)
                {
                    customerNickels = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerNickels"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for dimes used by customer to pay for order.
        /// </summary>
        private int customerDimes = 0;

        /// <summary>
        /// Property for Dimes used by the customer.
        /// </summary>
        public int CustomerDimes
        {
            get
            {
                return customerDimes;
            }
            set
            {
                if (value >= 0)
                {
                    customerDimes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDimes"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for quarters used by customer to pay for order.
        /// </summary>
        private int customerQuarters = 0;

        /// <summary>
        /// Property for Quarters used by the customer.
        /// </summary>
        public int CustomerQuarters
        {
            get
            {
                return customerQuarters;
            }
            set
            {
                if (value >= 0)
                {
                    customerQuarters = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuarters"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for half dollars used by customer to pay for order.
        /// </summary>
        private int customerHalfDollars = 0;

        /// <summary>
        /// Property for HalfDollars used by the customer.
        /// </summary>
        public int CustomerHalfDollars
        {
            get
            {
                return customerHalfDollars;
            }
            set
            {
                if (value >= 0)
                {
                    customerHalfDollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHalfDollars"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for dollars (coin) used by customer to pay for order.
        /// </summary>
        private int customerDollars = 0;

        /// <summary>
        /// Property for Dollars (coins) used by the customer.
        /// </summary>
        public int CustomerDollars
        {
            get
            {
                return customerDollars;
            }
            set
            {
                if (value >= 0)
                {
                    customerDollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDollars"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for ones used by customer to pay for order.
        /// </summary>
        private int customerOnes = 0;

        /// <summary>
        /// Property for Ones used by the customer.
        /// </summary>
        public int CustomerOnes
        {
            get
            {
                return customerOnes;
            }
            set
            {
                if (value >= 0)
                {
                    customerOnes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerOnes"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for twos used by customer to pay for order.
        /// </summary>
        private int customerTwos = 0;

        /// <summary>
        /// Property for Twos used by the customer.
        /// </summary>
        public int CustomerTwos
        {
            get
            {
                return customerTwos;
            }
            set
            {
                if (value >= 0)
                {
                    customerTwos = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwos"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for fives used by customer to pay for order.
        /// </summary>
        private int customerFives = 0;

        /// <summary>
        /// Property for Fives used by the customer.
        /// </summary>
        public int CustomerFives
        {
            get
            {
                return customerFives;
            }
            set
            {
                if (value >= 0)
                {
                    customerFives = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFives"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for tens used by customer to pay for order.
        /// </summary>
        private int customerTens = 0;

        /// <summary>
        /// Property for Tens used by the customer.
        /// </summary>
        public int CustomerTens
        {
            get
            {
                return customerTens;
            }
            set
            {
                if (value >= 0)
                {
                    customerTens = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTens"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for twenties used by customer to pay for order.
        /// </summary>
        private int customerTwenties = 0;

        /// <summary>
        /// Property for Twenties used by the customer.
        /// </summary>
        public int CustomerTwenties
        {
            get
            {
                return customerTwenties;
            }
            set
            {
                if (value >= 0)
                {
                    customerTwenties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwenties"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for fifties used by customer to pay for order.
        /// </summary>
        private int customerFifties = 0;

        /// <summary>
        /// Property for Fifties used by the customer.
        /// </summary>
        public int CustomerFifties
        {
            get
            {
                return customerFifties;
            }
            set
            {
                if (value >= 0)
                {
                    customerFifties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFifties"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for hundreds used by customer to pay for order.
        /// </summary>
        private int customerHundreds = 0;

        /// <summary>
        /// Property for hundreds used by the customer.
        /// </summary>
        public int CustomerHundreds
        {
            get
            {
                return customerHundreds;
            }
            set
            {
                if (value >= 0)
                {
                    customerHundreds = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHundreds"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// Property for total amount given by customer.
        /// </summary>
        public double CustomerTotal
        {
            get
            {
                double total = 0;
                total += customerPennies * 0.01;
                total += customerNickels * 0.05;
                total += customerDimes * 0.10;
                total += customerQuarters * 0.25;
                total += customerHalfDollars * 0.50;
                total += customerDollars * 1.00;
                total += customerOnes * 1.00;
                total += customerTwos * 2.00;
                total += customerFives * 5.00;
                total += customerTens * 10.00;
                total += customerTwenties * 20.00;
                total += customerFifties * 50.00;
                total += customerHundreds * 100.00;
                return total;
            }
        }

        /// <summary>
        /// Private backing variable for pennies owed in change to the customer.
        /// </summary>
        private int changePennies;

        /// <summary>
        /// Property for pennies owed to the customer.
        /// </summary>
        public int ChangePennies
        {
            get
            {
                return changePennies;
            }
            set
            {
                if (value >= 0)
                {
                    changePennies = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for nickels owed in change to the customer.
        /// </summary>
        private int changeNickels;

        /// <summary>
        /// Property for nickels owed to the customer.
        /// </summary>
        public int ChangeNickels
        {
            get
            {
                return changeNickels;
            }
            set
            {
                if (value >= 0)
                {
                    changeNickels = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for dimes owed in change to the customer.
        /// </summary>
        private int changeDimes;

        /// <summary>
        /// Property for Dimes owed to the customer.
        /// </summary>
        public int ChangeDimes
        {
            get
            {
                return changeDimes;
            }
            set
            {
                if (value >= 0)
                {
                    changeDimes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for quarters owed in change to the customer.
        /// </summary>
        private int changeQuarters;

        /// <summary>
        /// Property for Quarters owed to the customer.
        /// </summary>
        public int ChangeQuarters
        {
            get
            {
                return changeQuarters;
            }
            set
            {
                if (value >= 0)
                {
                    changeQuarters = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for half dollars owed in change to the customer.
        /// </summary>
        private int changeHalfDollars;

        /// <summary>
        /// Property for HalfDollars owed to the customer.
        /// </summary>
        public int ChangeHalfDollars
        {
            get
            {
                return changeHalfDollars;
            }
            set
            {
                if (value >= 0)
                {
                    changeHalfDollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for dollars (coins) owed in change to the customer.
        /// </summary>
        private int changeDollars;

        /// <summary>
        /// Property for Dollars (coins) owed to the customer.
        /// </summary>
        public int ChangeDollars
        {
            get
            {
                return changeDollars;
            }
            set
            {
                if (value >= 0)
                {
                    changeDollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollars"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for ones owed in change to the customer.
        /// </summary>
        private int changeOnes;

        /// <summary>
        /// Property for Ones owed to the customer.
        /// </summary>
        public int ChangeOnes
        {
            get
            {
                return changeOnes;
            }
            set
            {
                if (value >= 0)
                {
                    changeOnes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for twos owed in change to the customer.
        /// </summary>
        private int changeTwos;

        /// <summary>
        /// Property for Twos owed to the customer.
        /// </summary>
        public int ChangeTwos
        {
            get
            {
                return changeTwos;
            }
            set
            {
                if (value >= 0)
                {
                    changeTwos = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for fives owed in change to the customer.
        /// </summary>
        private int changeFives;

        /// <summary>
        /// Property for Fives owed to the customer.
        /// </summary>
        public int ChangeFives
        {
            get
            {
                return changeFives;
            }
            set
            {
                if (value >= 0)
                {
                    changeFives = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for tens owed in change to the customer.
        /// </summary>
        private int changeTens;

        /// <summary>
        /// Property for Tens owed to the customer.
        /// </summary>
        public int ChangeTens
        {
            get
            {
                return changeTens;
            }
            set
            {
                if (value >= 0)
                {
                    changeTens = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for twenties owed in change to the customer.
        /// </summary>
        private int changeTwenties;

        /// <summary>
        /// Property for Twenties owed to the customer.
        /// </summary>
        public int ChangeTwenties
        {
            get
            {
                return changeTwenties;
            }
            set
            {
                if (value >= 0)
                {
                    changeTwenties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for fifties owed in change to the customer.
        /// </summary>
        private int changeFifties;

        /// <summary>
        /// Property for Fifties owed to the customer.
        /// </summary>
        public int ChangeFifties
        {
            get
            {
                return changeFifties;
            }
            set
            {
                if (value >= 0)
                {
                    changeFifties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for hundreds owed in change to the customer.
        /// </summary>
        private int changeHundreds;

        /// <summary>
        /// Property for hundreds owed to the customer.
        /// </summary>
        public int ChangeHundreds
        {
            get
            {
                return changeHundreds;
            }
            set
            {
                if (value >= 0)
                {
                    changeHundreds = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
                }
            }
        }

        /// <summary>
        /// Calculates minimum amounts of denominations of money for customer change
        /// (does not care if specific denomination is available, just calculates
        /// what SHOULD be given in change)
        /// </summary>
        /// <returns>The total change owed to the customer.</returns>
        private double MakeChange()
        {
            double totalChange = CustomerTotal - orderPrice;
            double originalChange = totalChange;
            ChangePennies = 0;
            ChangeNickels = 0;
            ChangeDimes = 0;
            ChangeQuarters = 0;
            ChangeOnes = 0;
            ChangeTwos = 0;
            ChangeFives = 0;
            ChangeTens = 0;
            ChangeTwenties = 0;
            ChangeFifties = 0;
            ChangeHundreds = 0;
            if (totalChange < 0)
            {
                return 0.00;
            }
            while (totalChange != 0.00)
            {
                totalChange = Math.Round(totalChange, 2); //use this to fix any rounding error between steps
                if (Math.Floor(totalChange / 100) > 0)
                {
                    ChangeHundreds += 1;
                    totalChange -= 100.00;
                    continue;
                }
                else if (Math.Floor(totalChange / 50) > 0)
                {
                    ChangeFifties += 1;
                    totalChange -= 50.00;
                    continue;
                }
                else if (Math.Floor(totalChange / 20) > 0)
                {
                    ChangeTwenties += 1;
                    totalChange -= 20.00;
                    continue;
                }
                else if (Math.Floor(totalChange / 10) > 0)
                {
                    ChangeTens += 1;
                    totalChange -= 10.00;
                    continue;
                }
                else if (Math.Floor(totalChange / 5) > 0)
                {
                    ChangeFives += 1;
                    totalChange -= 5.00;
                    continue;
                }
                else if (Math.Floor(totalChange / 1) > 0)
                {
                    ChangeOnes += 1;
                    totalChange -= 1.00;
                    continue;
                }
                else if (Math.Floor(totalChange / 0.25) > 0)
                {
                    ChangeQuarters += 1;
                    totalChange -= 0.25;
                    continue;
                }
                else if (Math.Floor(totalChange / 0.1) > 0)
                {
                    ChangeDimes += 1;
                    totalChange -= 0.10;
                    continue;
                }
                else if (Math.Floor(totalChange / 0.05) > 0)
                {
                    ChangeNickels += 1;
                    totalChange -= 0.05;
                    continue;
                }
                else if (Math.Floor(totalChange / 0.01) > 0)
                {
                    ChangePennies += 1;
                    totalChange -= 0.01;
                    continue;
                }
            }
            return originalChange;
        }

        /// <summary>
        /// Getter for the total amount of change owed the customer.
        /// </summary>
        public double TotalChange
        {
            get
            {
                return MakeChange();
            }
        }

        /// <summary>
        /// The amount remaining that the customer still needs to pay.
        /// </summary>
        /// <returns>The amount still remaining to be paid.</returns>
        private double amountDue()
        {
            double amountDue = orderPrice;
            amountDue -= CustomerPennies * 0.01;
            amountDue -= CustomerNickels * 0.05;
            amountDue -= CustomerDimes * 0.10;
            amountDue -= CustomerQuarters * 0.25;
            amountDue -= CustomerHalfDollars * 0.50;
            amountDue -= CustomerDollars * 1.00;
            amountDue -= CustomerOnes * 1.00;
            amountDue -= CustomerTwos * 2.00;
            amountDue -= CustomerFives * 5.00;
            amountDue -= CustomerTens * 10.00;
            amountDue -= CustomerTwenties * 20.00;
            amountDue -= CustomerFifties * 50.00;
            amountDue -= CustomerHundreds * 100.00;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            if (amountDue < 0)
            {
                return 0.00;
            }
            return amountDue;
        }

        /// <summary>
        /// Getter for the amount due.
        /// </summary>
        public double AmountDue
        {
            get
            {
                return amountDue();
            }
        }

        /// <summary>
        /// Finalizes the cash order.
        /// </summary>
        /// <returns>Whether or not the order was able to be finalized.</returns>
        public bool FinalizeCashOrder()
        {
            double amountDue = AmountDue;
            if (amountDue > 0.00)
            {
                return false;
            }
            else
            {
                MakeChange();
                RoundRegister.CashDrawer.OpenDrawer();
                Pennies = Pennies + CustomerPennies - ChangePennies;
                Nickels = Nickels + CustomerNickels - ChangeNickels;
                Dimes = Dimes + CustomerDimes - ChangeDimes;
                Quarters = Quarters + CustomerQuarters - ChangeQuarters;
                HalfDollars = HalfDollars + CustomerHalfDollars - ChangeHalfDollars;
                Dollars = Dollars + CustomerDollars - ChangeDollars;
                Ones = Ones + CustomerOnes - ChangeOnes;
                Twos = Twos + CustomerTwos - ChangeTwos;
                Fives = Fives + CustomerFives - ChangeFives;
                Tens = Tens + CustomerTens - ChangeTens;
                Twenties = Twenties + CustomerTwenties - ChangeTwenties;
                Fifties = Fifties + CustomerFifties - ChangeFifties;
                Hundreds = Hundreds + CustomerHundreds - ChangeHundreds;
                return true;
            }
        }
    }
}
