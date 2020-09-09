/*
 * Author: Sebastian Neal
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the side 'Dragonborn Waffle Fries'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to represent the dragonborn waffle fries as described.
    /// </summary>
    public class DragonbornWaffleFries : Side
    {
        /// <value>
        /// Which size side is desired (default small).
        /// </value>
        private Size size = Size.Small;

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size.Equals(Size.Small))
                { return 0.42; }
                else if (Size.Equals(Size.Medium))
                { return 0.76; }
                else
                { return 0.96; }
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
                { return 77; }
                else if (Size.Equals(Size.Medium))
                { return 89; }
                else
                { return 100; }
            }
        }

        /// <summary>
        /// Getter for special instructions on order (sides will
        /// always return an empty list).
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to give the name of the side.
        /// </summary>
        /// <returns>The name of the side.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size.ToString());
            sb.Append(" ");
            sb.Append("Dragonborn Waffle Fries");

            return sb.ToString();
        }
    }
}
