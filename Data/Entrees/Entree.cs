/*
 * Author: Sebastian Neal
 * Interface name: Entree.cs
 * Purpose: Base abstract class for entrees.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// An abstract class to represent the basic aspects of entrees.
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// A getter for the name of the entree. (String)
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// A getter for the description of the entree.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// A getter for the price of the entree. (Double)
        /// </summary>
        /// <value>In US dollars.</value>
        public abstract double Price { get; }

        /// <summary>
        /// A getter for the calories in the entree. (uint)
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// A getter for the entree special instructions. (List<string>)
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
