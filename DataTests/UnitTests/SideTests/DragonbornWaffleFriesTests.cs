/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Tests for the Dragonborn Waffle Fries class.
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        /// <summary>
        /// Tests if the side size is small by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dbwf.Size);
        }

        /// <summary>
        /// Tests if size is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            dbwf.Size = Size.Large;
            Assert.Equal(Size.Large, dbwf.Size);
            dbwf.Size = Size.Medium;
            Assert.Equal(Size.Medium, dbwf.Size);
            dbwf.Size = Size.Small;
            Assert.Equal(Size.Small, dbwf.Size);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.Empty(dbwf.SpecialInstructions);
        }

        /// <summary>
        /// Tests if side size is linked to side price properly.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="price">The correct price of the side.</param>
        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            dbwf.Size = size;
            Assert.Equal(price, dbwf.Price);
        }

        /// <summary>
        /// Tests if side size is linked to side calories properly.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="calories">The correct calories of the side.</param>
        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            dbwf.Size = size;
            Assert.Equal(calories, dbwf.Calories);
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="name">The correct name of the side.</param>
        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            dbwf.Size = size;
            Assert.Equal(name, dbwf.ToString());
        }

        /// <summary>
        /// Tests if Dragonborn Waffle Fries implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dbwf);
        }

        /// <summary>
        /// Tests if Dragonborn Waffle Fries can be cast to Side base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dbwf);
        }

        /// <summary>
        /// Tests if Dragonborn Waffle Fries implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dbwf);
        }

        /// <summary>
        /// Tests if Dragonborn Waffle Fries notifies of Size change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSizeChange()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.PropertyChanged(dbwf, "Size", () => dbwf.Size = Size.Small);
            Assert.PropertyChanged(dbwf, "Size", () => dbwf.Size = Size.Medium);
            Assert.PropertyChanged(dbwf, "Size", () => dbwf.Size = Size.Large);
        }
    }
}