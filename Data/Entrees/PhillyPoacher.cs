/*
 * Author: Sebastian Neal
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the entree 'Philly Poacher'
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the philly poacher as described.
    /// </summary>
    public class PhillyPoacher : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Getter for name of item.
        /// </summary>
        public string Name
        {
            get
            {
                return ToString();
            }
        }

        /// <value>
        /// Whether sirloin is desired (default true).
        /// </value>
        private bool sirloin = true;
        /// <value>
        /// Whether onions are desired (default true).
        /// </value>
        private bool onion = true;
        /// <value>
        /// Whether rolls are desired (default true).
        /// </value>
        private bool roll = true;

        /// <summary>
        /// Event triggered when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Basic getter/setter for the sirloin variable.
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set 
            { 
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the onion variable.
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set 
            { 
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the roll variable.
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set 
            { 
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public override double Price
        {
            get { return 7.23; }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public override uint Calories
        {
            get { return 784; }
        }

        /// <summary>
        /// Getter for special instructions on order (if a part of the order
        /// is not desired, and is set to false, the special instructions
        /// says what needs held off; if everything is desired, this getter
        /// returns an empty list).
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!sirloin)
                { specialInstructions.Add("Hold sirloin"); }
                if (!onion)
                { specialInstructions.Add("Hold onions"); }
                if (!roll)
                { specialInstructions.Add("Hold roll"); }

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to give the name of the entree.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
