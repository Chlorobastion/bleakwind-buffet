﻿/*
 * Author: Sebastian Neal
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the entree 'Smokehouse Skeleton'
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the smokehouse skeleton as described.
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <value>
        /// Whether a sausage is desired (default true).
        /// </value>
        private bool sausageLink = true;
        /// <value>
        /// Whether eggs are desired (default true).
        /// </value>
        private bool egg = true;
        /// <value>
        /// Whether hash browns are desired (default true).
        /// </value>
        private bool hashBrowns = true;
        /// <value>
        /// Whether pancakes are desired (default true).
        /// </value>
        private bool pancake = true;
        
        /// <summary>
        /// Basic getter/setter for the sausageLink variable.
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }

        /// <summary>
        /// Basic getter/setter for the egg variable.
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// Basic getter/setter for the hashBrowns variable.
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns = value; }
        }

        /// <summary>
        /// Basic getter/setter for the pancake variable.
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public double Price
        {
            get { return 5.62; }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public uint Calories
        {
            get { return 602; }
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
                if (!sausageLink)
                { specialInstructions.Add("Hold sausage"); }
                if (!egg)
                { specialInstructions.Add("Hold eggs"); }
                if (!hashBrowns)
                { specialInstructions.Add("Hold hash browns"); }
                if (!pancake)
                { specialInstructions.Add("Hold pancakes"); }

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to give the name of the entree.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
