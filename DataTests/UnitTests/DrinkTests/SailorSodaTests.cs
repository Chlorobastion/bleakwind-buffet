﻿/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests for the Sailor Soda class.
    /// </summary>
    public class SailorSodaTests
    {
        /// <summary>
        /// Tests if ice is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.True(ss.Ice);
        }

        /// <summary>
        /// Tests if size is initially small (it should be).
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(Size.Small, ss.Size);
        }

        /// <summary>
        /// Tests if flavor is initially cherry (it should be).
        /// </summary>
        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
        }

        /// <summary>
        /// Tests if ice is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = false;
            Assert.False(ss.Ice);
            ss.Ice = true;
            Assert.True(ss.Ice);
        }

        /// <summary>
        /// Tests if drink size is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = Size.Large;
            Assert.Equal(Size.Large, ss.Size);
            ss.Size = Size.Medium;
            Assert.Equal(Size.Medium, ss.Size);
            ss.Size = Size.Small;
            Assert.Equal(Size.Small, ss.Size);
        }

        /// <summary>
        /// Tests if drink flavor is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda ss = new SailorSoda();
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, ss.Flavor);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
        }

        /// <summary>
        /// Tests if drink size is linked to drink price properly.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="price">The correct price of the particular drink and size.</param>
        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(price, ss.Price);
        }

        /// <summary>
        /// Tests if drink size is linked to drink calories properly.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="cal">The correct calories of the particular drink and size.</param>
        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(cal, ss.Calories);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        /// <param name="includeIce">Whether or not ice is to be included.</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = includeIce;
            if (!includeIce) { Assert.Contains("Hold ice", ss.SpecialInstructions); }
            else { Assert.Empty(ss.SpecialInstructions); }
        }
        
        /// <summary>
        /// Tests if the ToString() returns the proper values.
        /// </summary>
        /// <param name="flavor">The flavor of the drink (Blackberry, Cherry,
        /// Grapefruit, Lemon, Peach, Watermelon).</param>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="name">The correct name of the drink.</param>
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            ss.Flavor = flavor;
            Assert.Equal(name, ss.ToString());
        }

        /// <summary>
        /// Tests if Sailor Soda implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        /// <summary>
        /// Tests if Sailor Soda can be cast to Drink base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(ss);
        }

        /// <summary>
        /// Tests if Sailor Soda implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }

        /// <summary>
        /// Tests if Sailor Soda notifies of Size change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSizeChange()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Size", () => ss.Size = Size.Small);
            Assert.PropertyChanged(ss, "Size", () => ss.Size = Size.Medium);
            Assert.PropertyChanged(ss, "Size", () => ss.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Sailor Soda notifies of Price change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfPriceChange()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Price", () => ss.Size = Size.Small);
            Assert.PropertyChanged(ss, "Price", () => ss.Size = Size.Medium);
            Assert.PropertyChanged(ss, "Price", () => ss.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Sailor Soda notifies of Calories change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCaloriesChange()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Calories", () => ss.Size = Size.Small);
            Assert.PropertyChanged(ss, "Calories", () => ss.Size = Size.Medium);
            Assert.PropertyChanged(ss, "Calories", () => ss.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Sailor Soda notifies of Ice change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfIceChange()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Ice", () => ss.Ice = false);
            Assert.PropertyChanged(ss, "Ice", () => ss.Ice = true);
        }

        /// <summary>
        /// Tests if Sailor Soda notifies of Flavor change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfFlavorChange()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Flavor", () => ss.Flavor = SodaFlavor.Blackberry);
            Assert.PropertyChanged(ss, "Flavor", () => ss.Flavor = SodaFlavor.Cherry);
            Assert.PropertyChanged(ss, "Flavor", () => ss.Flavor = SodaFlavor.Grapefruit);
            Assert.PropertyChanged(ss, "Flavor", () => ss.Flavor = SodaFlavor.Lemon);
            Assert.PropertyChanged(ss, "Flavor", () => ss.Flavor = SodaFlavor.Peach);
            Assert.PropertyChanged(ss, "Flavor", () => ss.Flavor = SodaFlavor.Watermelon);
        }

        /// <summary>
        /// Tests if Sailor Soda notifies of Special Instructions change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSpecialInstructionsChange()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "SpecialInstructions", () => ss.Ice = false);
            Assert.PropertyChanged(ss, "SpecialInstructions", () => ss.Ice = true);
        }

        /// <summary>
        /// Tests if drink description works as expected.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, or Large).</param>
        [Theory]
        [InlineData(Size.Small, SodaFlavor.Cherry)]
        [InlineData(Size.Small, SodaFlavor.Blackberry)]
        [InlineData(Size.Small, SodaFlavor.Grapefruit)]
        [InlineData(Size.Small, SodaFlavor.Lemon)]
        [InlineData(Size.Small, SodaFlavor.Peach)]
        [InlineData(Size.Small, SodaFlavor.Watermelon)]
        [InlineData(Size.Medium, SodaFlavor.Cherry)]
        [InlineData(Size.Medium, SodaFlavor.Blackberry)]
        [InlineData(Size.Medium, SodaFlavor.Grapefruit)]
        [InlineData(Size.Medium, SodaFlavor.Lemon)]
        [InlineData(Size.Medium, SodaFlavor.Peach)]
        [InlineData(Size.Medium, SodaFlavor.Watermelon)]
        [InlineData(Size.Large, SodaFlavor.Cherry)]
        [InlineData(Size.Large, SodaFlavor.Blackberry)]
        [InlineData(Size.Large, SodaFlavor.Grapefruit)]
        [InlineData(Size.Large, SodaFlavor.Lemon)]
        [InlineData(Size.Large, SodaFlavor.Peach)]
        [InlineData(Size.Large, SodaFlavor.Watermelon)]
        public void ShouldHaveCorrectDescription(Size size, SodaFlavor flavor)
        {
            string expected = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            ss.Flavor = flavor;
            Assert.Equal(expected, ss.Description);
        }
    }
}