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
using System.Data.Entity;

namespace lab_117_entity_tabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Customer customer;
        Order order;
        Order_Detail detail;
        Product product;
        List<Order> orders = new List<Order>(); 
        List<Order_Detail> details = new List<Order_Detail>();
        List<Product> products = new List<Product>();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            
            using (var db = new NorthwindEntities())
            {                
                ListBox01.ItemsSource = db.Customers.ToList<Customer>();
                ListBox01.DisplayMemberPath = "ContactName";
            }
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)ListBox01.SelectedItem;
            using (var db = new NorthwindEntities())
            {   
                orders = db.Orders.Where(order=>order.CustomerID == customer.CustomerID).ToList<Order>();
                ListBox02.ItemsSource = orders;
            }

        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ListBox01.ItemsSource = null;
            
            order = (Order)ListBox02.SelectedItem;
            using (var db = new NorthwindEntities())
            {
                details = db.Order_Details.Where(details => details.OrderID == order.OrderID).ToList<Order_Detail>();
                ListBox03.ItemsSource = details;
            }

        }

        private void ListBox03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            detail = (Order_Detail)ListBox03.SelectedItem;
            using (var db = new NorthwindEntities())
            {                
                products = db.Products.Where(product => product.ProductID == detail.ProductID).ToList<Product>();
                ListBox04.ItemsSource = products;           
            }
        }

        private void ListBox04_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            product = (Product)ListBox04.SelectedItem;
        }

        private void ButtonTab_Click(object sender, RoutedEventArgs e)
        {
            var window2 = new WindowAddCustomer();
            window2.Show();
        }
    }
}
