﻿/*
 * Author: Sebastian Neal
 * Class name: SailorSodaCustomization.xaml.cs
 * Purpose: Partial class for the sailor soda customization page of the Bleakwind Buffet Point of Sale.
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SailorSodaCustomization.xaml
    /// </summary>
    public partial class SailorSodaCustomization : UserControl
    {
        /// <summary>
        /// Initializes the sailor soda customization component in the main window.
        /// </summary>
        public SailorSodaCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for cancelButton. Closes customization menu without further action when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void CancelItemOrder(object sender, RoutedEventArgs e)
        {
            var menu = new MenuSelectionComponent();
            fullCustomizationGrid.Children.Clear();
            fullComponentBorder.Child = menu;
        }

        /// <summary>
        /// Click event for nextButton. Closes customization screen and saves relevant information when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void NextItemOrder(object sender, RoutedEventArgs e)
        {

            var menu = new MenuSelectionComponent();
            fullCustomizationGrid.Children.Clear();
            fullComponentBorder.Child = menu;
        }




    }
}
