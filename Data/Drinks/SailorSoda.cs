/*
 * Author: Sebastian Neal
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the drink 'Sailor Soda'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the sailor soda as described.
    /// </summary>
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Getter for name of item.
        /// </summary>
        public override string Name
        {
            get
            {
                return ToString();
            }
        }

        /// <value>
        /// Whether ice is desired (default true).
        /// </value>
        private bool ice = true;
        /// <value>
        /// Which size drink is desired (default small).
        /// </value>
        private Size size = Size.Small;
        /// <value>
        /// Which drink flavor is desired (default cherry).
        /// </value>
        private SodaFlavor flavor = SodaFlavor.Cherry;

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
        /// Basic getter/setter for the flavor variable.
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));

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
                { return 1.42; }
                else if (Size.Equals(Size.Medium))
                { return 1.74; }
                else
                { return 2.07; }
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
                { return 117; }
                else if (Size.Equals(Size.Medium))
                { return 153; }
                else
                { return 205; }
            }
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
                if (!ice)
                { specialInstructions.Add("Hold ice"); }

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
            sb.Append(flavor.ToString());
            sb.Append(" ");
            sb.Append("Sailor Soda");

            return sb.ToString();
        }
    }
}
