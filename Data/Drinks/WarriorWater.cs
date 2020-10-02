/*
 * Author: Sebastian Neal
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the drink 'Warrior Water'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the warrior water as described.
    /// </summary>
    public class WarriorWater : Drink, INotifyPropertyChanged
    {
        /// <value>
        /// Whether ice is desired (default true).
        /// </value>
        private bool ice = true;
        /// <value>
        /// Whether lemon is desired (default false).
        /// </value>
        private bool lemon = false;
        /// <value>
        /// Which size drink is desired (default small).
        /// </value>
        private Size size = Size.Small;

        /// <summary>
        /// Event triggered when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Ice property getter/setter
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        /// <summary>
        /// Size property getter/setter
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <summary>
        /// Basic getter/setter for the lemon variable.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set 
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
            }
        }
        
        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public override double Price
        {
            get { return 0.00; }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public override uint Calories
        {
            get { return 0; }
        }

        /// <summary>
        /// Getter for special instructions on order (if a part of the order
        /// is desired, and is set to true, the special instructions
        /// says what needs added; if nothing is desired, this getter
        /// returns an empty list).
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!ice)
                { specialInstructions.Add("Hold ice"); }
                if (lemon)
                { specialInstructions.Add("Add lemon"); }

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
            sb.Append(Size.ToString());
            sb.Append(" ");
            sb.Append("Warrior Water");

            return sb.ToString();
        }
    }
}
