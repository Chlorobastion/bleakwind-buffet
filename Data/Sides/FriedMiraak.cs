/*
 * Author: Sebastian Neal
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the side 'Fried Miraak'
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to represent the fried miraak as described.
    /// </summary>
    public class FriedMiraak : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Event triggered when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
        /// Which size side is desired (default small).
        /// </value>
        private Size size = Size.Small;

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
                { return 1.78; }
                else if (Size.Equals(Size.Medium))
                { return 2.01; }
                else
                { return 2.88; }
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
                { return 151; }
                else if (Size.Equals(Size.Medium))
                { return 236; }
                else
                { return 306; }
            }
        }

        /// <summary>
        /// Getter for special instructions on order (sides will
        /// always return an empty list).
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to give the name of the side.
        /// </summary>
        /// <returns>The name of the side.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size.ToString());
            sb.Append(" ");
            sb.Append("Fried Miraak");

            return sb.ToString();
        }
    }
}
