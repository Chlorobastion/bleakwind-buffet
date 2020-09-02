/*
 * Author: Sebastian Neal
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the drink 'Sailor Soda'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the sailor soda as described.
    /// </summary>
    public class SailorSoda
    {
        /// <value>
        /// Whether ice is desired (default true).
        /// </value>
        private bool ice = true;
        /// <value>
        /// Which size drink is desired (default small).
        /// </value>
        private Size size = Size.Small;
        /// <value>
        /// Which drink flavor is desired (default cherry).
        /// </value>
        private SodaFlavor flavor = SodaFlavor.Cherry;

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
        /// Basic getter/setter for the flavor variable.
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public double Price
        {
            get
            {
                if (size.Equals(Size.Small))
                { return 1.42; }
                else if (size.Equals(Size.Medium))
                { return 1.74; }
                else
                { return 2.07; }
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
                { return 117; }
                else if (size.Equals(Size.Medium))
                { return 153; }
                else
                { return 205; }
            }
        }

        /// <summary>
        /// Getter for special instructions on order (if a part of the order
        /// is not desired, and is set to false, the special instructions
        /// says what needs held off; if everything is desired, this getter
        /// returns an empty list).
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!ice)
                { specialInstructions.Add("Hold ice"); }

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
            sb.Append(flavor.ToString());
            sb.Append(" ");
            sb.Append("Sailor Soda");

            return sb.ToString();
        }
    }
}
