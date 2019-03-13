using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_35_ASP_core_entity_web.Models;

namespace lab_35_ASP_core_entity_web.Pages
{
    public class CustomersModel : PageModel
    {
        private Northwind db;
        public IEnumerable<Customer> customers;
        [BindProperty]
        public Customer customer { get; set; }
		public CustomersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        // HTTP GET REQUEST
        public void OnGet()
        {
            ViewData["Title"] = "List of Northwind Cutsomers";
            customers = db.Customers.ToList();
        }

        // HTTP POST
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToPage("/Customers");            
            }
            return Page();
        }
    }
}