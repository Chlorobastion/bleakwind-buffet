/*
 * Author: Sebastian Neal
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the entree 'Garden Orc Omelette'
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the garden orc omelette as described.
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Whether broccoli is desired (default true).
        /// </summary>
        private bool broccoli = true;
        /// <summary>
        /// Whether mushrooms are desired (default true).
        /// </summary>
        private bool mushrooms = true;
        /// <summary>
        /// Whether tomato is desired (default true).
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Whether cheddar is desired (default true).
        /// </summary>
        private bool cheddar = true;

        /// <summary>
        /// Basic getter/setter for the broccoli variable.
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }

        /// <summary>
        /// Basic getter/setter for the mushrooms variable.
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
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
        /// Basic getter/setter for the cheddar variable.
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public double Price
        {
            get { return 4.57; }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public uint Calories
        {
            get { return 404; }
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
                if (!broccoli)
                { specialInstructions.Add("Hold broccoli"); }
                if (!mushrooms)
                { specialInstructions.Add("Hold mushrooms"); }
                if (!tomato)
                { specialInstructions.Add("Hold tomato"); }
                if (!cheddar)
                { specialInstructions.Add("Hold cheddar"); }

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to give the name of the entree.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
