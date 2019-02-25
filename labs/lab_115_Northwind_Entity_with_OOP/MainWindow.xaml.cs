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

namespace lab_115_Northwind_Entity_with_OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /* Read Customers and (cast) to ActiveCustomers and get IsActive to true for all customer

            Create 2 list boxes and radio button to enable/disable our ActiveCustomer

            Click on Customer to select and display all details on screen (TextBlock, StackPanel, ListBox2)

            When you click on Enable/Disable Toggle button the IsActive changes (toggles) state

            First listbox = only for ACTIVE CUSTOMERS

            State becomes inactive =⇒ remove from first listbox

            Second listbox = only for INACTIVE CUSTOMERS

            inactive state : remove from first but add to second listbox

            Reverse the process ie click on INACTIVE CUSTOMER (second listbox)

            you can then toggle the state back to enabled (use the radio/toggle button). Removed from INACTIVE and add back to ACTIVE list.
            */
    }
}
