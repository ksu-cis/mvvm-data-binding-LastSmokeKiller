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
using CashRegister;

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        public BillControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The DependencyProperty for the Denomination Property
        /// </summary>
        public static readonly DependencyProperty
            DenominationProperty = DependencyProperty.Register("Denomination",
                    typeof(Bills), typeof(BillControl), new PropertyMetadata(Bills.One));

        /// <summary>
        /// The Denomination for the bills
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// The DependencyProperty for the QuantityProperty
        /// </summary>
        public static readonly DependencyProperty QuantityProperty = DependencyProperty.Register("Quantity",
            typeof(int), typeof(BillControl), new FrameworkPropertyMetadata(0,
                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// The quantity of bills in the denomination
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        /// <summary>
        /// Adds a bill
        /// </summary>
        /// <param name="sender"> button </param>
        /// <param name="args"> click </param>
        public void OnAddClicked(object sender, RoutedEventArgs args)
        {
            Quantity++;
        }

        /// <summary>
        /// Takes a bill away
        /// </summary>
        /// <param name="sender"> button </param>
        /// <param name="args"> click </param>
        public void OnRemoveClicked(object sender, RoutedEventArgs args)
        {
            Quantity--;
        }
    }
}
