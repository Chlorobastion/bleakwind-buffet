/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Smokehouse Skeleton class.
    /// </summary>
    public class SmokehouseSkeletonTests
    {        
        /// <summary>
        /// Tests if sausage is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            Assert.True(ssk.SausageLink);
        }

        /// <summary>
        /// Tests if eggs are included by default (they should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            Assert.True(ssk.Egg);
        }

        /// <summary>
        /// Tests if hashbrowns are included by default (they should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            Assert.True(ssk.HashBrowns);
        }

        /// <summary>
        /// Tests if pancakes are included by default (they should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            Assert.True(ssk.Pancake);
        }

        /// <summary>
        /// Tests if sausage is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            ssk.SausageLink = false;
            Assert.False(ssk.SausageLink);
            ssk.SausageLink = true;
            Assert.True(ssk.SausageLink);
        }

        /// <summary>
        /// Tests if egg is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            ssk.Egg = false;
            Assert.False(ssk.Egg);
            ssk.Egg = true;
            Assert.True(ssk.Egg);
        }

        /// <summary>
        /// Tests if hashbrowns are able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            ssk.HashBrowns = false;
            Assert.False(ssk.HashBrowns);
            ssk.HashBrowns = true;
            Assert.True(ssk.HashBrowns);
        }

        /// <summary>
        /// Tests if pancake is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            ssk.Pancake = false;
            Assert.False(ssk.Pancake);
            ssk.Pancake = true;
            Assert.True(ssk.Pancake);
        }

        /// <summary>
        /// Tests if price is correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            double price = 5.62;
            Assert.Equal(price, ssk.Price);
        }

        /// <summary>
        /// Tests if calories are correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            uint cal = 602;
            Assert.Equal(cal, ssk.Calories);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        /// <param name="includeSausage">Whether or not to include sausage.</param>
        /// <param name="includeEgg">Whether or not to include egg.</param>
        /// <param name="includeHashbrowns">Whether or not to include hash browns.</param>
        /// <param name="includePancake">Whether or not to include pancakes.</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            ssk.SausageLink = includeSausage;
            ssk.Egg = includeEgg;
            ssk.HashBrowns = includeHashbrowns;
            ssk.Pancake = includePancake;
            if (!includeSausage) { Assert.Contains("Hold sausage", ssk.SpecialInstructions); }
            if (!includeEgg) { Assert.Contains("Hold eggs", ssk.SpecialInstructions); }
            if (!includeHashbrowns) { Assert.Contains("Hold hash browns", ssk.SpecialInstructions); }
            if (!includePancake) { Assert.Contains("Hold pancakes", ssk.SpecialInstructions); }
            if (includeSausage && includeEgg && includeHashbrowns && includePancake)
            { Assert.Empty(ssk.SpecialInstructions); }
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ssk = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ssk.ToString());
        }

        /// <summary>
        /// Tests if Smokehouse Skeleton implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        /// <summary>
        /// Tests if Smokehouse Skeleton can be cast to Entree base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }
    }
}