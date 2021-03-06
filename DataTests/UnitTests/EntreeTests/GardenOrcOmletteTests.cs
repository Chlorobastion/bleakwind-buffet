﻿/*
 * Author: Zachery Brunner
 * Edited by: Sebastian Neal
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using NuGet.Frameworks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Garden Orc Omelette class.
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// Tests if broccoli is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        /// <summary>
        /// Tests if muchrooms are included by default (they should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        /// <summary>
        /// Tests if tomato is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato);
        }

        /// <summary>
        /// Tests if cheddar is included by default (it should be).
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        /// <summary>
        /// Tests if broccoli is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
        }

        /// <summary>
        /// Tests if mushrooms is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
        }

        /// <summary>
        /// Tests if tomato is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = false;
            Assert.False(goo.Tomato);
            goo.Tomato = true;
            Assert.True(goo.Tomato);
        }

        /// <summary>
        /// Tests if cheddar is able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
        }

        /// <summary>
        /// Tests if price is correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            double price = 4.57;
            Assert.Equal(price, goo.Price);
        }

        /// <summary>
        /// Tests if calories are correct.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            uint cal = 404;
            Assert.Equal(cal, goo.Calories);
        }

        /// <summary>
        /// Tests if special instructions work as desired.
        /// </summary>
        /// <param name="includeBroccoli">Whether or not to include broccoli.</param>
        /// <param name="includeMushrooms">Whether or not to include mushrooms.</param>
        /// <param name="includeTomato">Whether or not to include tomato.</param>
        /// <param name="includeCheddar">Whether or not to include cheddar.</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            goo.Mushrooms = includeMushrooms;
            goo.Tomato = includeTomato;
            goo.Cheddar = includeCheddar;
            if (!includeBroccoli) { Assert.Contains("Hold broccoli", goo.SpecialInstructions); }
            if (!includeMushrooms) { Assert.Contains("Hold mushrooms", goo.SpecialInstructions); }
            if (!includeTomato) { Assert.Contains("Hold tomato", goo.SpecialInstructions); }
            if (!includeCheddar) { Assert.Contains("Hold cheddar", goo.SpecialInstructions); }
            if (includeBroccoli && includeMushrooms && includeTomato && includeCheddar)
            { Assert.Empty(goo.SpecialInstructions); }
        }

        /// <summary>
        /// Tests if the ToString() method returns the proper values.
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }

        /// <summary>
        /// Tests if Garden Orc Omelette implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goo);
        }

        /// <summary>
        /// Tests if Garden Orc Omelette can be cast to Entree base class.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        /// <summary>
        /// Tests if Garden Orc Omelette implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(goo);
        }

        /// <summary>
        /// Tests if Garden Orc Omelette notifies of Broccoli change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfBroccoliChange()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Broccoli", () => goo.Broccoli = false);
            Assert.PropertyChanged(goo, "Broccoli", () => goo.Broccoli = true);
        }

        /// <summary>
        /// Tests if Garden Orc Omelette notifies of Mushrooms change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfMushroomsChange()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Mushrooms", () => goo.Mushrooms = false);
            Assert.PropertyChanged(goo, "Mushrooms", () => goo.Mushrooms = true);
        }

        /// <summary>
        /// Tests if Garden Orc Omelette notifies of Tomato change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfTomatoChange()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Tomato", () => goo.Tomato = false);
            Assert.PropertyChanged(goo, "Tomato", () => goo.Tomato = true);
        }

        /// <summary>
        /// Tests if Garden Orc Omelette notifies of Cheddar change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCheddarChange()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Cheddar", () => goo.Cheddar = false);
            Assert.PropertyChanged(goo, "Cheddar", () => goo.Cheddar = true);
        }

        /// <summary>
        /// Tests if Garden Orc Omelette notifies of Special Instructions change.
        /// </summary>
        [Fact]
        public void ShouldNotifyOfSpecialInstructionsChange()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "SpecialInstructions", () => goo.Broccoli = false);
            Assert.PropertyChanged(goo, "SpecialInstructions", () => goo.Broccoli = true);
            Assert.PropertyChanged(goo, "SpecialInstructions", () => goo.Mushrooms = false);
            Assert.PropertyChanged(goo, "SpecialInstructions", () => goo.Mushrooms = true);
            Assert.PropertyChanged(goo, "SpecialInstructions", () => goo.Tomato = false);
            Assert.PropertyChanged(goo, "SpecialInstructions", () => goo.Tomato = true);
            Assert.PropertyChanged(goo, "SpecialInstructions", () => goo.Cheddar = false);
            Assert.PropertyChanged(goo, "SpecialInstructions", () => goo.Cheddar = true);
        }

        /// <summary>
        /// Tests if entree description works as expected.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            string expected = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(expected, goo.Description);
        }
    }
}