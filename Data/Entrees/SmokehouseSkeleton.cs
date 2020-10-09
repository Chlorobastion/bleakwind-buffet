/*
 * Author: Sebastian Neal
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the entree 'Smokehouse Skeleton'
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the smokehouse skeleton as described.
    /// </summary>
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
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
        /// Event triggered when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Basic getter/setter for the sausageLink variable.
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set 
            { 
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the hashBrowns variable.
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set 
            { 
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the pancake variable.
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set 
            { 
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public override double Price
        {
            get { return 5.62; }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public override uint Calories
        {
            get { return 602; }
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
