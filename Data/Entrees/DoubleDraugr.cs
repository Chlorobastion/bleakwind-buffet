/*
 * Author: Sebastian Neal
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the entree 'Double Draugr'
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the double draugr as described.
    /// </summary>
    public class DoubleDraugr
    {
        /// <summary>
        /// Whether a bun is desired (default true).
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Whether ketchup is desired (default true).
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Whether mustard is desired (default true).
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Whether pickles are desired (default true).
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Whether cheese is desired (default true).
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// Whether tomatoes are desired (default true).
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Whether lettuce is desired (default true).
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Whether mayo is desired (default true).
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Basic getter/setter for the bun variable.
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// Basic getter/setter for the ketchup variable.
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// Basic getter/setter for the mustard variable.
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// Basic getter/setter for the pickle variable.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Basic getter/setter for the cheese variable.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// Basic getter/setter for the tomato variable.
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// Basic getter/setter for the lettuce variable.
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <summary>
        /// Basic getter/setter for the mayo variable.
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public double Price
        {
            get { return 7.32; }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public uint Calories
        {
            get { return 843; }
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
                if (!bun)
                { specialInstructions.Add("Hold bun"); }
                if (!ketchup)
                { specialInstructions.Add("Hold ketchup"); }
                if (!mustard)
                { specialInstructions.Add("Hold mustard"); }
                if (!pickle)
                { specialInstructions.Add("Hold pickle"); }
                if (!cheese)
                { specialInstructions.Add("Hold cheese"); }
                if (!tomato)
                { specialInstructions.Add("Hold tomato"); }
                if (!lettuce)
                { specialInstructions.Add("Hold lettuce"); }
                if (!mayo)
                { specialInstructions.Add("Hold mayo"); }

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to give the name of the entree.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
