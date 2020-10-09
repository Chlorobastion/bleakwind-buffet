/*
 * Author: Sebastian Neal
 * Class name: MainWindow.xaml.cs
 * Purpose: Partial class for the Main Window of the Bleakwind Buffet Point of Sale.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes the main window for Bleakwind Buffet Point of Sale.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order or = new Order();
            this.DataContext = or;
            menuSelectionComponent.DataContext = or;
        }

        /// <summary>
        /// Click event for cancelButton. Cancels entire order when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void CancelOrder(object sender, RoutedEventArgs e)
        {
            Order or = new Order();
            this.DataContext = or;
            MenuSelectionComponent msc = new MenuSelectionComponent();
            mscBorder.Child = msc;
            msc.DataContext = or;
        }

        /// <summary>
        /// Click event for finishButton. Finishes entire order when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void FinishOrder(object sender, RoutedEventArgs e)
        {

            Order or = new Order();
            this.DataContext = or;
            MenuSelectionComponent msc = new MenuSelectionComponent();
            mscBorder.Child = msc;
            msc.DataContext = or;
        }


        /// <summary>
        /// Click event for cancel. Cancels item when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void CancelItem(object sender, RoutedEventArgs e)
        {
            var item = orderList.SelectedItem;
            IOrderItem removeMe = new AretinoAppleJuice();
            if (item is Combo co)
            {
                removeMe = co;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is AretinoAppleJuice aj)
            {
                removeMe = aj;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is CandlehearthCoffee cc)
            {
                removeMe = cc;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is MarkarthMilk mm)
            {
                removeMe = mm;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is SailorSoda ss)
            {
                removeMe = ss;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is WarriorWater ww)
            {
                removeMe = ww;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is BriarheartBurger bb)
            {
                removeMe = bb;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is DoubleDraugr dd)
            {
                removeMe = dd;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is GardenOrcOmelette goo)
            {
                removeMe = goo;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is PhillyPoacher pp)
            {
                removeMe = pp;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is SmokehouseSkeleton sms)
            {
                removeMe = sms;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is ThalmorTriple tt)
            {
                removeMe = tt;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is ThugsTBone ttb)
            {
                removeMe = ttb;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is DragonbornWaffleFries dwf)
            {
                removeMe = dwf;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is FriedMiraak fm)
            {
                removeMe = fm;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is MadOtarGrits mog)
            {
                removeMe = mog;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            else if (item is VokunSalad vs)
            {
                removeMe = vs;
                var menu = new MenuSelectionComponent();
                menu.DataContext = this.DataContext;
                mscBorder.Child = menu;
                orderList.SelectedItem = null;
            }
            ((Order)OrderComponent.DataContext).Remove(removeMe);
        }

        /// <summary>
        /// Event when an item in the order list is selected. Opens the customization screen for that item.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event</param>
        /// <param name="e">Contains the event data.</param>
        void ChangeItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var item = orderList.SelectedItem;
            if (item is Combo co)
            {
                // handle later
            }
            else if (item is AretinoAppleJuice aj)
            {
                AretinoAppleJuiceCustomization ajc = new AretinoAppleJuiceCustomization(((Order)this.DataContext));
                ajc.DataContext = aj;
                mscBorder.Child = ajc;
            }
            else if (item is CandlehearthCoffee cc)
            {
                CandlehearthCoffeeCustomization ccc = new CandlehearthCoffeeCustomization(((Order)this.DataContext));
                ccc.DataContext = cc;
                mscBorder.Child = ccc;
            }
            else if (item is MarkarthMilk mm)
            {
                MarkarthMilkCustomization mmc = new MarkarthMilkCustomization(((Order)this.DataContext));
                mmc.DataContext = mm;
                mscBorder.Child = mmc;
            }
            else if (item is SailorSoda ss)
            {
                SailorSodaCustomization ssc = new SailorSodaCustomization(((Order)this.DataContext));
                ssc.DataContext = ss;
                mscBorder.Child = ssc;
            }
            else if (item is WarriorWater ww)
            {
                WarriorWaterCustomization wwc = new WarriorWaterCustomization(((Order)this.DataContext));
                wwc.DataContext = ww;
                mscBorder.Child = wwc;
            }
            else if (item is BriarheartBurger bb)
            {
                BriarheartBurgerCustomization bbc = new BriarheartBurgerCustomization(((Order)this.DataContext));
                bbc.DataContext = bb;
                mscBorder.Child = bbc;
            }
            else if (item is DoubleDraugr dd)
            {
                DoubleDraugrCustomization ddc = new DoubleDraugrCustomization(((Order)this.DataContext));
                ddc.DataContext = dd;
                mscBorder.Child = ddc;
            }
            else if (item is GardenOrcOmelette goo)
            {
                GardenOrcOmeletteCustomization gooc = new GardenOrcOmeletteCustomization(((Order)this.DataContext));
                gooc.DataContext = goo;
                mscBorder.Child = gooc;
            }
            else if (item is PhillyPoacher pp)
            {
                PhillyPoacherCustomization ppc = new PhillyPoacherCustomization(((Order)this.DataContext));
                ppc.DataContext = pp;
                mscBorder.Child = ppc;
            }
            else if (item is SmokehouseSkeleton sms)
            {
                SmokehouseSkeletonCustomization smsc = new SmokehouseSkeletonCustomization(((Order)this.DataContext));
                smsc.DataContext = sms;
                mscBorder.Child = smsc;
            }
            else if (item is ThalmorTriple tt)
            {
                ThalmorTripleCustomization ttc = new ThalmorTripleCustomization(((Order)this.DataContext));
                ttc.DataContext = tt;
                mscBorder.Child = ttc;
            }
            else if (item is ThugsTBone ttb)
            {
                ThugsTBoneCustomization ttbc = new ThugsTBoneCustomization(((Order)this.DataContext));
                ttbc.DataContext = ttb;
                mscBorder.Child = ttbc;
            }
            else if (item is DragonbornWaffleFries dwf)
            {
                DragonbornWaffleFriesCustomization dwfc = new DragonbornWaffleFriesCustomization(((Order)this.DataContext));
                dwfc.DataContext = dwf;
                mscBorder.Child = dwfc;
            }
            else if (item is FriedMiraak fm)
            {
                FriedMiraakCustomization fmc = new FriedMiraakCustomization(((Order)this.DataContext));
                fmc.DataContext = fm;
                mscBorder.Child = fmc;
            }
            else if (item is MadOtarGrits mog)
            {
                MadOtarGritsCustomization mogc = new MadOtarGritsCustomization(((Order)this.DataContext));
                mogc.DataContext = mog;
                mscBorder.Child = mogc;
            }
            else if (item is VokunSalad vs)
            {
                VokunSaladCustomization vsc = new VokunSaladCustomization(((Order)this.DataContext));
                vsc.DataContext = vs;
                mscBorder.Child = vsc;
            }
        }
    }
}
