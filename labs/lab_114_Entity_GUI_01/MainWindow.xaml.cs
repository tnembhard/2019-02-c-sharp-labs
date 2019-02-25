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

namespace lab_114_Entity_GUI_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>();        
        Customer customer;
        string CombiCity;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise ()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                List01.ItemsSource = customers;
                List01.DisplayMemberPath = "ContactName";
                
            }
            string[] city = new string[] { "London", "Paris", "Tokyo" };
            CombiName.ItemsSource = city;
        }

        private void List01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var name = "";
            customer = (Customer)List01.SelectedItem; 
            //name = customer.ContactName;
            TextName.Text = customer.ContactName;
            LabelCity.Content = customer.City;
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {                
                var customerToUpdate =
                db.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();                
                customerToUpdate.ContactName = TextName.Text;
                customerToUpdate.City = CombiCity;
                db.SaveChanges();
            }
        }

        private void CombiName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CombiCity = CombiName.SelectedItem.ToString();
        }
    }
}
