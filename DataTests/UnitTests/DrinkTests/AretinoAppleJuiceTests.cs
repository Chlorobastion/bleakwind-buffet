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
    }
}