/*
 * Author: Sebastian Neal
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the drink 'Candlehearth Coffee'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the candlehearth coffee as described.
    /// </summary>
    public class CandlehearthCoffee
    {
        /// <value>
        /// Whether ice is desired (default false).
        /// </value>
        private bool ice = false;
        /// <value>
        /// Whether decaf is desired (default false).
        /// </value>
        private bool decaf = false;
        /// <value>
        /// Whether room for cream is desired (default false).
        /// </value>
        private bool roomForCream = false;
        /// <value>
        /// Which size drink is desired (default small).
        /// </value>
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
        /// Basic getter/setter for the decaf variable.
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// Basic getter/setter for the roomForCream variable.
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
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
                { return 0.75; }
                else if (size.Equals(Size.Medium))
                { return 1.25; }
                else
                { return 1.75; }
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
                { return 7; }
                else if (size.Equals(Size.Medium))
                { return 10; }
                else
                { return 20; }
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
                if (roomForCream)
                { specialInstructions.Add("Add cream"); }

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
            if (decaf)
            { sb.Append("Decaf "); }
            sb.Append("Candlehearth Coffee");

            return sb.ToString();
        }
    }
}
