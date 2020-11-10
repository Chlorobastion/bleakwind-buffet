/*
 * Author: Sebastian Neal
 * Interface name: Side.cs
 * Purpose: Base abstract class for sides.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{

    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// A getter for the name of the side. (String)
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// A getter for the description of the side.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// A getter/setter for the size of the side. (Size)
        /// </summary>
        /// <value>Small, Medium, or Large.</value>
        public virtual Size Size { get; set; }

        /// <summary>
        /// A getter for the price of the side. (Double)
        /// </summary>
        /// <value>In US dollars.</value>
        public abstract double Price { get; }

        /// <summary>
        /// A getter for the calories in the side. (uint)
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// A getter for the side special instructions. (List<string>)
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
