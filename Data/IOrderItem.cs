/* 
 * Author: Sebastian Neal
 * Interface name: IOrderItem.cs
 * Purpose: Interface used to describe objects that can be ordered.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface for things that can be ordered.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// A getter for the price of the item.
        /// </summary>
        /// <returns>The price of the item. (Double)</returns>
        double Price { get; }

        /// <summary>
        /// A getter for the calories of the item.
        /// </summary>
        /// <returns>The calories in the item. (uint)</returns>
        uint Calories { get; }

        /// <summary>
        /// A getter for the list of special instructions for the item.
        /// </summary>
        /// <returns>The special instructions for the item. (List<string>)</returns>
        List<string> SpecialInstructions { get; }
    }
}
