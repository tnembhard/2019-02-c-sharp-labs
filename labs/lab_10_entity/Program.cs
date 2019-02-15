using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace lab_10_entity
{
    class Program
    {
        // static
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {


            // Insert new customer
            using (var db = new NorthwindEntities())
            {
                Customer customerToCreate = new Customer
                {
                    CustomerID = "PHIL6",
                    ContactName = "Something Awesome",
                    City = "Some where",
                    CompanyName = "Nexon"
                };
                //Now add new customer to local database
                db.Customers.Add(customerToCreate);
                //write changes permanently to real database
                db.SaveChanges();
            }            

            // CRUD Create Read Update Delete

            // select one customer

            using (var db = new NorthwindEntities())
            {
                //LINQ query : Microsoft : Language Independant Query
                var customerToUpdate =
                    // select all customers in Northwind
                    (from customer in db.Customers
                         // choose one where ID matches
                     where customer.CustomerID == "PHIL"
                     // output this one selected
                     select customer).FirstOrDefault();
                Console.WriteLine("\n\nFinding one customer");
                Console.WriteLine($"{customerToUpdate.ContactName}" + $" lives in {customerToUpdate.City}");
            }
            // have a loop at customers after INSERT and UPDATE
            DisplayAll();

            // Update
            using (var db = new NorthwindEntities())
            {
                //LINQ query : Microsoft : Language Independant Query
                var customerToUpdate =
                   db.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault();
                Console.WriteLine("\n\nFinding one customer");
                Console.WriteLine($"{customerToUpdate.ContactName}" + $" lives in {customerToUpdate.City}");

                // Update customer
                customerToUpdate.ContactName = "Fred Flintstone";
                customerToUpdate.City = "Bedrock";
                // Update DB permently
                db.SaveChanges();
            }

            // have a loop at customers after INSERT and UPDATE
            DisplayAll();

            // delete
            using (var db = new NorthwindEntities())
            {
                var customerToDelete = db.Customers.Where(c => c.CustomerID == "PHIL6").FirstOrDefault();
                db.Customers.Remove(customerToDelete);
                db.SaveChanges();
            }

            // have a loop at customers DELETE
            DisplayAll();

        }

        static void DisplayAll()
        {
            // encapsulates database connection so itdcloded cleanly
            using (var db = new NorthwindEntities())
            {
                // customers list = (read from northwind) 
                // (pull out all cutstomers)
                // (send to list of customers)
                customers = db.Customers.ToList<Customer>();
            }

            // use list!!!
            foreach (var customer in customers)
            {
                Console.WriteLine($"{ customer.ContactName} has ID" + $"{customer.CustomerID} from {customer.City}");
            }
        }
    }
}
