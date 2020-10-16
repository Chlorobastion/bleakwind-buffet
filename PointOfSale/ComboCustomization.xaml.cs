/*
 * Author: Sebastian Neal
 * Class name: ComboCustomization.xaml.cs
 * Purpose: Partial class for the briarheart burger customization page of the Bleakwind Buffet Point of Sale.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for ComboCustomization.xaml
    /// </summary>
    public partial class ComboCustomization : UserControl
    {
        /// <summary>
        /// Private variable to hold onto current order information.
        /// </summary>
        private Order currentOrder;

        /// <summary>
        /// Initializes the combo customization component in the main window.
        /// </summary>
        /// <param name="currOrder">The current order that must be maintained.</param>
        public ComboCustomization(Order currOrder)
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
        /// Click event for briarheartBurgerButton. Opens briarheart burger customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenBriarheartBurgerCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Entree is BriarheartBurger oldbb)
            {
                var bbCustomization = new BriarheartBurgerCustomization(currentOrder, true, (Combo)this.DataContext);
                bbCustomization.DataContext = oldbb;
                fullComponentBorder.Child = bbCustomization;
            }
            else
            {
                BriarheartBurger bb = new BriarheartBurger();
                var bbCustomization = new BriarheartBurgerCustomization(currentOrder, true, (Combo)this.DataContext);
                ((Combo)this.DataContext).Entree = bb;
                bbCustomization.DataContext = bb;
                fullComponentBorder.Child = bbCustomization;
            }
        }

        /// <summary>
        /// Click event for doubleDraugrButton. Opens double draugr customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenDoubleDraugrCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Entree is DoubleDraugr olddd)
            {
                var ddCustomization = new DoubleDraugrCustomization(currentOrder, true, (Combo)this.DataContext);
                ddCustomization.DataContext = olddd;
                fullComponentBorder.Child = ddCustomization;
            }
            else
            {
                var ddCustomization = new DoubleDraugrCustomization(currentOrder, true, (Combo)this.DataContext);
                DoubleDraugr dd = new DoubleDraugr();
                ((Combo)this.DataContext).Entree = dd;
                ddCustomization.DataContext = dd;
                fullComponentBorder.Child = ddCustomization;
            }
        }

        /// <summary>
        /// Click event for thalmorTripleButton. Opens thalmor triple customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenThalmorTripleCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Entree is ThalmorTriple oldtt)
            {
                var ttCustomization = new ThalmorTripleCustomization(currentOrder, true, (Combo)this.DataContext);
                ttCustomization.DataContext = oldtt;
                fullComponentBorder.Child = ttCustomization;
            }
            else
            {
                var ttCustomization = new ThalmorTripleCustomization(currentOrder, true, (Combo)this.DataContext);
                ThalmorTriple tt = new ThalmorTriple();
                ((Combo)this.DataContext).Entree = tt;
                ttCustomization.DataContext = tt;
                fullComponentBorder.Child = ttCustomization;
            }
        }

        /// <summary>
        /// Click event for smokehouseSkeletonButton. Opens smokehouse skeleton customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenSmokehouseSkeletonCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Entree is SmokehouseSkeleton oldss)
            {
                var ssCustomization = new SmokehouseSkeletonCustomization(currentOrder, true, (Combo)this.DataContext);
                ssCustomization.DataContext = oldss;
                fullComponentBorder.Child = ssCustomization;
            }
            else
            {
                var ssCustomization = new SmokehouseSkeletonCustomization(currentOrder, true, (Combo)this.DataContext);
                SmokehouseSkeleton ss = new SmokehouseSkeleton();
                ((Combo)this.DataContext).Entree = ss;
                ssCustomization.DataContext = ss;
                fullComponentBorder.Child = ssCustomization;
            }
        }

        /// <summary>
        /// Click event for gardenOrcOmeletteButton. Opens garden orc omelette customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenGardenOrcOmeletteCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Entree is GardenOrcOmelette oldgoo)
            {
                var gooCustomization = new GardenOrcOmeletteCustomization(currentOrder, true, (Combo)this.DataContext);
                gooCustomization.DataContext = oldgoo;
                fullComponentBorder.Child = gooCustomization;
            }
            else
            {
                var gooCustomization = new GardenOrcOmeletteCustomization(currentOrder, true, (Combo)this.DataContext);
                GardenOrcOmelette goo = new GardenOrcOmelette();
                ((Combo)this.DataContext).Entree = goo;
                gooCustomization.DataContext = goo;
                fullComponentBorder.Child = gooCustomization;
            }
        }

        /// <summary>
        /// Click event for thugsTBoneButton. Opens thugs t-bone customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenThugsTBoneCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Entree is ThugsTBone oldttb)
            {
                var ttbCustomization = new ThugsTBoneCustomization(currentOrder, true, (Combo)this.DataContext);
               ttbCustomization.DataContext = oldttb;
                fullComponentBorder.Child = ttbCustomization;
            }
            else
            {
                var ttbCustomization = new ThugsTBoneCustomization(currentOrder, true, (Combo)this.DataContext);
                ThugsTBone ttb = new ThugsTBone();
                ((Combo)this.DataContext).Entree = ttb;
                ttbCustomization.DataContext = ttb;
                fullComponentBorder.Child = ttbCustomization;
            }
        }

        /// <summary>
        /// Click event for phillyPoacherrButton. Opens philly poacher customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenPhillyPoacherCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Entree is PhillyPoacher oldpp)
            {
                var ppCustomization = new PhillyPoacherCustomization(currentOrder, true, (Combo)this.DataContext);
                ppCustomization.DataContext = oldpp;
                fullComponentBorder.Child = ppCustomization;
            }
            else
            {
                var ppCustomization = new PhillyPoacherCustomization(currentOrder, true, (Combo)this.DataContext);
                PhillyPoacher pp = new PhillyPoacher();
                ((Combo)this.DataContext).Entree = pp;
                ppCustomization.DataContext = pp;
                fullComponentBorder.Child = ppCustomization;
            }
        }

        /// <summary>
        /// Click event for sailorSodaButton. Opens sailor soda customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenSailorSodaCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Drink is SailorSoda oldss)
            {
                var ssCustomization = new SailorSodaCustomization(currentOrder, true, (Combo)this.DataContext);
                ssCustomization.DataContext = oldss;
                fullComponentBorder.Child = ssCustomization;
            }
            else
            {
                var ssCustomization = new SailorSodaCustomization(currentOrder, true, (Combo)this.DataContext);
                SailorSoda ss = new SailorSoda();
                ((Combo)this.DataContext).Drink = ss;
                ssCustomization.DataContext = ss;
                fullComponentBorder.Child = ssCustomization;
            }
        }

        /// <summary>
        /// Click event for markarthMilkButton. Opens markarth milk customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenMarkarthMilkCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Drink is MarkarthMilk oldmm)
            {
                var mmCustomization = new MarkarthMilkCustomization(currentOrder, true, (Combo)this.DataContext);
                mmCustomization.DataContext = oldmm;
                fullComponentBorder.Child = mmCustomization;
            }
            else
            {
                var mmCustomization = new MarkarthMilkCustomization(currentOrder, true, (Combo)this.DataContext);
                MarkarthMilk mm = new MarkarthMilk();
                ((Combo)this.DataContext).Drink = mm;
                mmCustomization.DataContext = mm;
                fullComponentBorder.Child = mmCustomization;
            }
        }

        /// <summary>
        /// Click event for aretinoAppleJuiceButton. Opens aretino apple juice customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenAretinoAppleJuiceCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Drink is AretinoAppleJuice oldaj)
            {
                var ajCustomization = new AretinoAppleJuiceCustomization(currentOrder, true, (Combo)this.DataContext);
                ajCustomization.DataContext = oldaj;
                fullComponentBorder.Child = ajCustomization;
            }
            else
            {
                var ajCustomization = new AretinoAppleJuiceCustomization(currentOrder, true, (Combo)this.DataContext);
                AretinoAppleJuice aj = new AretinoAppleJuice();
                ((Combo)this.DataContext).Drink = aj;
                ajCustomization.DataContext = aj;
                fullComponentBorder.Child = ajCustomization;
            }
        }

        /// <summary>
        /// Click event for candlehearthCoffeeButton. Opens candlehearth coffee customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenCandlehearthCoffeeCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Drink is CandlehearthCoffee oldcc)
            {
                var ccCustomization = new CandlehearthCoffeeCustomization(currentOrder, true, (Combo)this.DataContext);
                ccCustomization.DataContext = oldcc;
                fullComponentBorder.Child = ccCustomization;
            }
            else
            {
                var ccCustomization = new CandlehearthCoffeeCustomization(currentOrder, true, (Combo)this.DataContext);
                CandlehearthCoffee cc = new CandlehearthCoffee();
                ((Combo)this.DataContext).Drink = cc;
                ccCustomization.DataContext = cc;
                fullComponentBorder.Child = ccCustomization;
            }
        }

        /// <summary>
        /// Click event for warriorWaterButton. Opens warrior water customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenWarriorWaterCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Drink is WarriorWater oldww)
            {
                var wwCustomization = new WarriorWaterCustomization(currentOrder, true, (Combo)this.DataContext);
                wwCustomization.DataContext = oldww;
                fullComponentBorder.Child = wwCustomization;
            }
            else
            {
                var wwCustomization = new WarriorWaterCustomization(currentOrder, true, (Combo)this.DataContext);
                WarriorWater ww = new WarriorWater();
                ((Combo)this.DataContext).Drink = ww;
                wwCustomization.DataContext = ww;
                fullComponentBorder.Child = wwCustomization;
            }
        }

        /// <summary>
        /// Click event for vokunSaladButton. Opens vokun salad customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenVokunSaladCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Side is VokunSalad oldvs)
            {
                var vsCustomization = new VokunSaladCustomization(currentOrder, true, (Combo)this.DataContext);
                vsCustomization.DataContext = oldvs;
                fullComponentBorder.Child = vsCustomization;
            }
            else
            {
                var vsCustomization = new VokunSaladCustomization(currentOrder, true, (Combo)this.DataContext);
                VokunSalad vs = new VokunSalad();
                ((Combo)this.DataContext).Side = vs;
                vsCustomization.DataContext = vs;
                fullComponentBorder.Child = vsCustomization;
            }
        }

        /// <summary>
        /// Click event for friedMiraakButton. Opens fried miraak customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenFriedMiraakCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Side is FriedMiraak oldfm)
            {
                var fmCustomization = new FriedMiraakCustomization(currentOrder, true, (Combo)this.DataContext);
                fmCustomization.DataContext = oldfm;
                fullComponentBorder.Child = fmCustomization;
            }
            else
            {
                var fmCustomization = new FriedMiraakCustomization(currentOrder, true, (Combo)this.DataContext);
                FriedMiraak fm = new FriedMiraak();
                ((Combo)this.DataContext).Side = fm;
                fmCustomization.DataContext = fm;
                fullComponentBorder.Child = fmCustomization;
            }
        }

        /// <summary>
        /// Click event for madOtarGritsButton. Opens mad otar grits customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenMadOtarGritsCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Side is MadOtarGrits oldmog)
            {
                var mogCustomization = new MadOtarGritsCustomization(currentOrder, true, (Combo)this.DataContext);
                mogCustomization.DataContext = oldmog;
                fullComponentBorder.Child = mogCustomization;
            }
            else
            {
                var mogCustomization = new MadOtarGritsCustomization(currentOrder, true, (Combo)this.DataContext);
                MadOtarGrits mog = new MadOtarGrits();
                ((Combo)this.DataContext).Side = mog;
                mogCustomization.DataContext = mog;
                fullComponentBorder.Child = mogCustomization;
            }
        }

        /// <summary>
        /// Click event for dragonbornWaffleFriesButton. Opens dragonborn waffle fries customization screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void OpenDragonbornWaffleFriesCustomization(object sender, RoutedEventArgs e)
        {
            if (((Combo)this.DataContext).Side is DragonbornWaffleFries olddwf)
            {
                var dwfCustomization = new DragonbornWaffleFriesCustomization(currentOrder, true, (Combo)this.DataContext);
               dwfCustomization.DataContext = olddwf;
                fullComponentBorder.Child = dwfCustomization;
            }
            else
            {
                var dwfCustomization = new DragonbornWaffleFriesCustomization(currentOrder, true, (Combo)this.DataContext);
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                ((Combo)this.DataContext).Side = dwf;
                dwfCustomization.DataContext = dwf;
                fullComponentBorder.Child = dwfCustomization;
            }
        }
    }
}
