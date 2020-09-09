/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Philly Poacher class.
    /// </summary>
    public class PhillyPoacherTests
    {
        /// <summary>
        /// Tests if sirloin is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        /// <summary>
        /// Tests if onion is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        /// <summary>
        /// Tests if roll is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        /// <summary>
        /// Tests if sirloin is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
        }

        /// <summary>
        /// Tests if onion is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = false;
            Assert.False(pp.Onion);
            pp.Onion = true;
            Assert.True(pp.Onion);
        }

        /// <summary>
        /// Tests if roll is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
            pp.Roll = true;
            Assert.True(pp.Roll);
        }

        /// <summary>
        /// Tests if price is correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            double price = 7.23;
            Assert.Equal(price, pp.Price);
        }

        /// <summary>
        /// Tests if calories are correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            uint cal = 784;
            Assert.Equal(cal, pp.Calories);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        /// <param name="includeSirloin">Whether or not to include sirloin.</param>
        /// <param name="includeOnion">Whether or not to include onion.</param>
        /// <param name="includeRoll">Whether or not to include roll.</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;
            if (!includeSirloin) { Assert.Contains("Hold sirloin", pp.SpecialInstructions); }
            if (!includeOnion) { Assert.Contains("Hold onions", pp.SpecialInstructions); }
            if (!includeRoll) { Assert.Contains("Hold roll", pp.SpecialInstructions); }
            if (includeSirloin && includeOnion && includeRoll)
            { Assert.Empty(pp.SpecialInstructions); }
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }

        /// <summary>
        /// Tests if Philly Poacher implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pp);
        }

        /// <summary>
        /// Tests if Philly Poacher can be cast to Entree base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }
    }
}