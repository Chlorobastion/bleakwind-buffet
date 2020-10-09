/*
 * Author: Sebastian Neal
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the drink 'Markarth Milk'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the markarth milk as described.
    /// </summary>
    public class MarkarthMilk : Drink, INotifyPropertyChanged
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
        /// Whether ice is desired (default false).
        /// </value>
        private bool ice = false;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// Basic getter for the price.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size.Equals(Size.Small))
                { return 1.05; }
                else if (Size.Equals(Size.Medium))
                { return 1.11; }
                else
                { return 1.22; }
            }
        }

        /// <summary>
        /// Basic getter for the number of calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size.Equals(Size.Small))
                { return 56; }
                else if (Size.Equals(Size.Medium))
                { return 72; }
                else
                { return 93; }
            }
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
                if (ice)
                { specialInstructions.Add("Add ice"); }

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
            sb.Append("Markarth Milk");

            return sb.ToString();
        }
    }
}
