/*
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SailorSodaCustomization.xaml
    /// </summary>
    public partial class SailorSodaCustomization : UserControl
    {
        /// <summary>
        /// Private variable to hold onto current order information.
        /// </summary>
        private Order currentOrder;

        /// <summary>
        /// Initializes the sailor soda customization component in the main window.
        /// </summary>
        /// <param name="currOrder">The current order that must be maintained.</param>
        public SailorSodaCustomization(Order currOrder)
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
            ((SailorSoda)this.DataContext).Size = BleakwindBuffet.Data.Enums.Size.Small;
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
            ((SailorSoda)this.DataContext).Size = BleakwindBuffet.Data.Enums.Size.Medium;
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
            ((SailorSoda)this.DataContext).Size = BleakwindBuffet.Data.Enums.Size.Large;
            small.IsEnabled = true;
            medium.IsEnabled = true;
            large.IsEnabled = false;
        }

        /// <summary>
        /// Selects the soda flavor of the item to be blackberry.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void BlackberryClicked(object sender, RoutedEventArgs e)
        {
            ((SailorSoda)this.DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
            blackberry.IsEnabled = false;
            cherry.IsEnabled = true;
            grapefruit.IsEnabled = true;
            lemon.IsEnabled = true;
            peach.IsEnabled = true;
            watermelon.IsEnabled = true;
        }

        /// <summary>
        /// Selects the soda flavor of the item to be cherry.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void CherryClicked(object sender, RoutedEventArgs e)
        {
            ((SailorSoda)this.DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
            blackberry.IsEnabled = true;
            cherry.IsEnabled = false;
            grapefruit.IsEnabled = true;
            lemon.IsEnabled = true;
            peach.IsEnabled = true;
            watermelon.IsEnabled = true;
        }

        /// <summary>
        /// Selects the soda flavor of the item to be grapefruit.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void GrapefruitClicked(object sender, RoutedEventArgs e)
        {
            ((SailorSoda)this.DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
            blackberry.IsEnabled = true;
            cherry.IsEnabled = true;
            grapefruit.IsEnabled = false;
            lemon.IsEnabled = true;
            peach.IsEnabled = true;
            watermelon.IsEnabled = true;
        }

        /// <summary>
        /// Selects the soda flavor of the item to be lemon.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void LemonClicked(object sender, RoutedEventArgs e)
        {
            ((SailorSoda)this.DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
            blackberry.IsEnabled = true;
            cherry.IsEnabled = true;
            grapefruit.IsEnabled = true;
            lemon.IsEnabled = false;
            peach.IsEnabled = true;
            watermelon.IsEnabled = true;
        }

        /// <summary>
        /// Selects the soda flavor of the item to be peach.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void PeachClicked(object sender, RoutedEventArgs e)
        {
            ((SailorSoda)this.DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
            blackberry.IsEnabled = true;
            cherry.IsEnabled = true;
            grapefruit.IsEnabled = true;
            lemon.IsEnabled = true;
            peach.IsEnabled = false;
            watermelon.IsEnabled = true;
        }

        /// <summary>
        /// Selects the soda flavor of the item to be watermelon.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void WatermelonClicked(object sender, RoutedEventArgs e)
        {
            ((SailorSoda)this.DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
            blackberry.IsEnabled = true;
            cherry.IsEnabled = true;
            grapefruit.IsEnabled = true;
            lemon.IsEnabled = true;
            peach.IsEnabled = true;
            watermelon.IsEnabled = false;
        }
    }
}
