/*
 * Author: Sebastian Neal
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the entree 'Thalmor Triple'
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the thalmor triple as described.
    /// </summary>
    public class ThalmorTriple : Entree, INotifyPropertyChanged
    {
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
        /// <value>
        /// Whether tomatoes are desired (default true).
        /// </value>
        private bool tomato = true;
        /// <value>
        /// Whether lettuce is desired (default true).
        /// </value>
        private bool lettuce = true;
        /// <value>
        /// Whether mayo is desired (default true).
        /// </value>
        private bool mayo = true;
        /// <value>
        /// Whether bacon is desired (default true).
        /// </value>
        private bool bacon = true;
        /// <value>
        /// Whether egg is desired (default true).
        /// </value>
        private bool egg = true;

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
            }
        }

        /// <summary>
        /// Basic getter/setter for the tomato variable.
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set 
            { 
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the lettuce variable.
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set 
            { 
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the mayo variable.
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set 
            { 
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the bacon variable.
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set 
            { 
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the egg variable.
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set 
            { 
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
            }
        }

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public override double Price
        {
            get { return 8.32; }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public override uint Calories
        {
            get { return 943; }
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
                if (!tomato)
                { specialInstructions.Add("Hold tomato"); }
                if (!lettuce)
                { specialInstructions.Add("Hold lettuce"); }
                if (!mayo)
                { specialInstructions.Add("Hold mayo"); }
                if (!bacon)
                { specialInstructions.Add("Hold bacon"); }
                if (!egg)
                { specialInstructions.Add("Hold egg"); }

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to give the name of the entree.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
