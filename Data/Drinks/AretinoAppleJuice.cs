/*
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
    public class AretinoAppleJuice : Drink
    {
        /// <value>
        /// Whether ice is desired (default false).
        /// </value>
        private bool ice = false;
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
        /// Basic getter for the price.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size.Equals(Size.Small))
                { return 0.62; }
                else if (Size.Equals(Size.Medium))
                { return 0.87; }
                else
                { return 1.01; }
            }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size.Equals(Size.Small))
                { return 44; }
                else if (Size.Equals(Size.Medium))
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
        public override List<string> SpecialInstructions
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
            sb.Append(Size.ToString());
            sb.Append(" ");
            sb.Append("Aretino Apple Juice");

            return sb.ToString();
        }
    }
}
