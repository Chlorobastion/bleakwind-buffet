/*
 * Author: Sebastian Neal
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the entree 'Briarheart Burger'
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the briarheart burger as described.
    /// </summary>
    public class BriarheartBurger : Entree, INotifyPropertyChanged
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
        /// Whether a bun is desired (default true).
        /// </value>
        private bool bun = true;
        /// <value>
        /// Whether ketchup is desired (default true).
        /// </value>
        private bool ketchup = true;
        /// <value>
        /// Whether mustard is desired (default true).
        /// </value>
        private bool mustard = true;
        /// <value>
        /// Whether pickles are desired (default true).
        /// </value>
        private bool pickle = true;
        /// <value>
        /// Whether cheese is desired (default true).
        /// </value>
        private bool cheese = true;

        /// <summary>
        /// Event triggered when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Basic getter/setter for the bun variable.
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set 
            { 
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the ketchup variable.
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            { 
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the mustard variable.
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the pickle variable.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the cheese variable.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public override double Price
        {
            get { return 6.32; }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public override uint Calories
        {
            get { return 743; }
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

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to give the name of the entree.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
