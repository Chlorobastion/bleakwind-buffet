/*
 * Author: Sebastian Neal
 * Class name: Combo.cs
 * Purpose: Class used to represent the combination of drink, side, and entree
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class used to represent the combo order as described.
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event triggered when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variable for the entree in this combo.
        /// </summary>
        private Entree entree = null;

        /// <summary>
        /// Public getter setter for the entree field.
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if (entree != value)
                {
                    if (entree != null)
                    {
                        if (entree is BriarheartBurger)
                        {
                            ((BriarheartBurger)entree).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (entree is DoubleDraugr)
                        {
                            ((DoubleDraugr)entree).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (entree is GardenOrcOmelette)
                        {
                            ((GardenOrcOmelette)entree).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (entree is PhillyPoacher)
                        {
                            ((PhillyPoacher)entree).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (entree is SmokehouseSkeleton)
                        {
                            ((SmokehouseSkeleton)entree).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (entree is ThalmorTriple)
                        {
                            ((ThalmorTriple)entree).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (entree is ThugsTBone)
                        {
                            ((ThugsTBone)entree).PropertyChanged -= ItemPropertyChangedListener;
                        }
                    }
                    entree = value;
                    if (entree is BriarheartBurger)
                    {
                        ((BriarheartBurger)entree).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (entree is DoubleDraugr)
                    {
                        ((DoubleDraugr)entree).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (entree is GardenOrcOmelette)
                    {
                        ((GardenOrcOmelette)entree).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (entree is PhillyPoacher)
                    {
                        ((PhillyPoacher)entree).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (entree is SmokehouseSkeleton)
                    {
                        ((SmokehouseSkeleton)entree).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (entree is ThalmorTriple)
                    {
                        ((ThalmorTriple)entree).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (entree is ThugsTBone)
                    {
                        ((ThugsTBone)entree).PropertyChanged += ItemPropertyChangedListener;
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for the side in this combo.
        /// </summary>
        private Side side = null;

        /// <summary>
        /// Public getter setter for the entree field.
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != value)
                {
                    if (side != null)
                    {
                        if (side is DragonbornWaffleFries)
                        {
                            ((DragonbornWaffleFries)side).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (side is FriedMiraak)
                        {
                            ((FriedMiraak)side).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (side is MadOtarGrits)
                        {
                            ((MadOtarGrits)side).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (side is VokunSalad)
                        {
                            ((VokunSalad)side).PropertyChanged -= ItemPropertyChangedListener;
                        }
                    }
                    side = value;
                    if (side is DragonbornWaffleFries)
                    {
                        ((DragonbornWaffleFries)side).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (side is FriedMiraak)
                    {
                        ((FriedMiraak)side).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (side is MadOtarGrits)
                    {
                        ((MadOtarGrits)side).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if(side is VokunSalad)
                    {
                        ((VokunSalad)side).PropertyChanged += ItemPropertyChangedListener;
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for the drink in this combo.
        /// </summary>
        private Drink drink = null;

        /// <summary>
        /// Public getter setter for the entree field.
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != value)
                {
                    if (drink != null)
                    {
                        if (drink is AretinoAppleJuice)
                        {
                            ((AretinoAppleJuice)drink).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if(drink is CandlehearthCoffee)
                        {
                            ((CandlehearthCoffee)drink).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (drink is MarkarthMilk)
                        {
                            ((MarkarthMilk)drink).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (drink is SailorSoda)
                        {
                            ((SailorSoda)drink).PropertyChanged -= ItemPropertyChangedListener;
                        }
                        else if (drink is WarriorWater)
                        {
                            ((WarriorWater)drink).PropertyChanged -= ItemPropertyChangedListener;
                        }
                    }
                    drink = value;
                    if (drink is AretinoAppleJuice)
                    {
                        ((AretinoAppleJuice)drink).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (drink is CandlehearthCoffee)
                    {
                        ((CandlehearthCoffee)drink).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (drink is MarkarthMilk)
                    {
                        ((MarkarthMilk)drink).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (drink is SailorSoda)
                    {
                        ((SailorSoda)drink).PropertyChanged += ItemPropertyChangedListener;
                    }
                    else if (drink is WarriorWater)
                    {
                        ((WarriorWater)drink).PropertyChanged += ItemPropertyChangedListener;
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Total price of the combo order (all seperate prices combined minus one dollar).
        /// </summary>
        public double Price
        {
            get
            {
                double ePrice = 0;
                double sPrice = 0;
                double dPrice = 0;
                if (entree != null)
                {
                    ePrice = entree.Price;
                }
                if (side != null)
                {
                    sPrice = side.Price;
                }
                if (drink != null)
                {
                    dPrice = drink.Price;
                }
                return ePrice + sPrice + dPrice - 1.00;
            }
        }

        /// <summary>
        /// Total calories in the combo order (all seperate calories combined).
        /// </summary>
        public uint Calories
        {
            get 
            {
                uint eCal = 0;
                uint sCal = 0;
                uint dCal = 0;
                if (entree != null)
                {
                    eCal = entree.Calories;
                }
                if (side != null)
                {
                    sCal = side.Calories;
                }
                if (drink != null)
                {
                    dCal = drink.Calories;
                }
                return eCal + sCal + dCal;
            }
        }

        /// <summary>
        /// Displays the name of each part of the combo and the special instructions for each.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get 
            {
                List<string> comboInstructions = new List<string>();
                comboInstructions.Add(entree.ToString());
                if (entree.SpecialInstructions != null)
                {
                    foreach (string instruction in entree.SpecialInstructions)
                    {
                        comboInstructions.Add(instruction);
                    }
                }
                comboInstructions.Add(side.ToString());
                if (side.SpecialInstructions != null)
                {
                    foreach (string instruction in side.SpecialInstructions)
                    {
                        comboInstructions.Add(instruction);
                    }
                }
                comboInstructions.Add(drink.ToString());
                if (drink.SpecialInstructions != null)
                {
                    foreach (string instruction in drink.SpecialInstructions)
                    {
                        comboInstructions.Add(instruction);
                    }
                }
                return comboInstructions;
            }
        }

        /// <summary>
        /// Event listener for each of the attached objects to the combo (if something
        /// changes in the object, they should notify the combo object that it too needs
        /// to change).
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Information about the event raised.</param>
        void ItemPropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Price":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    break;
                case "Calories":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    break;
                case "SpecialInstructions":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    break;
            }
        }
    }
}
