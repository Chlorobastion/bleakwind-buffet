/*
 * Author: Sebastian Neal
 * Class name: PaymentOptionsScreen.xaml.cs
 * Purpose: Partial class for the Payment Options Screen of the Bleakwind Buffet Point of Sale.
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptionsScreen.xaml
    /// </summary>
    public partial class PaymentOptionsScreen : UserControl
    {
        /// <summary>
        /// Identifies the Button.NewOrder event.
        /// </summary>
        public static readonly RoutedEvent NewOrderEvent = EventManager.RegisterRoutedEvent("NewOrder", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(PaymentOptionsScreen));

        /// <summary>
        /// 
        /// </summary>
        public event RoutedEventHandler NewOrder
        {
            add { AddHandler(NewOrderEvent, value); }
            remove { RemoveHandler(NewOrderEvent, value); }
        }

        /// <summary>
        /// Private variable to hold onto current order information.
        /// </summary>
        private Order currentOrder;

        /// <summary>
        /// Initializes the payment options screen for Bleakwind Buffet Point of Sale.
        /// </summary>
        /// <param name="currOrder">The current order that must be maintained.</param>
        public PaymentOptionsScreen(Order currOrder)
        {
            InitializeComponent();
            currentOrder = currOrder;
        }

        /// <summary>
        /// Click event for cashButton. Opens cash payment screen when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void SelectCash(object sender, RoutedEventArgs e)
        {
            BleakwindBuffet.Data.CashDrawer cd = new BleakwindBuffet.Data.CashDrawer(currentOrder.Total);
            var cashScreen = new CashPaymentProcessing(currentOrder, cd);
            cashScreen.DataContext = cd;
            fullComponentBorder.Child = cashScreen;
        }

        /// <summary>
        /// Click event for creditOrDebitButton.  when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void SelectCreditOrDebit(object sender, RoutedEventArgs e)
        {
            var cardOutcome = CardReader.RunCard(currentOrder.Total);
            switch (cardOutcome)
            {
                case CardTransactionResult.Approved:
                    PrintReceipt();
                    RaiseEvent(new RoutedEventArgs(NewOrderEvent));
                    break;
                case CardTransactionResult.Declined:
                    //handle card declined
                    break;
                case CardTransactionResult.ReadError:
                    //handle card read error
                    break;
                case CardTransactionResult.InsufficientFunds:
                    //handle card insufficient funds
                    break;
                case CardTransactionResult.IncorrectPin:
                    //handle card incorrect pin
                    break;
            }    
        }

        /// <summary>
        /// Click event for returnButton. Returns to current order when button is clicked.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            var menu = new MenuSelectionComponent();
            menu.DataContext = currentOrder;
            fullComponentBorder.Child = menu;
        }

        /// <summary>
        /// Helper method to print receipt when called.
        /// </summary>
        private void PrintReceipt()
        {
            RecieptPrinter.PrintLine("Order #" + Convert.ToString(currentOrder.Number));
            RecieptPrinter.PrintLine("");
            //RecieptPrinter.PrintLine(date and time)
            foreach (IOrderItem item in currentOrder)
            {
                if (item is Combo co)
                {
                    RecieptPrinter.PrintLine("$" + co.Price + " " + co.Name);
                }
                else if (item is AretinoAppleJuice aj)
                {
                    RecieptPrinter.PrintLine("$" + aj.Price + " " + aj.Name);
                }
                else if (item is CandlehearthCoffee cc)
                {
                    RecieptPrinter.PrintLine("$" + cc.Price + " " + cc.Name);
                }
                else if (item is MarkarthMilk mm)
                {
                    RecieptPrinter.PrintLine("$" + mm.Price + " " + mm.Name);
                }
                else if (item is SailorSoda ss)
                {
                    RecieptPrinter.PrintLine("$" + ss.Price + " " + ss.Name);
                }
                else if (item is WarriorWater ww)
                {
                    RecieptPrinter.PrintLine("$" + ww.Price + " " + ww.Name);
                }
                else if (item is BriarheartBurger bb)
                {
                    RecieptPrinter.PrintLine("$" + bb.Price + " " + bb.Name);
                }
                else if (item is DoubleDraugr dd)
                {
                    RecieptPrinter.PrintLine("$" + dd.Price + " " + dd.Name);
                }
                else if (item is GardenOrcOmelette goo)
                {
                    RecieptPrinter.PrintLine("$" + goo.Price + " " + goo.Name);
                }
                else if (item is PhillyPoacher pp)
                {
                    RecieptPrinter.PrintLine("$" + pp.Price + " " + pp.Name);
                }
                else if (item is SmokehouseSkeleton sms)
                {
                    RecieptPrinter.PrintLine("$" + sms.Price + " " + sms.Name);
                }
                else if (item is ThalmorTriple tt)
                {
                    RecieptPrinter.PrintLine("$" + tt.Price + " " + tt.Name);
                }
                else if (item is ThugsTBone ttb)
                {
                    RecieptPrinter.PrintLine("$" + ttb.Price + " " + ttb.Name);
                }
                else if (item is DragonbornWaffleFries dwf)
                {
                    RecieptPrinter.PrintLine("$" + dwf.Price + " " + dwf.Name);
                }
                else if (item is FriedMiraak fm)
                {
                    RecieptPrinter.PrintLine("$" + fm.Price + " " + fm.Name);
                }
                else if (item is MadOtarGrits mog)
                {
                    RecieptPrinter.PrintLine("$" + mog.Price + " " + mog.Name);
                }
                else if (item is VokunSalad vs)
                {
                    RecieptPrinter.PrintLine("$" + vs.Price + " " + vs.Name);
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
            RecieptPrinter.PrintLine("Payment Method: Card");
            RecieptPrinter.PrintLine("Change: 0.00");
            RecieptPrinter.CutTape();
        }
    }
}
