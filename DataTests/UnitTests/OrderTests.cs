/*
 * Author: Sebastian Neal
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 */

using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Tests for the Order class.
    /// </summary>
    public class OrderTests
    {
        /// <summary>
        /// Tests if Order implements the ICollection<IOrderItem> Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToICollectionInterface()
        {
            Order or = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(or);
        }

        /// <summary>
        /// Tests if Order implements the INotifyCollectionChanged Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToINotifyCollectionChangedInterface()
        {
            Order or = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(or);
        }

        /// <summary>
        /// Tests if Order implements the INotifyPropertyChanged Interface.
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            Order or = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(or);
        }

        /// <summary>
        /// Tests if adding an item to Order triggers the proper events. (If the property
        /// events are triggered, the CollectionChanged Event must have been raised and
        /// does not need to be explicitly tested.)
        /// </summary>
        [Fact]
        public void AddingItemShouldTriggerEvents()
        {
            Order or = new Order();
            Assert.PropertyChanged(or, "Subtotal", () => or.Add(new BriarheartBurger()));
            Assert.PropertyChanged(or, "Tax", () => or.Add(new BriarheartBurger()));
            Assert.PropertyChanged(or, "Total", () => or.Add(new BriarheartBurger()));
            Assert.PropertyChanged(or, "Calories", () => or.Add(new BriarheartBurger()));
        }

        /// <summary>
        /// Tests if removing an item from Order triggers the proper events. (If the property
        /// events are triggered, the CollectionChanged Event must have been raised and
        /// does not need to be explicitly tested.)
        /// </summary>
        [Fact]
        public void RemovingItemShouldTriggerEvents()
        {
            Order or = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            BriarheartBurger bb2 = new BriarheartBurger();
            BriarheartBurger bb3 = new BriarheartBurger();
            BriarheartBurger bb4 = new BriarheartBurger();
            or.Add(bb);
            or.Add(bb2);
            or.Add(bb3);
            or.Add(bb4);
            Assert.PropertyChanged(or, "Subtotal", () => or.Remove(bb));
            Assert.PropertyChanged(or, "Tax", () => or.Remove(bb2));
            Assert.PropertyChanged(or, "Total", () => or.Remove(bb3));
            Assert.PropertyChanged(or, "Calories", () => or.Remove(bb4));
        }

        /// <summary>
        /// Tests if changing an item already on the order triggers the proper events.
        /// </summary>
        [Fact]
        public void ChangingItemInOrderTriggersEvents()
        {
            Order or = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            or.Add(bb);
            or.Add(dwf);
            Assert.PropertyChanged(or, "Subtotal", () => dwf.Size = Size.Medium);
            Assert.PropertyChanged(or, "Tax", () => dwf.Size = Size.Medium);
            Assert.PropertyChanged(or, "Total", () => dwf.Size = Size.Medium);
            Assert.PropertyChanged(or, "Calories", () => dwf.Size = Size.Medium);
        }

        /// <summary>
        /// Tests if adding and removing items works with the order.
        /// </summary>
        [Fact]
        public void AddingAndRemovingItemAddsAndRemovesItemFromOrder()
        {
            Order or = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            or.Add(bb);
            or.Add(aj);
            Assert.Equal(or[0], bb);
            or.Remove(bb);
            Assert.Equal(or[0], aj);
        }
    }
}
