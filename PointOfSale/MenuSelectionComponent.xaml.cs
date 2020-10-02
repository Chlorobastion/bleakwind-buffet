/*
 * Author: Sebastian Neal
 * Class name: MenuSelectionComponent.xaml.cs
 * Purpose: Partial class for the Menu Selection Component of the Bleakwind Buffet Point of Sale.
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {
        /// <summary>
        /// Initializes the menu selection component of the main window.
        /// </summary>
        public MenuSelectionComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for cancelButton. Cancels entire order when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void CancelOrder(object sender, RoutedEventArgs e)
        {
        
        }

        /// <summary>
        /// Click event for finishButton. Finishes entire order when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void FinishOrder(object sender, RoutedEventArgs e)
        {
        
        }

        /// <summary>
        /// Click event for briarheartBurgerButton. Opens briarheart burger customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenBriarheartBurgerCustomization(object sender, RoutedEventArgs e)
        {
            var bbCustomization = new BriarheartBurgerCustomization();
            fullMenuSelectionGrid.Children.Clear();
            bbCustomization.DataContext = new BriarheartBurger();
            fullComponentBorder.Child = bbCustomization;
        }

        /// <summary>
        /// Click event for doubleDraugrButton. Opens double draugr customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenDoubleDraugrCustomization(object sender, RoutedEventArgs e)
        {
            var ddCustomization = new DoubleDraugrCustomization();
            fullMenuSelectionGrid.Children.Clear();
            ddCustomization.DataContext = new DoubleDraugr();
            fullComponentBorder.Child = ddCustomization;
        }

        /// <summary>
        /// Click event for thalmorTripleButton. Opens thalmor triple customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenThalmorTripleCustomization(object sender, RoutedEventArgs e)
        {
            var ttCustomization = new ThalmorTripleCustomization();
            fullMenuSelectionGrid.Children.Clear();
            ttCustomization.DataContext = new ThalmorTriple();
            fullComponentBorder.Child = ttCustomization;
        }

        /// <summary>
        /// Click event for smokehouseSkeletonButton. Opens smokehouse skeleton customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenSmokehouseSkeletonCustomization(object sender, RoutedEventArgs e)
        {
            var ssCustomization = new SmokehouseSkeletonCustomization();
            fullMenuSelectionGrid.Children.Clear();
            ssCustomization.DataContext = new SmokehouseSkeleton();
            fullComponentBorder.Child = ssCustomization;
        }

        /// <summary>
        /// Click event for gardenOrcOmeletteButton. Opens garden orc omelette customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenGardenOrcOmeletteCustomization(object sender, RoutedEventArgs e)
        {
            var gooCustomization = new GardenOrcOmeletteCustomization();
            fullMenuSelectionGrid.Children.Clear();
            gooCustomization.DataContext = new GardenOrcOmelette();
            fullComponentBorder.Child = gooCustomization;
        }

        /// <summary>
        /// Click event for thugsTBoneButton. Opens thugs t-bone customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenThugsTBoneCustomization(object sender, RoutedEventArgs e)
        {
            var ttbCustomization = new ThugsTBoneCustomization();
            fullMenuSelectionGrid.Children.Clear();
            ttbCustomization.DataContext = new ThugsTBone();
            fullComponentBorder.Child = ttbCustomization;
        }

        /// <summary>
        /// Click event for phillyPoacherrButton. Opens philly poacher customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenPhillyPoacherCustomization(object sender, RoutedEventArgs e)
        {
            var ppCustomization = new PhillyPoacherCustomization();
            fullMenuSelectionGrid.Children.Clear();
            ppCustomization.DataContext = new PhillyPoacher();
            fullComponentBorder.Child = ppCustomization;
        }

        /// <summary>
        /// Click event for sailorSodaButton. Opens sailor soda customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenSailorSodaCustomization(object sender, RoutedEventArgs e)
        {
            var ssCustomization = new SailorSodaCustomization();
            fullMenuSelectionGrid.Children.Clear();
            ssCustomization.DataContext = new SailorSoda();
            fullComponentBorder.Child = ssCustomization;
        }

        /// <summary>
        /// Click event for markarthMilkButton. Opens markarth milk customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenMarkarthMilkCustomization(object sender, RoutedEventArgs e)
        {
            var mmCustomization = new MarkarthMilkCustomization();
            fullMenuSelectionGrid.Children.Clear();
            mmCustomization.DataContext = new MarkarthMilk();
            fullComponentBorder.Child = mmCustomization;
        }

        /// <summary>
        /// Click event for aretinoAppleJuiceButton. Opens aretino apple juice customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenAretinoAppleJuiceCustomization(object sender, RoutedEventArgs e)
        {
            var ajCustomization = new AretinoAppleJuiceCustomization();
            fullMenuSelectionGrid.Children.Clear();
            ajCustomization.DataContext = new AretinoAppleJuice();
            fullComponentBorder.Child = ajCustomization;
        }

        /// <summary>
        /// Click event for candlehearthCoffeeButton. Opens candlehearth coffee customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenCandlehearthCoffeeCustomization(object sender, RoutedEventArgs e)
        {
            var ccCustomization = new CandlehearthCoffeeCustomization();
            fullMenuSelectionGrid.Children.Clear();
            ccCustomization.DataContext = new CandlehearthCoffee();
            fullComponentBorder.Child = ccCustomization;
        }

        /// <summary>
        /// Click event for warriorWaterButton. Opens warrior water customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenWarriorWaterCustomization(object sender, RoutedEventArgs e)
        {
            var wwCustomization = new WarriorWaterCustomization();
            fullMenuSelectionGrid.Children.Clear();
            wwCustomization.DataContext = new WarriorWater();
            fullComponentBorder.Child = wwCustomization;
        }

        /// <summary>
        /// Click event for vokunSaladButton. Opens vokun salad customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenVokunSaladCustomization(object sender, RoutedEventArgs e)
        {
            var vsCustomization = new VokunSaladCustomization();
            fullMenuSelectionGrid.Children.Clear();
            vsCustomization.DataContext = new VokunSalad();
            fullComponentBorder.Child = vsCustomization;
        }

        /// <summary>
        /// Click event for friedMiraakButton. Opens fried miraak customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenFriedMiraakCustomization(object sender, RoutedEventArgs e)
        {
            var fmCustomization = new FriedMiraakCustomization();
            fullMenuSelectionGrid.Children.Clear();
            fmCustomization.DataContext = new FriedMiraak();
            fullComponentBorder.Child = fmCustomization;
        }

        /// <summary>
        /// Click event for madOtarGritsButton. Opens mad otar grits customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenMadOtarGritsCustomization(object sender, RoutedEventArgs e)
        {
            var mogCustomization = new MadOtarGritsCustomization();
            fullMenuSelectionGrid.Children.Clear();
            mogCustomization.DataContext = new MadOtarGrits();
            fullComponentBorder.Child = mogCustomization;
        }

        /// <summary>
        /// Click event for dragonbornWaffleFriesButton. Opens dragonborn waffle fries customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenDragonbornWaffleFriesCustomization(object sender, RoutedEventArgs e)
        {
            var dwfCustomization = new DragonbornWaffleFriesCustomization();
            fullMenuSelectionGrid.Children.Clear();
            dwfCustomization.DataContext = new DragonbornWaffleFries();
            fullComponentBorder.Child = dwfCustomization;
        }
    }
}
