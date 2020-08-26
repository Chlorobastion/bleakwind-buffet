/*
 * Author: Sebastian Neal
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the entree 'Thugs T-Bone'
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the thugs t-bone as described.
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public double Price
        {
            get { return 6.44; }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public uint Calories
        {
            get { return 982; }
        }

        /// <summary>
        /// Getter for special instructions on order (always returns an
        /// empty list for this class).
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
        /// Overrides the ToString method to give the name of the entree.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
