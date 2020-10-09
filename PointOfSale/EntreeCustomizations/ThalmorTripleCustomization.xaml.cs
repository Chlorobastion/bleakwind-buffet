﻿/*
 * Author: Sebastian Neal
 * Class name: ThalmorTripleCustomization.xaml.cs
 * Purpose: Partial class for the thalmor triple customization page of the Bleakwind Buffet Point of Sale.
 */

using BleakwindBuffet.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ThalmorTripleCustomization.xaml
    /// </summary>
    public partial class ThalmorTripleCustomization : UserControl
    {
        /// <summary>
        /// Private variable to hold onto current order information.
        /// </summary>
        private Order currentOrder;

        /// <summary>
        /// Initializes the thalmor triple customization component in the main window.
        /// </summary>
        /// <param name="currOrder">The current order that must be maintained.</param>
        public ThalmorTripleCustomization(Order currOrder)
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
    }
}
