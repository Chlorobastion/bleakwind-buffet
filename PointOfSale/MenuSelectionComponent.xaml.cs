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
using BleakwindBuffet.Data;
using System.Windows.Automation;

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
        /// Click event for comboButton. Opens combo customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenComboCustomization(object sender, RoutedEventArgs e)
        {
            var coCustomization = new ComboCustomization((Order)this.DataContext);
            fullMenuSelectionGrid.Children.Clear();
            Combo co = new Combo();
            ((Order)this.DataContext).Add(co);
            coCustomization.DataContext = co;
            fullComponentBorder.Child = coCustomization;
        }

        /// <summary>
        /// Click event for briarheartBurgerButton. Opens briarheart burger customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenBriarheartBurgerCustomization(object sender, RoutedEventArgs e)
        {
            var bbCustomization = new BriarheartBurgerCustomization((Order)this.DataContext, false, new Combo());
            fullMenuSelectionGrid.Children.Clear();
            BriarheartBurger bb = new BriarheartBurger();
            ((Order)this.DataContext).Add(bb);
            bbCustomization.DataContext = bb;
            fullComponentBorder.Child = bbCustomization;
        }

        /// <summary>
        /// Click event for doubleDraugrButton. Opens double draugr customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenDoubleDraugrCustomization(object sender, RoutedEventArgs e)
        {
            var ddCustomization = new DoubleDraugrCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            DoubleDraugr dd = new DoubleDraugr();
            ((Order)this.DataContext).Add(dd);
            ddCustomization.DataContext = dd;
            fullComponentBorder.Child = ddCustomization;
        }

        /// <summary>
        /// Click event for thalmorTripleButton. Opens thalmor triple customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenThalmorTripleCustomization(object sender, RoutedEventArgs e)
        {
            var ttCustomization = new ThalmorTripleCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            ThalmorTriple tt = new ThalmorTriple();
            ((Order)this.DataContext).Add(tt);
            ttCustomization.DataContext = tt;
            fullComponentBorder.Child = ttCustomization;
        }

        /// <summary>
        /// Click event for smokehouseSkeletonButton. Opens smokehouse skeleton customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenSmokehouseSkeletonCustomization(object sender, RoutedEventArgs e)
        {
            var ssCustomization = new SmokehouseSkeletonCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ((Order)this.DataContext).Add(ss);
            ssCustomization.DataContext = ss;
            fullComponentBorder.Child = ssCustomization;
        }

        /// <summary>
        /// Click event for gardenOrcOmeletteButton. Opens garden orc omelette customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenGardenOrcOmeletteCustomization(object sender, RoutedEventArgs e)
        {
            var gooCustomization = new GardenOrcOmeletteCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            ((Order)this.DataContext).Add(goo);
            gooCustomization.DataContext = goo;
            fullComponentBorder.Child = gooCustomization;
        }

        /// <summary>
        /// Click event for thugsTBoneButton. Opens thugs t-bone customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenThugsTBoneCustomization(object sender, RoutedEventArgs e)
        {
            var ttbCustomization = new ThugsTBoneCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            ThugsTBone ttb = new ThugsTBone();
            ((Order)this.DataContext).Add(ttb);
            ttbCustomization.DataContext = ttb;
            fullComponentBorder.Child = ttbCustomization;
        }

        /// <summary>
        /// Click event for phillyPoacherrButton. Opens philly poacher customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenPhillyPoacherCustomization(object sender, RoutedEventArgs e)
        {
            var ppCustomization = new PhillyPoacherCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            PhillyPoacher pp = new PhillyPoacher();
            ((Order)this.DataContext).Add(pp);
            ppCustomization.DataContext = pp;
            fullComponentBorder.Child = ppCustomization;
        }

        /// <summary>
        /// Click event for sailorSodaButton. Opens sailor soda customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenSailorSodaCustomization(object sender, RoutedEventArgs e)
        {
            var ssCustomization = new SailorSodaCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            SailorSoda ss = new SailorSoda();
            ((Order)this.DataContext).Add(ss);
            ssCustomization.DataContext = ss;
            fullComponentBorder.Child = ssCustomization;
        }

        /// <summary>
        /// Click event for markarthMilkButton. Opens markarth milk customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenMarkarthMilkCustomization(object sender, RoutedEventArgs e)
        {
            var mmCustomization = new MarkarthMilkCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            MarkarthMilk mm = new MarkarthMilk();
            ((Order)this.DataContext).Add(mm);
            mmCustomization.DataContext = mm;
            fullComponentBorder.Child = mmCustomization;
        }

        /// <summary>
        /// Click event for aretinoAppleJuiceButton. Opens aretino apple juice customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenAretinoAppleJuiceCustomization(object sender, RoutedEventArgs e)
        {
            var ajCustomization = new AretinoAppleJuiceCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            ((Order)this.DataContext).Add(aj);
            ajCustomization.DataContext = aj;
            fullComponentBorder.Child = ajCustomization;
        }

        /// <summary>
        /// Click event for candlehearthCoffeeButton. Opens candlehearth coffee customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenCandlehearthCoffeeCustomization(object sender, RoutedEventArgs e)
        {
            var ccCustomization = new CandlehearthCoffeeCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            ((Order)this.DataContext).Add(cc);
            ccCustomization.DataContext = cc;
            fullComponentBorder.Child = ccCustomization;
        }

        /// <summary>
        /// Click event for warriorWaterButton. Opens warrior water customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenWarriorWaterCustomization(object sender, RoutedEventArgs e)
        {
            var wwCustomization = new WarriorWaterCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            WarriorWater ww = new WarriorWater();
            ((Order)this.DataContext).Add(ww);
            wwCustomization.DataContext = ww;
            fullComponentBorder.Child = wwCustomization;
        }

        /// <summary>
        /// Click event for vokunSaladButton. Opens vokun salad customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenVokunSaladCustomization(object sender, RoutedEventArgs e)
        {
            var vsCustomization = new VokunSaladCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            VokunSalad vs = new VokunSalad();
            ((Order)this.DataContext).Add(vs);
            vsCustomization.DataContext = vs;
            fullComponentBorder.Child = vsCustomization;
        }

        /// <summary>
        /// Click event for friedMiraakButton. Opens fried miraak customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenFriedMiraakCustomization(object sender, RoutedEventArgs e)
        {
            var fmCustomization = new FriedMiraakCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            FriedMiraak fm = new FriedMiraak();
            ((Order)this.DataContext).Add(fm);
            fmCustomization.DataContext = fm;
            fullComponentBorder.Child = fmCustomization;
        }

        /// <summary>
        /// Click event for madOtarGritsButton. Opens mad otar grits customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenMadOtarGritsCustomization(object sender, RoutedEventArgs e)
        {
            var mogCustomization = new MadOtarGritsCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            MadOtarGrits mog = new MadOtarGrits();
            ((Order)this.DataContext).Add(mog);
            mogCustomization.DataContext = mog;
            fullComponentBorder.Child = mogCustomization;
        }

        /// <summary>
        /// Click event for dragonbornWaffleFriesButton. Opens dragonborn waffle fries customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenDragonbornWaffleFriesCustomization(object sender, RoutedEventArgs e)
        {
            var dwfCustomization = new DragonbornWaffleFriesCustomization((Order)this.DataContext, false, null);
            fullMenuSelectionGrid.Children.Clear();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            ((Order)this.DataContext).Add(dwf);
            dwfCustomization.DataContext = dwf;
            fullComponentBorder.Child = dwfCustomization;
        }
    }
}
