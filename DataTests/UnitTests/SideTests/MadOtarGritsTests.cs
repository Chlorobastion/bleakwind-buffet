/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Tests for the Mad Otar Grits class.
    /// </summary>
    public class MadOtarGritsTests
    {
        /// <summary>
        /// Tests if the side size is small by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Equal(Size.Small, mog.Size);
        }
                
        /// <summary>
        /// Tests if size is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = Size.Large;
            Assert.Equal(Size.Large, mog.Size);
            mog.Size = Size.Medium;
            Assert.Equal(Size.Medium, mog.Size);
            mog.Size = Size.Small;
            Assert.Equal(Size.Small, mog.Size);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Empty(mog.SpecialInstructions);
        }

        /// <summary>
        /// Tests if side size is linked to side price properly.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="price">The correct price of the side.</param>
        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(price, mog.Price);
        }

        /// <summary>
        /// Tests if side size is linked to side calories properly.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medium, Large).</param>
        /// <param name="calories">The correct calories of the side.</param>
        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(calories, mog.Calories);
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        /// <param name="size">The size of the side (Small, Medim, Large).</param>
        /// <param name="name">The correct name of the side.</param>
        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(name, mog.ToString());
        }

        /// <summary>
        /// Tests if Mad Otar Grits implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mog);
        }

        /// <summary>
        /// Tests if Mad Otar Grits can be cast to Side base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mog);
        }
    }
}