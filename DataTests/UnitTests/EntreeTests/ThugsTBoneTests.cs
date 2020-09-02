/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Thugs T-Bone class.
    /// </summary>
    public class ThugsTBoneTests
    {
        /// <summary>
        /// Tests if price is correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone ttb = new ThugsTBone();
            double price = 6.44;
            Assert.Equal(price, ttb.Price);
        }

        /// <summary>
        /// Tests if calories are correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone ttb = new ThugsTBone();
            uint cal = 982;
            Assert.Equal(cal, ttb.Calories);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Empty(ttb.SpecialInstructions);
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", ttb.ToString());
        }
    }
}