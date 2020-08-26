﻿/*
 * Author: Sebastian Neal
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the drink 'Aretino Apple Juice'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the aretino apple juice as described.
    /// </summary>
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Whether ice is desired (default false).
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// Which size drink is desired (default small).
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Basic getter/setter for the ice variable.
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Basic getter/setter for the size variable.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public double Price
        {
            get
            {
                if (size.Equals(Size.Small))
                { return 0.62; }
                else if (size.Equals(Size.Medium))
                { return 0.87; }
                else
                { return 1.01; }
            }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size.Equals(Size.Small))
                { return 44; }
                else if (size.Equals(Size.Medium))
                { return 88; }
                else
                { return 132; }
            }
        }

        /// <summary>
        /// Getter for special instructions on order (if a part of the order
        /// is desired, and is set to true, the special instructions
        /// says what needs added; if nothing is desired, this getter
        /// returns an empty list).
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (ice)
                { specialInstructions.Add("Add ice"); }

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to give the name of the drink.
        /// </summary>
        /// <returns>The name of the drink.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(size.ToString());
            sb.Append(" ");
            sb.Append("Aretino Apple Juice");

            return sb.ToString();
        }
    }
}
