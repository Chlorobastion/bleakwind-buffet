/*
 * Author: Sebastian Neal
 * Interface name: Drink.cs
 * Purpose: Base abstract class for drinks.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// An abstract class to represent the basic aspects of drinks.
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// A getter/setter for the size of the drink. (Size)
        /// </summary>
        /// <value>Small, Medium, or Large.</value>
        public virtual Size Size { get; set; }

        /// <summary>
        /// A getter for the price of the drink. (Double)
        /// </summary>
        /// <value>In US dollars.</value>
        public abstract double Price { get; }

        /// <summary>
        /// A getter for the calories in the drink. (uint)
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// A getter for the drink special instructions. (List<string>)
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
