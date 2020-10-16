/*
 * Author: Sebastian Neal
 * Class name: SmokehouseSkeletonCustomization.xaml.cs
 * Purpose: Partial class for the smokehouse skeleton customization page of the Bleakwind Buffet Point of Sale.
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
    /// Interaction logic for SmokehouseSkeletonCustomization.xaml
    /// </summary>
    public partial class SmokehouseSkeletonCustomization : UserControl
    {
        /// <summary>
        /// Private variable to hold onto current order information.
        /// </summary>
        private Order currentOrder;

        /// <summary>
        /// Private variable to hold onto if current object is part of a combo.
        /// </summary>
        private bool isCombo;

        /// <summary>
        /// Private variable to hold onto current combo information.
        /// </summary>
        private Combo currentCombo;

        /// <summary>
        /// Initializes the smokehouse skeleton customization component in the main window.
        /// </summary>
        /// <param name="currOrder">The current order that must be maintained.</param>
        /// <param name="combo">Whether or not the current object is part of a combo.</param>
        /// <param name="currCombo">The combo this object is a part of.</param>
        public SmokehouseSkeletonCustomization(Order currOrder, bool combo, Combo currCombo)
        {
            InitializeComponent();
            currentOrder = currOrder;
            if (combo)
            {
                isCombo = combo;
                currentCombo = currCombo;
            }
        }

        /// <summary>
        /// Click event for nextButton. Closes customization screen and saves relevant information when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void NextItemOrder(object sender, RoutedEventArgs e)
        {
            if (!isCombo)
            {
                var menu = new MenuSelectionComponent();
                menu.DataContext = currentOrder;
                fullCustomizationGrid.Children.Clear();
                fullComponentBorder.Child = menu;
            }
            else
            {
                var coCustomization = new ComboCustomization(currentOrder);
                coCustomization.DataContext = currentCombo;
                fullCustomizationGrid.Children.Clear();
                fullComponentBorder.Child = coCustomization;
            }
        }
    }
}
