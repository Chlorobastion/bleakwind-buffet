/*
 * Author: Sebastian Neal
 * Interface name: Order.cs
 * Purpose: Class used to represent the total Order.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class used to represent the total Order.
    /// </summary>
    public class Order : ObservableCollection<IOrderItem>
    {
        /// <summary>
        /// Static field to ensure uniqueness in order number.
        /// </summary>
        private static uint nextOrderNumber = 1;

        /// <summary>
        /// Constructor for the order.
        /// </summary>
        public Order()
        {
            CollectionChanged += CollectionChangedListener;
            number = nextOrderNumber;
            nextOrderNumber++;
        }

        /// <summary>
        /// Event listener for the list changing.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Information about the event raised.</param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        if (item is Combo)
                        {
                            ((Combo)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is AretinoAppleJuice)
                        {
                            ((AretinoAppleJuice)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is CandlehearthCoffee)
                        {
                            ((CandlehearthCoffee)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is MarkarthMilk)
                        {
                            ((MarkarthMilk)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is SailorSoda)
                        {
                            ((SailorSoda)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is WarriorWater)
                        {
                            ((WarriorWater)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is BriarheartBurger)
                        {
                            ((BriarheartBurger)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is DoubleDraugr)
                        {
                            ((DoubleDraugr)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is GardenOrcOmelette)
                        {
                            ((GardenOrcOmelette)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is PhillyPoacher)
                        {
                            ((PhillyPoacher)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is SmokehouseSkeleton)
                        {
                            ((SmokehouseSkeleton)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is ThalmorTriple)
                        {
                            ((ThalmorTriple)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is ThugsTBone)
                        {
                            ((ThugsTBone)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is DragonbornWaffleFries)
                        {
                            ((DragonbornWaffleFries)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is FriedMiraak)
                        {
                            ((FriedMiraak)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is MadOtarGrits)
                        {
                            ((MadOtarGrits)item).PropertyChanged += CollectionItemChangedListener;
                        }
                        else if (item is VokunSalad)
                        {
                            ((VokunSalad)item).PropertyChanged += CollectionItemChangedListener;
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        if (item is Combo)
                        {
                            ((Combo)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is AretinoAppleJuice)
                        {
                            ((AretinoAppleJuice)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is CandlehearthCoffee)
                        {
                            ((CandlehearthCoffee)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is MarkarthMilk)
                        {
                            ((MarkarthMilk)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is SailorSoda)
                        {
                            ((SailorSoda)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is WarriorWater)
                        {
                            ((WarriorWater)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is BriarheartBurger)
                        {
                            ((BriarheartBurger)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is DoubleDraugr)
                        {
                            ((DoubleDraugr)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is GardenOrcOmelette)
                        {
                            ((GardenOrcOmelette)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is PhillyPoacher)
                        {
                            ((PhillyPoacher)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is SmokehouseSkeleton)
                        {
                            ((SmokehouseSkeleton)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is ThalmorTriple)
                        {
                            ((ThalmorTriple)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is ThugsTBone)
                        {
                            ((ThugsTBone)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is DragonbornWaffleFries)
                        {
                            ((DragonbornWaffleFries)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is FriedMiraak)
                        {
                            ((FriedMiraak)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is MadOtarGrits)
                        {
                            ((MadOtarGrits)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                        else if (item is VokunSalad)
                        {
                            ((VokunSalad)item).PropertyChanged -= CollectionItemChangedListener;
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported.");
            }
        }

        /// <summary>
        /// Event listener for items on the list changing.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Information about the event raised.</param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Price":
                    OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    break;
                case "Calories":
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
            }
        }

        /// <summary>
        /// Private backing variable for tax.
        /// </summary>
        private double salesTaxRate = 0.12;

        /// <summary>
        /// Getter/Setter for sales tax variable.
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            set
            {
                salesTaxRate = value;
            }
        }

        /// <summary>
        /// Private backing variable for subtotal.
        /// </summary>
        private double subtotal;

        /// <summary>
        /// Getter for subtotal variable.
        /// </summary>
        public double Subtotal
        {
            get
            {
                subtotal = 0;
                foreach (IOrderItem item in this)
                {
                    subtotal += item.Price;
                }
                subtotal = Math.Round(subtotal, 2);
                return subtotal;
            }
        }

        /// <summary>
        /// Private backing variable for tax.
        /// </summary>
        private double tax;

        /// <summary>
        /// Getter for tax variable.
        /// </summary>
        public double Tax
        {
            get
            {
                tax = Subtotal * salesTaxRate;
                tax = Math.Round(tax, 2);
                return tax;
            }
        }

        /// <summary>
        /// Private backing variable for total.
        /// </summary>
        private double total;

        /// <summary>
        /// Getter for total variable.
        /// </summary>
        public double Total
        {
            get
            {
                total = Subtotal + Tax;
                total = Math.Round(total, 2);
                return total;
            }
        }

        /// <summary>
        /// Private backing variable for calories.
        /// </summary>
        private uint calories;

        /// <summary>
        /// Getter for calories variable.
        /// </summary>
        public uint Calories
        {
            get
            {
                calories = 0;
                foreach (IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        /// <summary>
        /// Private backing variable for order number.
        /// </summary>
        private uint number;

        /// <summary>
        /// Getter for the order number variable.
        /// </summary>
        public uint Number
        {
            get
            {
                return number;
            }
        }
    }
}
