/*
 * Author: Sebastian Neal
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the side 'Mad Otar Grits'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to represent the mad otar grits as described.
    /// </summary>
    public class MadOtarGrits : Side
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
                { return 1.22; }
                else if (Size.Equals(Size.Medium))
                { return 1.58; }
                else
                { return 1.93; }
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
                { return 105; }
                else if (Size.Equals(Size.Medium))
                { return 142; }
                else
                { return 179; }
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
            sb.Append("Mad Otar Grits");

            return sb.ToString();
        }
    }
}
