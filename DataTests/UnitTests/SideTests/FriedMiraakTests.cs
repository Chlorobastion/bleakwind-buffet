/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Reflection.Emit;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Tests for the Fried Miraak class.
    /// </summary>
    public class FriedMiraakTests
    {
        /// <summary>
        /// Tests if the side size is small by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.Size);
        }

        /// <summary>
        /// Tests if size is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Large;
            Assert.Equal(Size.Large, fm.Size);
            fm.Size = Size.Medium;
            Assert.Equal(Size.Medium, fm.Size);
            fm.Size = Size.Small;
            Assert.Equal(Size.Small, fm.Size);
        }

        /// <summary>
        /// Tests if special instruction work as desired.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions);
        }

        /// <summary>
        /// Tests if side size is linked to side price properly.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="price">The correct price of the side.</param>
        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(price, fm.Price);
        }

        /// <summary>
        /// Tests if side size is linked to side calories properly.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="calories">The correct calories of the side.</param>
        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(calories, fm.Calories);
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="name">The correct name of the side.</param>
        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(name, fm.ToString());
        }

        /// <summary>
        /// Tests if Fried Miraak implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(fm);
        }

        /// <summary>
        /// Tests if Fried Miraak can be cast to Side base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
        }
    }
}