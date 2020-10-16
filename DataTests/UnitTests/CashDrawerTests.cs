/*
 * Author: Sebastian Neal
 * Class name: CashDrawerTests.cs
 * Purpose: Class used to test the cash drawer.
 */

using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using RoundRegister;

namespace BleakwindBuffet.DataTests
{
    /// <summary>
    /// Tests for the Cash Drawer intermediary class.
    /// </summary>
    public class CashDrawerTests
    {
        /// <summary>
        /// Tests if register currency properties can be adjusted.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToChangeCurrenciesInRegister()
        {
            RoundRegister.CashDrawer.ResetDrawer();
            Data.CashDrawer cd = new Data.CashDrawer(0.00);
            cd.Pennies += 2;
            cd.Nickels += 2;
            cd.Dimes += 2;
            cd.Quarters += 2;
            cd.HalfDollars += 2;
            cd.Dollars += 2;
            cd.Ones += 2;
            cd.Twos += 2;
            cd.Fives += 2;
            cd.Tens += 2;
            cd.Twenties += 2;
            cd.Fifties += 2;
            cd.Hundreds += 2;
            Assert.Equal(202, cd.Pennies); //Apparently we start with 200 pennies
            Assert.Equal(82, cd.Nickels); //Apparently we start with 80 nickels
            Assert.Equal(102, cd.Dimes); //Apparently we start with 100 dimes
            Assert.Equal(82, cd.Quarters); //Apparently we start with 80 quarters
            Assert.Equal(2, cd.HalfDollars); //Apparently we start with 0 half dollars
            Assert.Equal(2, cd.Dollars); //Apparently we start with 0 dollars
            Assert.Equal(22, cd.Ones); //Apparently we start with 20 ones
            Assert.Equal(2, cd.Twos); //Apparently we start with 0 twos
            Assert.Equal(6, cd.Fives); //Apparently we start with 4 fives
            Assert.Equal(12, cd.Tens); //Apparently we start with 10 tens
            Assert.Equal(7, cd.Twenties); //Apparently we start with 5 twenties
            Assert.Equal(2, cd.Fifties); //Apparently we start with 0 fifties
            Assert.Equal(2, cd.Hundreds); //Apparently we start with 0 hundreds
        }

        /// <summary>
        /// Tests if customer currency properties can be adjusted.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToChangeCustomerCurrencies()
        {
            RoundRegister.CashDrawer.ResetDrawer();
            Data.CashDrawer cd = new Data.CashDrawer(0.00);
            cd.CustomerPennies += 2;
            cd.CustomerNickels += 2;
            cd.CustomerDimes += 2;
            cd.CustomerQuarters += 2;
            cd.CustomerHalfDollars += 2;
            cd.CustomerDollars += 2;
            cd.CustomerOnes += 2;
            cd.CustomerTwos += 2;
            cd.CustomerFives += 2;
            cd.CustomerTens += 2;
            cd.CustomerTwenties += 2;
            cd.CustomerFifties += 2;
            cd.CustomerHundreds += 2;
            Assert.Equal(2, cd.CustomerPennies);
            Assert.Equal(2, cd.CustomerNickels);
            Assert.Equal(2, cd.CustomerDimes);
            Assert.Equal(2, cd.CustomerQuarters);
            Assert.Equal(2, cd.CustomerHalfDollars);
            Assert.Equal(2, cd.CustomerDollars);
            Assert.Equal(2, cd.CustomerOnes);
            Assert.Equal(2, cd.CustomerTwos);
            Assert.Equal(2, cd.CustomerFives);
            Assert.Equal(2, cd.CustomerTens);
            Assert.Equal(2, cd.CustomerTwenties);
            Assert.Equal(2, cd.CustomerFifties);
            Assert.Equal(2, cd.CustomerHundreds);
        }

        /// <summary>
        /// Tests if change currency properties can be adjusted.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToChangeChangeCurrencies()
        {
            RoundRegister.CashDrawer.ResetDrawer();
            Data.CashDrawer cd = new Data.CashDrawer(0.00);
            cd.ChangePennies += 2;
            cd.ChangeNickels += 2;
            cd.ChangeDimes += 2;
            cd.ChangeQuarters += 2;
            cd.ChangeHalfDollars += 2;
            cd.ChangeDollars += 2;
            cd.ChangeOnes += 2;
            cd.ChangeTwos += 2;
            cd.ChangeFives += 2;
            cd.ChangeTens += 2;
            cd.ChangeTwenties += 2;
            cd.ChangeFifties += 2;
            cd.ChangeHundreds += 2;
            Assert.Equal(2, cd.ChangePennies);
            Assert.Equal(2, cd.ChangeNickels);
            Assert.Equal(2, cd.ChangeDimes);
            Assert.Equal(2, cd.ChangeQuarters);
            Assert.Equal(2, cd.ChangeHalfDollars);
            Assert.Equal(2, cd.ChangeDollars);
            Assert.Equal(2, cd.ChangeOnes);
            Assert.Equal(2, cd.ChangeTwos);
            Assert.Equal(2, cd.ChangeFives);
            Assert.Equal(2, cd.ChangeTens);
            Assert.Equal(2, cd.ChangeTwenties);
            Assert.Equal(2, cd.ChangeFifties);
            Assert.Equal(2, cd.ChangeHundreds);
        }

        /// <summary>
        /// Tests if the cash drawer can make proper change (assume
        /// drawer has enough of everything, and only use one extreme case to test)
        /// (My drawer is written to not give dollar or half dollar coins nor two bills as change,
        /// because I find those to be practically difficult to find in the real world.
        /// Additionally, I wrote this test to need 1 of every other currency type as change.)
        /// </summary>
        [Fact]
        public void ShouldBeAbleToMakeProperChange()
        {
            RoundRegister.CashDrawer.ResetDrawer();
            Data.CashDrawer cd = new Data.CashDrawer(186.41);
            cd.CustomerPennies += 2;
            cd.CustomerNickels += 2;
            cd.CustomerDimes += 2;
            cd.CustomerQuarters += 2;
            cd.CustomerOnes += 2;
            cd.CustomerFives += 2;
            cd.CustomerTens += 2;
            cd.CustomerTwenties += 2;
            cd.CustomerFifties += 2;
            cd.CustomerHundreds += 2;
            double change = cd.TotalChange; //This property calls the MakeChange() method internally
            Assert.Equal(1, cd.ChangePennies);
            Assert.Equal(1, cd.ChangeNickels);
            Assert.Equal(1, cd.ChangeDimes);
            Assert.Equal(1, cd.ChangeQuarters);
            Assert.Equal(0, cd.ChangeHalfDollars);
            Assert.Equal(0, cd.ChangeDollars);
            Assert.Equal(1, cd.ChangeOnes);
            Assert.Equal(0, cd.ChangeTwos);
            Assert.Equal(1, cd.ChangeFives);
            Assert.Equal(1, cd.ChangeTens);
            Assert.Equal(1, cd.ChangeTwenties);
            Assert.Equal(1, cd.ChangeFifties);
            Assert.Equal(1, cd.ChangeHundreds);
        }

        /// <summary>
        /// Tests if the cash drawer can properly finalize the sale.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToFinalizeSale()
        {
            RoundRegister.CashDrawer.ResetDrawer();
            Data.CashDrawer cd = new Data.CashDrawer(18.43);
            cd.CustomerFifties += 1;
            cd.FinalizeCashOrder();
            Assert.Equal(1, cd.ChangeTwenties);
            Assert.Equal(1, cd.ChangeTens);
            Assert.Equal(1, cd.ChangeOnes);
            Assert.Equal(2, cd.ChangeQuarters);
            Assert.Equal(1, cd.ChangeNickels);
            Assert.Equal(2, cd.ChangePennies);
            Assert.Equal(0, cd.Hundreds);
            Assert.Equal(1, cd.Fifties);
            Assert.Equal(4, cd.Twenties);
            Assert.Equal(9, cd.Tens);
            Assert.Equal(4, cd.Fives);
            Assert.Equal(0, cd.Twos);
            Assert.Equal(19, cd.Ones);
            Assert.Equal(0, cd.Dollars);
            Assert.Equal(0, cd.HalfDollars);
            Assert.Equal(78, cd.Quarters);
            Assert.Equal(100, cd.Dimes);
            Assert.Equal(79, cd.Nickels);
            Assert.Equal(198, cd.Pennies);
        }
    }
}
