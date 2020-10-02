/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using NuGet.Frameworks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests for the Markarth Milk class.
    /// </summary>
    public class MarkarthMilkTests
    {
        /// <summary>
        /// Tests if ice is included by default (it should not be).
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        /// <summary>
        /// Tests if size is initially small (it should be).
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.Size);
        }

        /// <summary>
        /// Tests if ice is able to be set.
        /// </summary>
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = true;
            Assert.True(mm.Ice);
            mm.Ice = false;
            Assert.False(mm.Ice);
        }

        /// <summary>
        /// Tests if drink size is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Small;
            Assert.Equal(Size.Small, mm.Size);
        }

        /// <summary>
        /// Tests if drink size is linked to drink price properly.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="price">The correct price of the particular drink and size.</param>
        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(price, mm.Price);
        }

        /// <summary>
        /// Tests if drink size is linked to drink calories properly.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="cal">The correct calories of hte particular drink and size.</param>
        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(cal, mm.Calories);
        }

        /// <summary>
        /// Tests if special instruction work as desired.
        /// </summary>
        /// <param name="includeIce">Whether or not ice is to be included.</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = includeIce;
            if (includeIce) { Assert.Contains("Add ice", mm.SpecialInstructions); }
            else { Assert.Empty(mm.SpecialInstructions); }
        }

        /// <summary>
        /// Tests if the ToString() returns the proper values.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, Large).</param>
        /// <param name="name">The correct name of the drink.</param>
        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(name, mm.ToString());
        }

        /// <summary>
        /// Tests if Markarth Milk implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
        }

        /// <summary>
        /// Tests if Markarth Milk can be cast to Drink base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
        }

        /// <summary>
        /// Tests if Markarth Milk implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mm);
        }

        /// <summary>
        /// Tests if Markarth Milk notifies of Size change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSizeChange()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Size", () => mm.Size = Size.Small);
            Assert.PropertyChanged(mm, "Size", () => mm.Size = Size.Medium);
            Assert.PropertyChanged(mm, "Size", () => mm.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Markarth Milk notifies of Ice change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfIceChange()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Ice", () => mm.Ice = false);
            Assert.PropertyChanged(mm, "Ice", () => mm.Ice = true);
        }
    }
}