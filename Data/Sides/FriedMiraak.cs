/*
 * Author: Sebastian Neal
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the side 'Fried Miraak'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to represent the fried miraak as described.
    /// </summary>
    public class FriedMiraak
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
                { return 1.78; }
                else if (size.Equals(Size.Medium))
                { return 2.01; }
                else
                { return 2.88; }
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
                { return 151; }
                else if (size.Equals(Size.Medium))
                { return 236; }
                else
                { return 306; }
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
            sb.Append("Fried Miraak");

            return sb.ToString();
        }
    }
}
