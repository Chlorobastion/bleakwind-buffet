/*
 * Author: Sebastian Neal
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the drink 'Warrior Water'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the warrior water as described.
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// Whether ice is desired (default true).
        /// </summary>
        private bool ice = true;
        /// <summary>
        /// Whether lemon is desired (default false).
        /// </summary>
        private bool lemon = false;
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
        /// Basic getter/setter for the lemon variable.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }
        
        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public double Price
        {
            get { return 0.00; }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public uint Calories
        {
            get { return 0; }
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
                if (!ice)
                { specialInstructions.Add("Hold ice"); }
                if (lemon)
                { specialInstructions.Add("Add lemon"); }

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
            sb.Append("Warrior Water");

            return sb.ToString();
        }
    }
}
