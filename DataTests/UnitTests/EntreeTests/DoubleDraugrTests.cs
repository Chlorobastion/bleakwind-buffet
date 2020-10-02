/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Double Dragur class.
    /// </summary>
    public class DoubleDraugrTests
    {   
        /// <summary>
        /// Tests if bun is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        /// <summary>
        /// Tests if ketchup is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// Tests if mustard is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// Tests if pickles are included by default (they should be).
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// Tests if cheese is included by default (it shold be).
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        /// <summary>
        /// Tests if tomato is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        /// <summary>
        /// Tests if lettuce is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// Tests if mayo is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        /// <summary>
        /// Tests if bun is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        /// <summary>
        /// Tests if ketchup is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// Tests if mustard is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// Tests if pickle is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// Tests if cheese is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        /// <summary>
        /// Tests if tomato is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        /// <summary>
        /// Tests if lettuce is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// Tests if mayo is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        /// <summary>
        /// Tests if price is correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            double price = 7.32;
            Assert.Equal(price, dd.Price);
        }

        /// <summary>
        /// Tests if calories are correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            uint cal = 843;
            Assert.Equal(cal, dd.Calories);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        /// <param name="includeBun">Whether or not to include bun.</param>
        /// <param name="includeKetchup">Whether or not to include ketchup.</param>
        /// <param name="includeMustard">Whether or not to include mustard.</param>
        /// <param name="includePickle">Whether or not to include pickle.</param>
        /// <param name="includeCheese">Whether or not to include cheese.</param>
        /// <param name="includeTomato">Whether or not to include tomato.</param>
        /// <param name="includeLettuce">Whether or not to include lettuce.</param>
        /// <param name="includeMayo">Whether or not to include mayo.</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;
            if (!includeBun) { Assert.Contains("Hold bun", dd.SpecialInstructions); }
            if (!includeKetchup) { Assert.Contains("Hold ketchup", dd.SpecialInstructions); }
            if (!includeMustard) { Assert.Contains("Hold mustard", dd.SpecialInstructions); }
            if (!includePickle) { Assert.Contains("Hold pickle", dd.SpecialInstructions); }
            if (!includeCheese) { Assert.Contains("Hold cheese", dd.SpecialInstructions); }
            if (!includeTomato) { Assert.Contains("Hold tomato", dd.SpecialInstructions); }
            if (!includeLettuce) { Assert.Contains("Hold lettuce", dd.SpecialInstructions); }
            if (!includeMayo) { Assert.Contains("Hold mayo", dd.SpecialInstructions); }
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && 
                includeTomato && includeLettuce && includeMayo)
            { Assert.Empty(dd.SpecialInstructions); }
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }

        /// <summary>
        /// Tests if Double Draugr implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        /// <summary>
        /// Tests if Double Draugr can be cast to Entree base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        /// <summary>
        /// Tests if Double Draugr implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dd);
        }

        /// <summary>
        /// Tests if Double Draugr notifies of Bun change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfBunChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Bun", () => dd.Bun = false);
            Assert.PropertyChanged(dd, "Bun", () => dd.Bun = true);
        }

        /// <summary>
        /// Tests if Double Draugr notifies of Ketchup change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfKetchupChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () => dd.Ketchup = false);
            Assert.PropertyChanged(dd, "Ketchup", () => dd.Ketchup = true);
        }

        /// <summary>
        /// Tests if Double Draugr notifies of Mustard change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfMustardChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mustard", () => dd.Mustard = false);
            Assert.PropertyChanged(dd, "Mustard", () => dd.Mustard = true);
        }

        /// <summary>
        /// Tests if Double Draugr notifies of Pickle change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfPickleChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Pickle", () => dd.Pickle = false);
            Assert.PropertyChanged(dd, "Pickle", () => dd.Pickle = true);
        }

        /// <summary>
        /// Tests if Double Draugr notifies of Cheese change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCheeseChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Cheese", () => dd.Cheese = false);
            Assert.PropertyChanged(dd, "Cheese", () => dd.Cheese = true);
        }

        /// <summary>
        /// Tests if Double Draugr notifies of Tomato change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfTomatoChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Tomato", () => dd.Tomato = false);
            Assert.PropertyChanged(dd, "Tomato", () => dd.Tomato = true);
        }

        /// <summary>
        /// Tests if Double Draugr notifies of Lettuce change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfLettuceChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Lettuce", () => dd.Lettuce = false);
            Assert.PropertyChanged(dd, "Lettuce", () => dd.Lettuce = true);
        }

        /// <summary>
        /// Tests if Double Draugr notifies of Mayo change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfMayoChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mayo", () => dd.Mayo = false);
            Assert.PropertyChanged(dd, "Mayo", () => dd.Mayo = true);
        }
    }
}