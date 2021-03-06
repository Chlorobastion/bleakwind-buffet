﻿/*
 * Author: Sebastian Neal
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests for the Warrior Water class.
    /// </summary>
    public class WarriorWaterTests
    {
        /// <summary>
        /// Tests if ice is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        /// <summary>
        /// Tests if lemon is included by default (it should not be).
        /// </summary>
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        /// <summary>
        /// Tests if size is initially small (it should be).
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        /// <summary>
        /// Tests if ice is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = false;
            Assert.False(ww.Ice);
            ww.Ice = true;
            Assert.True(ww.Ice);
        }

        /// <summary>
        /// Tests if lemon is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        /// <summary>
        /// Tests if drink size is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        /// <summary>
        /// Tests if drink size is linked to drink price properly.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, or Large).</param>
        /// <param name="price">The correct price of the particular drink and size.</param>
        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        /// <summary>
        /// Tests if drink size is linked to drink calories properly.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, or Large).</param>
        /// <param name="cal">The correct calories of the particular drink and size.</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        /// <param name="includeIce">Whether or not ice is to be included.</param>
        /// <param name="includeLemon">Whether or not lemon is to be included.</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (!includeIce) { Assert.Contains("Hold ice", ww.SpecialInstructions); }
            if (includeLemon) { Assert.Contains("Add lemon", ww.SpecialInstructions); }
            if(includeIce && !includeLemon) { Assert.Empty(ww.SpecialInstructions); }
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="name">The correct name of the drink.</param>
        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        /// <summary>
        /// Tests if Warrior Water implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        /// <summary>
        /// Tests if Warrior Water can be cast to Drink base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        /// <summary>
        /// Tests if Warrior Water implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }

        /// <summary>
        /// Tests if Warrior Water notifies of Size change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSizeChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () => ww.Size = Size.Small);
            Assert.PropertyChanged(ww, "Size", () => ww.Size = Size.Medium);
            Assert.PropertyChanged(ww, "Size", () => ww.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Warrior Water notifies of Ice change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfIceChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () => ww.Ice = false);
            Assert.PropertyChanged(ww, "Ice", () => ww.Ice = true);
        }

        /// <summary>
        /// Tests if Warrior Water notifies of Lemon change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfLemonChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Lemon", () => ww.Lemon = false);
            Assert.PropertyChanged(ww, "Lemon", () => ww.Lemon = true);
        }

        /// <summary>
        /// Tests if Warrior Water notifies of SpecialInstructions change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSpecialInstructionsChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "SpecialInstructions", () => ww.Ice = false);
            Assert.PropertyChanged(ww, "SpecialInstructions", () => ww.Ice = true);
            Assert.PropertyChanged(ww, "SpecialInstructions", () => ww.Lemon = false);
            Assert.PropertyChanged(ww, "SpecialInstructions", () => ww.Lemon = true);
        }

        /// <summary>
        /// Tests if drink description works as expected.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, or Large).</param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldHaveCorrectDescription(Size size)
        {
            string expected = "It’s water. Just water.";
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(expected, ww.Description);
        }
    }
}