﻿/*
 * Author: Sebastian Neal
 * Class name: AretinoAppleJuiceCustomization.xaml.cs
 * Purpose: Partial class for the aretino apple juice customization page of the Bleakwind Buffet Point of Sale.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using PointOfSale;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuiceCustomization.xaml
    /// </summary>
    public partial class AretinoAppleJuiceCustomization : UserControl
    {
        /// <summary>
        /// Private variable to hold onto current order information.
        /// </summary>
        private Order currentOrder;

        /// <summary>
        /// Initializes the aretino apple juice customization component in the main window.
        /// </summary>
        /// <param name="currOrder">The current order that must be maintained.</param>
        public AretinoAppleJuiceCustomization(Order currOrder)
        {
            InitializeComponent();
            currentOrder = currOrder;
        }

        /// <summary>
        /// Click event for nextButton. Closes customization screen and saves relevant information when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void NextItemOrder(object sender, RoutedEventArgs e)
        {
            var menu = new MenuSelectionComponent();
            menu.DataContext = currentOrder;
            fullCustomizationGrid.Children.Clear();
            fullComponentBorder.Child = menu;
        }

        /// <summary>
        /// Selects the size of the item to be small.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void SmallClicked(object sender, RoutedEventArgs e)
        {
            ((AretinoAppleJuice)this.DataContext).Size = BleakwindBuffet.Data.Enums.Size.Small;
            small.IsEnabled = false;
            medium.IsEnabled = true;
            large.IsEnabled = true;
        }

        /// <summary>
        /// Selects the size of the item to be medium.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void MediumClicked(object sender, RoutedEventArgs e)
        {
            ((AretinoAppleJuice)this.DataContext).Size = BleakwindBuffet.Data.Enums.Size.Medium;
            small.IsEnabled = true;
            medium.IsEnabled = false;
            large.IsEnabled = true;
        }

        /// <summary>
        /// Selects the size of the item to be large.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void LargeClicked(object sender, RoutedEventArgs e)
        {
            ((AretinoAppleJuice)this.DataContext).Size = BleakwindBuffet.Data.Enums.Size.Large;
            small.IsEnabled = true;
            medium.IsEnabled = true;
            large.IsEnabled = false;
        }
    }
}
