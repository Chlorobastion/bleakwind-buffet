/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests for the Aretino Apple Juice class.
    /// </summary>
    public class AretinoAppleJuiceTests
    {
        /// <summary>
        /// Tests if ice is included by default (it should not be).
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// Tests if size is initially small (it should be).
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// Tests if ice is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// Tests if drink size is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// Tests if drink size is linked to drink price properly.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, or Large).</param>
        /// <param name="price">The correct price of the particular drink and size.</param>
        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        /// <summary>
        /// Tests if drink size is linked to drink calories properly.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, or Large).</param>
        /// <param name="cal">The correct calories of the particular drink and size.</param>
        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
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
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce) { Assert.Contains("Add ice", aj.SpecialInstructions); }
            else { Assert.Empty(aj.SpecialInstructions); }
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="name">The correct name of the drink.</param>
        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }

        /// <summary>
        /// Tests if Aretino Apple Juice implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        /// <summary>
        /// Tests if Aretino Apple Juice can be cast to Drink base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        /// <summary>
        /// Tests if Aretino Apple Juice implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        /// <summary>
        /// Tests if Aretino Apple Juice notifies of Size change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSizeChange()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Size", () => aj.Size = Size.Small);
            Assert.PropertyChanged(aj, "Size", () => aj.Size = Size.Medium);
            Assert.PropertyChanged(aj, "Size", () => aj.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Aretino Apple Juice notifies of Price change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfPriceChange()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Price", () => aj.Size = Size.Small);
            Assert.PropertyChanged(aj, "Price", () => aj.Size = Size.Medium);
            Assert.PropertyChanged(aj, "Price", () => aj.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Aretino Apple Juice notifies of Calories change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCaloriesChange()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = Size.Small);
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = Size.Medium);
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Aretino Apple Juice notifies of Ice change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfIceChange()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Ice", () => aj.Ice = false);
            Assert.PropertyChanged(aj, "Ice", () => aj.Ice = true);
        }

        /// <summary>
        /// Tests if Aretino Apple Juice notifies of SpecialInstructions change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSpecialInstructionsChange()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "SpecialInstructions", () => aj.Ice = false);
            Assert.PropertyChanged(aj, "SpecialInstructions", () => aj.Ice = true);
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
            string expected = "Fresh squeezed apple juice.";
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(expected, aj.Description);
        }
    }
}