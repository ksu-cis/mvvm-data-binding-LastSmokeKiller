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
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        public CoinControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows binding
        /// </summary>
        public static readonly DependencyProperty
            DenominationProperty = DependencyProperty.Register("Denomination",
                    typeof(Coins), typeof(CoinControl), new PropertyMetadata(Coins.Penny));

        /// <summary>
        /// The denomination for the coin
        /// </summary>
        public Coins Denomination
        {
            get { return (Coins)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// The Dependency for the Quantity Property
        /// </summary>
        public static readonly DependencyProperty QuantityProperty = DependencyProperty.Register("Quantity",
            typeof(int), typeof(CoinControl), new FrameworkPropertyMetadata(0,
                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// The number of coins in the denomination
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        /// <summary>
        /// Adds a coin
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="args"> click </param>
        public void OnAddClicked(object sender, RoutedEventArgs args)
        {
            Quantity++;
        }

        /// <summary>
        /// Takes a coin away
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="args"> click </param>
        public void OnRemoveClicked(object sender, RoutedEventArgs args)
        {
            Quantity--;
        }
    }
}
