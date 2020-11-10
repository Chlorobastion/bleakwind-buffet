/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Thalmor Triple class.
    /// </summary>
    public class ThalmorTripleTests
    {
        /// <summary>
        /// Tests if bun is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        /// <summary>
        /// Tests if ketchup is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// Tests if mustard is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Tests if pickle are included by default (they should be).
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        /// <summary>
        /// Tests if cheese is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Tests if tomato is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Tests if lettuce is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Tests if mayo is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Tests if bacon is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Tests if egg is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        /// <summary>
        /// Tests if bun is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        /// <summary>
        /// Tests if ketchup is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// Tests if mustard is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Tests if pickle is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        /// <summary>
        /// Tests if cheese is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Tests if tomato is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Tests if lettuce is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Tests if mayo is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Tests if bacon is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Tests if egg is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }

        /// <summary>
        /// Tests if price is correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            double price = 8.32;
            Assert.Equal(price, tt.Price);
        }

        /// <summary>
        /// Tests if calories are correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            uint cal = 943;
            Assert.Equal(cal, tt.Calories);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        /// <param name="includeBun">Whether or not to include bun.</param>
        /// <param name="includeKetchup">Whether or not to include ketchup.</param>
        /// <param name="includeMustard">Whether or not to include mustard.</param>
        /// <param name="includePickle">Whether or not to include pickle.</param>
        /// <param name="includeCheese">Whether or not to inclede cheese.</param>
        /// <param name="includeTomato">Whether or not to include tomato.</param>
        /// <param name="includeLettuce">Whether or not to include lettuce.</param>
        /// <param name="includeMayo">Whether or not to include mayo.</param>
        /// <param name="includeBacon">Whether or not to include bacon.</param>
        /// <param name="includeEgg">Whether or not to include egg.</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;
            if (!includeBun) { Assert.Contains("Hold bun", tt.SpecialInstructions); }
            if (!includeKetchup) { Assert.Contains("Hold ketchup", tt.SpecialInstructions); }
            if (!includeMustard) { Assert.Contains("Hold mustard", tt.SpecialInstructions); }
            if (!includePickle) { Assert.Contains("Hold pickle", tt.SpecialInstructions); }
            if (!includeCheese) { Assert.Contains("Hold cheese", tt.SpecialInstructions); }
            if (!includeTomato) { Assert.Contains("Hold tomato", tt.SpecialInstructions); }
            if (!includeLettuce) { Assert.Contains("Hold lettuce", tt.SpecialInstructions); }
            if (!includeMayo) { Assert.Contains("Hold mayo", tt.SpecialInstructions); }
            if (!includeBacon) { Assert.Contains("Hold bacon", tt.SpecialInstructions); }
            if (!includeEgg) { Assert.Contains("Hold egg", tt.SpecialInstructions); }
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese &&
                includeTomato && includeLettuce && includeMayo && includeBacon && includeEgg)
            { Assert.Empty(tt.SpecialInstructions); }
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }

        /// <summary>
        /// Tests if Thalmor Triple implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        /// <summary>
        /// Tests if Thalmor Triple can be cast to Entree base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        /// <summary>
        /// Tests if Thalmor Triple implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Bun change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfBunChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bun", () => tt.Bun = false);
            Assert.PropertyChanged(tt, "Bun", () => tt.Bun = true);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Ketchup change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfKetchupChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Ketchup", () => tt.Ketchup = false);
            Assert.PropertyChanged(tt, "Ketchup", () => tt.Ketchup = true);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Mustard change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfMustardChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mustard", () => tt.Mustard = false);
            Assert.PropertyChanged(tt, "Mustard", () => tt.Mustard = true);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Pickle change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfPickleChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Pickle", () => tt.Pickle = false);
            Assert.PropertyChanged(tt, "Pickle", () => tt.Pickle = true);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Cheese change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCheeseChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Cheese", () => tt.Cheese = false);
            Assert.PropertyChanged(tt, "Cheese", () => tt.Cheese = true);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Tomato change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfTomatoChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Tomato", () => tt.Tomato = false);
            Assert.PropertyChanged(tt, "Tomato", () => tt.Tomato = true);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Lettuce change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfLettuceChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Lettuce", () => tt.Lettuce = false);
            Assert.PropertyChanged(tt, "Lettuce", () => tt.Lettuce = true);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Mayo change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfMayoChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mayo", () => tt.Mayo = false);
            Assert.PropertyChanged(tt, "Mayo", () => tt.Mayo = true);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Bacon change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfBaconChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bacon", () => tt.Bacon = false);
            Assert.PropertyChanged(tt, "Bacon", () => tt.Bacon = true);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Egg change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfEggChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Egg", () => tt.Egg = false);
            Assert.PropertyChanged(tt, "Egg", () => tt.Egg = true);
        }

        /// <summary>
        /// Tests if Thalmor Triple notifies of Special Instructions change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSpecialInstructionsChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Bun = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Bun = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Ketchup = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Ketchup = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Mustard = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Mustard = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Pickle = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Pickle = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Cheese = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Cheese = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Tomato = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Tomato = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Lettuce = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Lettuce = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Mayo = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Mayo = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Bacon = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Bacon = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Egg = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Egg = true);
        }

        /// <summary>
        /// Tests if entree description works as expected.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            string expected = "Think you are strong enough to take on the Thalmor? Includes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(expected, tt.Description);
        }
    }
}