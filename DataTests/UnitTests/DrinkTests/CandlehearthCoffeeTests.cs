/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests for the Candlehearth Coffee class.
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        /// <summary>
        /// Tests if ice is included by default (it should not be).
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Ice);
        }

        /// <summary>
        /// Tests if coffee is decaf by default (it should not be).
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Decaf);
        }

        /// <summary>
        /// Tests if coffee has room for cream by default (it should not).
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.RoomForCream);
        }

        /// <summary>
        /// Tests if size is initially small (it should be).
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cc.Size);
        }

        /// <summary>
        /// Tests if ice is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
            cc.Ice = false;
            Assert.False(cc.Ice);
        }

        /// <summary>
        /// Tests if decaf is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
            cc.Decaf = false;
            Assert.False(cc.Decaf);
        }

        /// <summary>
        /// Tests if room for cream is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
            cc.RoomForCream = false;
            Assert.False(cc.RoomForCream);
        }

        /// <summary>
        /// Tests if drink size is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Large;
            Assert.Equal(Size.Large, cc.Size);
            cc.Size = Size.Medium;
            Assert.Equal(Size.Medium, cc.Size);
            cc.Size = Size.Small;
            Assert.Equal(Size.Small, cc.Size);
        }

        /// <summary>
        /// Tests if drink size is linked to drink price properly.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="price">The correct price of the particular drink and size.</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(price, cc.Price);
        }

        /// <summary>
        /// Tests if drink size is linked to drink calories properly.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="cal">The correct calories of the particular drink and size.</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(cal, cc.Calories);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        /// <param name="includeIce">Whether or not ice is to be included.</param>
        /// <param name="includeCream">Whether or not cream is to be included.</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = includeIce;
            cc.RoomForCream = includeCream;
            if (includeIce) { Assert.Contains("Add ice", cc.SpecialInstructions); }
            if (includeCream) { Assert.Contains("Add cream", cc.SpecialInstructions); }
            if (!includeIce && !includeCream) { Assert.Empty(cc.SpecialInstructions); }
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        /// <param name="decaf">Whether or not the coffee is decaf.</param>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="name">The correct name of the drink.</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = decaf;
            cc.Size = size;
            Assert.Equal(name, cc.ToString());
        }

        /// <summary>
        /// Tests if Candlehearth Coffee implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cc);
        }

        /// <summary>
        /// Tests if Candlehearth Coffee can be cast to Drink base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cc);
        }

        /// <summary>
        /// Tests if Candlehearth Coffee implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cc);
        }

        /// <summary>
        /// Tests if Candlehearth Coffee notifies of Size change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSizeChange()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Size", () => cc.Size = Size.Small);
            Assert.PropertyChanged(cc, "Size", () => cc.Size = Size.Medium);
            Assert.PropertyChanged(cc, "Size", () => cc.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Candlehearth Coffee notifies of Ice change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfIceChange()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Ice", () => cc.Ice = false);
            Assert.PropertyChanged(cc, "Ice", () => cc.Ice = true);
        }

        /// <summary>
        /// Tests if Candlehearth Coffee notifies of Ice change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfRoomForCreamChange()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "RoomForCream", () => cc.RoomForCream = false);
            Assert.PropertyChanged(cc, "RoomForCream", () => cc.RoomForCream = true);
        }

        /// <summary>
        /// Tests if Candlehearth Coffee notifies of Ice change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfDecafChange()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Decaf", () => cc.Decaf = false);
            Assert.PropertyChanged(cc, "Decaf", () => cc.Decaf = true);
        }
    }
}
