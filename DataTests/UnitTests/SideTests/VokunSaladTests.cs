﻿/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Tests for the Vokun Salad class.
    /// </summary>
    public class VokunSaladTests
    {
        /// <summary>
        /// Tests if the side is small by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.Size);
        }

        /// <summary>
        /// Tests if size is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }

        /// <summary>
        /// Tests if side size is linked to side price properly.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="price">The correct price of the side.</param>
        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(price, vs.Price);
        }

        /// <summary>
        /// Tests if side size is linked to side calories properly.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="calories">The correct calories of the side.</param>
        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="name">The correct name of the side.</param>
        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }
    }
}