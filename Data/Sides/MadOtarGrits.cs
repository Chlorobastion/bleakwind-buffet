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
    public class MadOtarGrits
    {
        /// <summary>
        /// Which size side is desired (default small).
        /// </summary>
        private Size size = Size.Small;

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
                { return 1.22; }
                else if (size.Equals(Size.Medium))
                { return 1.58; }
                else
                { return 1.93; }
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
                { return 105; }
                else if (size.Equals(Size.Medium))
                { return 142; }
                else
                { return 179; }
            }
        }

        /// <summary>
        /// Getter for special instructions on order (sides will
        /// always return an empty list).
        /// </summary>
        public List<string> SpecialInstructions
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
            sb.Append(size.ToString());
            sb.Append(" ");
            sb.Append("Mad Otar Grits");

            return sb.ToString();
        }
    }
}
