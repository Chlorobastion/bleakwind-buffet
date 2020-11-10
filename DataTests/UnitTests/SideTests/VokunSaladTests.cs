/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

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

        /// <summary>
        /// Tests if Vokun Salad implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vs);
        }

        /// <summary>
        /// Tests if Vokun Salad can be cast to Side base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }

        /// <summary>
        /// Tests if Vokun Salad implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(vs);
        }

        /// <summary>
        /// Tests if Vokun Salad notifies of Size change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSizeChange()
        {
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(vs, "Size", () => vs.Size = Size.Small);
            Assert.PropertyChanged(vs, "Size", () => vs.Size = Size.Medium);
            Assert.PropertyChanged(vs, "Size", () => vs.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Vokun Salad notifies of Price change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfPriceChange()
        {
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(vs, "Price", () => vs.Size = Size.Small);
            Assert.PropertyChanged(vs, "Price", () => vs.Size = Size.Medium);
            Assert.PropertyChanged(vs, "Price", () => vs.Size = Size.Large);
        }

        /// <summary>
        /// Tests if Vokun Salad notifies of Calories change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCaloriesChange()
        {
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(vs, "Calories", () => vs.Size = Size.Small);
            Assert.PropertyChanged(vs, "Calories", () => vs.Size = Size.Medium);
            Assert.PropertyChanged(vs, "Calories", () => vs.Size = Size.Large);
        }

        /// <summary>
        /// Tests if side description works as expected.
        /// </summary>
        /// <param name="size">The size of the drink (Small, Medium, or Large).</param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldHaveCorrectDescription(Size size)
        {
            string expected = "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(expected, vs.Description);
        }
    }
}