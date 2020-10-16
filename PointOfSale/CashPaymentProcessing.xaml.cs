/*
 * Author: Sebastian Neal
 * Class name: CashPaymentProcessing.xaml.cs
 * Purpose: Partial class for the Cash Payment Processing of the Bleakwind Buffet Point of Sale.
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
using RoundRegister;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentProcessing.xaml
    /// </summary>
    public partial class CashPaymentProcessing : UserControl
    {
        /// <summary>
        /// Identifies the Button.NewOrder event.
        /// </summary>
        public static readonly RoutedEvent NewOrderEvent = EventManager.RegisterRoutedEvent("NewOrder", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CashPaymentProcessing));

        /// <summary>
        /// 
        /// </summary>
        public event RoutedEventHandler NewOrder
        {
            add { AddHandler(NewOrderEvent, value); }
            remove { RemoveHandler(NewOrderEvent, value); }
        }

        /// <summary>
        /// Private backing variable to hold onto current order information.
        /// </summary>
        private Order currentOrder;

        /// <summary>
        /// Private backing variable to hold onto the current cash drawer.
        /// </summary>
        private BleakwindBuffet.Data.CashDrawer currentDrawer;

        /// <summary>
        /// Initializes the payment options screen for Bleakwind Buffet Point of Sale.
        /// </summary>
        /// <param name="currOrder">The current order that must be maintained.</param>
        public CashPaymentProcessing(Order currOrder, BleakwindBuffet.Data.CashDrawer currDrawer)
        {
            InitializeComponent();
            currentOrder = currOrder;
            currentDrawer = currDrawer;
        }

        /// <summary>
        /// Click event for return to order button. Returns back to the order screen.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            var menu = new MenuSelectionComponent();
            menu.DataContext = currentOrder;
            fullComponentBorder.Child = menu;
        }

        /// <summary>
        /// Click event for finish order button. Finishes the order when clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void FinishOrder(object sender, RoutedEventArgs e)
        {
            if (currentDrawer.FinalizeCashOrder())
            {
                PrintReceipt(currentDrawer.TotalChange);
                RaiseEvent(new RoutedEventArgs(NewOrderEvent));
            }
            else
            {
                MessageBox.Show("Insufficient Funds!");
            }
        }

        /// <summary>
        /// Click event for pennies increment. Increases amount of customer pennies by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickPenniesIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerPennies++;
        }

        /// <summary>
        /// Click event for pennies decrement. Reduces amount of customer pennies by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickPenniesDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerPennies--;
        }

        /// <summary>
        /// Click event for nickels increment. Increases amount of customer nickels by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickNickelsIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerNickels++;
        }

        /// <summary>
        /// Click event for nickels decrement. Reduces amount of customer nickels by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickNickelsDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerNickels--;
        }

        /// <summary>
        /// Click event for dimes increment. Increases amount of customer dimes by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickDimesIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerDimes += 1;
        }

        /// <summary>
        /// Click event for dimes decrement. Reduces amount of customer dimes by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickDimesDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerDimes -= 1;
        }

        /// <summary>
        /// Click event for quarters increment. Increases amount of customer quarters by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickQuartersIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerQuarters += 1;
        }

        /// <summary>
        /// Click event for quarters decrement. Reduces amount of customer quarters by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickQuartersDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerQuarters -= 1;
        }

        /// <summary>
        /// Click event for half dollars increment. Increases amount of customer half dollars by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickHalfDollarsIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerHalfDollars++;
        }

        /// <summary>
        /// Click event for half dollars decrement. Reduces amount of customer half dollars by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickHalfDollarsDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerHalfDollars--;
        }

        /// <summary>
        /// Click event for dollars increment. Increases amount of customer dollars by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickDollarsIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerDollars++;
        }

        /// <summary>
        /// Click event for dollars decrement. Reduces amount of customer dollars by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickDollarsDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerDollars--;
        }

        /// <summary>
        /// Click event for ones increment. Increases amount of customer ones by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickOnesIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerOnes++;
        }

        /// <summary>
        /// Click event for ones decrement. Reduces amount of customer ones by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickOnesDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerOnes--;
        }

        /// <summary>
        /// Click event for twos increment. Increases amount of customer twos by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickTwosIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerTwos++;
        }

        /// <summary>
        /// Click event for twos decrement. Reduces amount of customer twos by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickTwosDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerTwos--;
        }

        /// <summary>
        /// Click event for fives increment. Increases amount of customer fives by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickFivesIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerFives++;
        }

        /// <summary>
        /// Click event for fives decrement. Reduces amount of customer fives by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickFivesDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerFives--;
        }

        /// <summary>
        /// Click event for tens increment. Increases amount of customer tens by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickTensIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerTens++;
        }

        /// <summary>
        /// Click event for tens decrement. Reduces amount of customer tens by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickTensDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerTens--;
        }

        /// <summary>
        /// Click event for twenties increment. Increases amount of customer twenties by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickTwentiesIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerTwenties++;
        }

        /// <summary>
        /// Click event for twenties decrement. Reduces amount of customer twenties by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickTwentiesDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerTwenties--;
        }

        /// <summary>
        /// Click event for fifties increment. Increases amount of customer fifties by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickFiftiesIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerFifties++;
        }

        /// <summary>
        /// Click event for fifties decrement. Reduces amount of customer fifties by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickFiftiesDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerFifties--;
        }

        /// <summary>
        /// Click event for hundreds increment. Increases amount of customer hundreds by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickHundredsIncrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerHundreds++;
        }

        /// <summary>
        /// Click event for hundreds decrement. Reduces amount of customer hundreds by 1.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        public void ClickHundredsDecrement(object sender, RoutedEventArgs e)
        {
            currentDrawer.CustomerHundreds--;
        }

        /// <summary>
        /// Helper method to print receipt when called.
        /// </summary>
        /// <param name="change">Total change owed to the customer.</param>
        private void PrintReceipt(double change)
        {
            RecieptPrinter.PrintLine("Order #" + Convert.ToString(currentOrder.Number));
            RecieptPrinter.PrintLine("");
            //RecieptPrinter.PrintLine(date and time)
            foreach (IOrderItem item in currentOrder)
            {
                if (item is Combo co)
                {
                    RecieptPrinter.PrintLine("$" + co.Price + "  " + co.Name);
                }
                else if (item is AretinoAppleJuice aj)
                {
                    RecieptPrinter.PrintLine("$" + aj.Price + "  " + aj.Name);
                }
                else if (item is CandlehearthCoffee cc)
                {
                    RecieptPrinter.PrintLine("$" + cc.Price + "  " + cc.Name);
                }
                else if (item is MarkarthMilk mm)
                {
                    RecieptPrinter.PrintLine("$" + mm.Price + "  " + mm.Name);
                }
                else if (item is SailorSoda ss)
                {
                    RecieptPrinter.PrintLine("$" + ss.Price + "  " + ss.Name);
                }
                else if (item is WarriorWater ww)
                {
                    RecieptPrinter.PrintLine("$" + ww.Price + "  " + ww.Name);
                }
                else if (item is BriarheartBurger bb)
                {
                    RecieptPrinter.PrintLine("$" + bb.Price + "  " + bb.Name);
                }
                else if (item is DoubleDraugr dd)
                {
                    RecieptPrinter.PrintLine("$" + dd.Price + "  " + dd.Name);
                }
                else if (item is GardenOrcOmelette goo)
                {
                    RecieptPrinter.PrintLine("$" + goo.Price + "  " + goo.Name);
                }
                else if (item is PhillyPoacher pp)
                {
                    RecieptPrinter.PrintLine("$" + pp.Price + "  " + pp.Name);
                }
                else if (item is SmokehouseSkeleton sms)
                {
                    RecieptPrinter.PrintLine("$" + sms.Price + "  " + sms.Name);
                }
                else if (item is ThalmorTriple tt)
                {
                    RecieptPrinter.PrintLine("$" + tt.Price + "  " + tt.Name);
                }
                else if (item is ThugsTBone ttb)
                {
                    RecieptPrinter.PrintLine("$" + ttb.Price + "  " + ttb.Name);
                }
                else if (item is DragonbornWaffleFries dwf)
                {
                    RecieptPrinter.PrintLine("$" + dwf.Price + "  " + dwf.Name);
                }
                else if (item is FriedMiraak fm)
                {
                    RecieptPrinter.PrintLine("$" + fm.Price + "  " + fm.Name);
                }
                else if (item is MadOtarGrits mog)
                {
                    RecieptPrinter.PrintLine("$" + mog.Price + "  " + mog.Name);
                }
                else if (item is VokunSalad vs)
                {
                    RecieptPrinter.PrintLine("$" + vs.Price + "  " + vs.Name);
                }

                foreach (string instruction in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine("  -" + instruction);
                }
            }
            RecieptPrinter.PrintLine("");
            RecieptPrinter.PrintLine("Subtotal: $" + String.Format("{0:0.00}", Convert.ToString(currentOrder.Subtotal)));
            RecieptPrinter.PrintLine("Tax: $" + String.Format("{0:0.00}", Convert.ToString(currentOrder.Tax)));
            RecieptPrinter.PrintLine("Total: $" + String.Format("{0:0.00}", Convert.ToString(currentOrder.Total)));
            RecieptPrinter.PrintLine("Payment Method: Cash");
            RecieptPrinter.PrintLine("Change: " + Math.Round(change, 2));
            RecieptPrinter.CutTape();
        }
    }
}
