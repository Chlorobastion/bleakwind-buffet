/*
 * Author: Sebastian Neal
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 * 
 * Note: Not all of my tests are extensive. I believe that most of them should be, but not all have to be.
 * To that end, things like events being triggered for adding drink/side/entree are over all possible
 * drinks/sides/entrees, but testing price/calorie/instruction combos will get involved and require much
 * more coding. As such, I simply used examples that should represent the proper cases in those tests.
 */

using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Tests for the Combo class.
    /// </summary>
    public class ComboTests
    {
        /// <summary>
        /// Tests if Combo implements the IOrderItem Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Combo co = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(co);
        }

        /// <summary>
        /// Tests if Combo implements INotifyPropertyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Combo co = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(co);
        }

        /// <summary>
        /// Tests if Combo triggers PropertyChangeed events when a drink is added
        /// </summary>
        [Fact]
        public void ShouldTriggerPropertyChangedEventForAddingDrink()
        {
            Combo co = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            MarkarthMilk mm = new MarkarthMilk();
            SailorSoda ss = new SailorSoda();
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(co, "Drink", () => co.Drink = aj);
            Assert.PropertyChanged(co, "Drink", () => co.Drink = cc);
            Assert.PropertyChanged(co, "Drink", () => co.Drink = mm);
            Assert.PropertyChanged(co, "Drink", () => co.Drink = ss);
            Assert.PropertyChanged(co, "Drink", () => co.Drink = ww);
            Assert.PropertyChanged(co, "Price", () => co.Drink = aj);
            Assert.PropertyChanged(co, "Price", () => co.Drink = cc);
            Assert.PropertyChanged(co, "Price", () => co.Drink = mm);
            Assert.PropertyChanged(co, "Price", () => co.Drink = ss);
            Assert.PropertyChanged(co, "Price", () => co.Drink = ww);
            Assert.PropertyChanged(co, "Calories", () => co.Drink = aj);
            Assert.PropertyChanged(co, "Calories", () => co.Drink = cc);
            Assert.PropertyChanged(co, "Calories", () => co.Drink = mm);
            Assert.PropertyChanged(co, "Calories", () => co.Drink = ss);
            Assert.PropertyChanged(co, "Calories", () => co.Drink = ww);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Drink = aj);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Drink = cc);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Drink = mm);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Drink = ss);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Drink = ww);
        }

        /// <summary>
        /// Tests if Combo triggers PropertyChangeed events when a side is added
        /// </summary>
        [Fact]
        public void ShouldTriggerPropertyChangedEventForAddingSide()
        {
            Combo co = new Combo();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            FriedMiraak fm = new FriedMiraak();
            MadOtarGrits mog = new MadOtarGrits();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(co, "Side", () => co.Side = dwf);
            Assert.PropertyChanged(co, "Side", () => co.Side = fm);
            Assert.PropertyChanged(co, "Side", () => co.Side = mog);
            Assert.PropertyChanged(co, "Side", () => co.Side = vs);
            Assert.PropertyChanged(co, "Price", () => co.Side = dwf);
            Assert.PropertyChanged(co, "Price", () => co.Side = fm);
            Assert.PropertyChanged(co, "Price", () => co.Side = mog);
            Assert.PropertyChanged(co, "Price", () => co.Side = vs);
            Assert.PropertyChanged(co, "Calories", () => co.Side = dwf);
            Assert.PropertyChanged(co, "Calories", () => co.Side = fm);
            Assert.PropertyChanged(co, "Calories", () => co.Side = mog);
            Assert.PropertyChanged(co, "Calories", () => co.Side = vs);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Side = dwf);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Side = fm);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Side = mog);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Side = vs);
        }

        /// <summary>
        /// Tests if Combo triggers PropertyChangeed events when a entree is added
        /// </summary>
        [Fact]
        public void ShouldTriggerPropertyChangedEventForAddingEntree()
        {
            Combo co = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone ttb = new ThugsTBone();
            Assert.PropertyChanged(co, "Entree", () => co.Entree = bb);
            Assert.PropertyChanged(co, "Entree", () => co.Entree = dd);
            Assert.PropertyChanged(co, "Entree", () => co.Entree = goo);
            Assert.PropertyChanged(co, "Entree", () => co.Entree = pp);
            Assert.PropertyChanged(co, "Entree", () => co.Entree = ss);
            Assert.PropertyChanged(co, "Entree", () => co.Entree = tt);
            Assert.PropertyChanged(co, "Entree", () => co.Entree = ttb);
            Assert.PropertyChanged(co, "Price", () => co.Entree = bb);
            Assert.PropertyChanged(co, "Price", () => co.Entree = dd);
            Assert.PropertyChanged(co, "Price", () => co.Entree = goo);
            Assert.PropertyChanged(co, "Price", () => co.Entree = pp);
            Assert.PropertyChanged(co, "Price", () => co.Entree = ss);
            Assert.PropertyChanged(co, "Price", () => co.Entree = tt);
            Assert.PropertyChanged(co, "Price", () => co.Entree = ttb);
            Assert.PropertyChanged(co, "Calories", () => co.Entree = bb);
            Assert.PropertyChanged(co, "Calories", () => co.Entree = dd);
            Assert.PropertyChanged(co, "Calories", () => co.Entree = goo);
            Assert.PropertyChanged(co, "Calories", () => co.Entree = pp);
            Assert.PropertyChanged(co, "Calories", () => co.Entree = ss);
            Assert.PropertyChanged(co, "Calories", () => co.Entree = tt);
            Assert.PropertyChanged(co, "Calories", () => co.Entree = ttb);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Entree = bb);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Entree = dd);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Entree = goo);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Entree = pp);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Entree = ss);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Entree = tt);
            Assert.PropertyChanged(co, "SpecialInstructions", () => co.Entree = ttb);
        }

        /// <summary>
        /// Checks if changing an individual item price triggers combo price PropertyChanged event
        /// </summary>
        [Fact]
        public void ShouldTriggerPricePropertyChangeForChangingItemPrice()
        {
            Combo co = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            ThalmorTriple tt = new ThalmorTriple();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            co.Drink = aj;
            co.Entree = tt;
            co.Side = dwf;
            Assert.PropertyChanged(co, "Price", () => aj.Size = Size.Medium);
            Assert.PropertyChanged(co, "Price", () => dwf.Size = Size.Medium);
        }

        /// <summary>
        /// Checks if changing an individual item calories triggers combo calories PropertyChanged event
        /// </summary>
        [Fact]
        public void ShouldTriggerCaloriesPropertyChangeForChangingItemCalories()
        {
            Combo co = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            ThalmorTriple tt = new ThalmorTriple();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            co.Drink = aj;
            co.Entree = tt;
            co.Side = dwf;
            Assert.PropertyChanged(co, "Calories", () => aj.Size = Size.Medium);
            Assert.PropertyChanged(co, "Calories", () => dwf.Size = Size.Medium);
        }

        /// <summary>
        /// Checks if changing an individual item special instructions triggers combo special instructions PropertyChanged event
        /// </summary>
        [Fact]
        public void ShouldTriggerSpecialInstructionsPropertyChangeForChangingItemSpecialInstructions()
        {
            Combo co = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            ThalmorTriple tt = new ThalmorTriple();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            co.Drink = aj;
            co.Entree = tt;
            co.Side = dwf;
            Assert.PropertyChanged(co, "SpecialInstructions", () => aj.Ice = true);
            Assert.PropertyChanged(co, "SpecialInstructions", () => tt.Bun = false);
        }

        /// <summary>
        /// Checks if Combo returns proper price
        /// </summary>
        [Fact]
        public void ShouldGiveProperComboPrice()
        {
            Combo co = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            ThalmorTriple tt = new ThalmorTriple();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            co.Drink = aj;
            co.Entree = tt;
            co.Side = dwf;
            Assert.True(co.Price == (aj.Price + tt.Price + dwf.Price - 1.0));
        }

        /// <summary>
        /// Checks if Combo returns proper calorie count
        /// </summary>
        [Fact]
        public void ShouldGiveProperComboCalories()
        {
            Combo co = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            ThalmorTriple tt = new ThalmorTriple();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            co.Drink = aj;
            co.Entree = tt;
            co.Side = dwf;
            Assert.True(co.Calories == (aj.Calories + tt.Calories + dwf.Calories));
        }

        /// <summary>
        /// Checks if Combo returns proper special instructions
        /// </summary>
        [Fact]
        public void ShouldGiveProperComboCSpecialInstructions()
        {
            Combo co = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            ThalmorTriple tt = new ThalmorTriple();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            co.Drink = aj;
            co.Entree = tt;
            co.Side = dwf;
            aj.Ice = true;
            tt.Bun = false;
            tt.Ketchup = false;
            List<string> specialInstructions = new List<string>();
            specialInstructions.Add(tt.ToString());
            specialInstructions.Add("-" + tt.SpecialInstructions[0]);
            specialInstructions.Add("-" + tt.SpecialInstructions[1]);
            specialInstructions.Add(dwf.ToString());
            specialInstructions.Add(aj.ToString());
            specialInstructions.Add("-" + aj.SpecialInstructions[0]);
            Assert.True(co.SpecialInstructions[0] == specialInstructions[0]);
            Assert.True(co.SpecialInstructions[1] == specialInstructions[1]);
            Assert.True(co.SpecialInstructions[2] == specialInstructions[2]);
            Assert.True(co.SpecialInstructions[3] == specialInstructions[3]);
            Assert.True(co.SpecialInstructions[4] == specialInstructions[4]);
            Assert.True(co.SpecialInstructions[5] == specialInstructions[5]);
        }
    }
}
