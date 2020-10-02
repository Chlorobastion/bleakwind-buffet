/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Briarheart Burger class.
    /// </summary>
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// Tests if bun is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        /// <summary>
        /// Tests if ketchup is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        /// <summary>
        /// Tests if mustard is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        /// <summary>
        /// Tests if pickles are included by default (they should be).
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        /// <summary>
        /// Tests if cheese is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        /// <summary>
        /// Tests if bun is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = false;
            Assert.False(bb.Bun);
            bb.Bun = true;
            Assert.True(bb.Bun);
        }

        /// <summary>
        /// Tests if ketchup is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
        }
        
        /// <summary>
        /// Tests if mustard is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = false;
            Assert.False(bb.Mustard);
            bb.Mustard = true;
            Assert.True(bb.Mustard);
        }

        /// <summary>
        /// Tests if pickle is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = false;
            Assert.False(bb.Pickle);
            bb.Pickle = true;
            Assert.True(bb.Pickle);
        }

        /// <summary>
        /// Tests if cheese is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = false;
            Assert.False(bb.Cheese);
            bb.Cheese = true;
            Assert.True(bb.Cheese);
        }

        /// <summary>
        /// Tests if price is correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            double price = 6.32;
            Assert.Equal(price, bb.Price);
        }

        /// <summary>
        /// Tests if calories are correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            uint cal = 743;
            Assert.Equal(cal, bb.Calories);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        /// <param name="includeBun">Whether or not to include bun.</param>
        /// <param name="includeKetchup">Whether or not to include ketchup.</param>
        /// <param name="includeMustard">Whether or not to include mustard.</param>
        /// <param name="includePickle">Whether or not to include pickle.</param>
        /// <param name="includeCheese">Whether or not to include cheese.</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;
            if (!includeBun) { Assert.Contains("Hold bun", bb.SpecialInstructions); }
            if (!includeKetchup) { Assert.Contains("Hold ketchup", bb.SpecialInstructions); }
            if (!includeMustard) { Assert.Contains("Hold mustard", bb.SpecialInstructions); }
            if (!includePickle) { Assert.Contains("Hold pickle", bb.SpecialInstructions); }
            if (!includeCheese) { Assert.Contains("Hold cheese", bb.SpecialInstructions); }
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese)
            { Assert.Empty(bb.SpecialInstructions); }
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }

        /// <summary>
        /// Tests if Briarheart Burger implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bb);
        }

        /// <summary>
        /// Tests if Briarheart Burger can be cast to Entree base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }

        /// <summary>
        /// Tests if Briarheart Burger implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bb);
        }

        /// <summary>
        /// Tests if Briarheart Burger notifies of Bun change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfBunChange()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Bun", () => bb.Bun = false);
            Assert.PropertyChanged(bb, "Bun", () => bb.Bun = true);
        }

        /// <summary>
        /// Tests if Briarheart Burger notifies of Ketchup change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfKetchupChange()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Ketchup", () => bb.Ketchup = false);
            Assert.PropertyChanged(bb, "Ketchup", () => bb.Ketchup = true);
        }

        /// <summary>
        /// Tests if Briarheart Burger notifies of Mustard change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfMustardChange()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Mustard", () => bb.Mustard = false);
            Assert.PropertyChanged(bb, "Mustard", () => bb.Mustard = true);
        }

        /// <summary>
        /// Tests if Briarheart Burger notifies of Pickle change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfPickleChange()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Pickle", () => bb.Pickle = false);
            Assert.PropertyChanged(bb, "Pickle", () => bb.Pickle = true);
        }

        /// <summary>
        /// Tests if Briarheart Burger notifies of Cheese change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCheeseChange()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Cheese", () => bb.Cheese = false);
            Assert.PropertyChanged(bb, "Cheese", () => bb.Cheese = true);
        }
    }
}