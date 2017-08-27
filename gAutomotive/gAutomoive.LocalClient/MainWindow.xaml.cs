using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using gAutomotive.DAL;
using gAutomotive.DAL.Repository;

namespace gAutomoive.LocalClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IEnumerable<Customer> customers;
        public MainWindow()
        {
            InitializeComponent();
        }

        gautomotiveEntities a = new gautomotiveEntities();
        private async void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {

            var result = await a.Customers.ToListAsync();
            Set(result);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var obj = this.phonetext.Text;
            IEnumerable<Customer> query = this.customers.ToList();
            if (obj != null)
            {
                query = query.Where(x => x.CustomerTelephone == obj);
            }
            query = query.ToList();
            Set(query);
        }

        private void Set(IEnumerable<Customer> customers)
        {
            this.customers = customers;
            DataGrid.ItemsSource = customers;
        }

        private async void button3_Click(object sender, RoutedEventArgs e)
        {
            var result = await a.Customers.ToListAsync();
            Set(result);
        }

        private async void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            // save edit
            var customer = new Customer()
            {
                CustomerName = customerNameTextBox1.Text,
                CustomerTelephone = this.customerNameTextBox1.Text,
                DetailCode = detailCodeTextBox1.Text,
                Mark = this.markTextBox1.Text,
                DetailReplaceCode = this.detailCodeTextBox1.Text,
                OrderAcceptanceDate = this.orderAcceptanceDateDatePicker1.SelectedDate,
                OrderSellDate = this.orderSellDateDatePicker1.SelectedDate,
                OriginalPrice = decimal.Parse(this.originalPriceTextBox1.Text),
                SellPrice = decimal.Parse(this.sellPriceTextBox1.Text),
                WIN = this.wINTextBox1.Text,
                Weight_KG = int.Parse(this.weight_KGTextBox1.Text)
            };

            customer.Profit = customer.SellPrice - customer.OriginalPrice;

            if (customer.Profit < 0)
            {
                this.profitTextBox1.Background = Brushes.Red;
            }
            else
                this.profitTextBox1.Background = Brushes.Green;
            this.profitTextBox1.Text = customer.Profit.Value.ToString();

            IGAutomotive a = new GAutomotive();
            await a.AddCustomer(customer);
            MessageBox.Show("ok");
            button3_Click(null, null);
        }

        private void OriginalPriceTextBox1_OnTextChanged(object sender, TextChangedEventArgs e) { }
    }
}
