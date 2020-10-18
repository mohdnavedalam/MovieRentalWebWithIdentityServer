using MovieRentalWithIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MovieRentalWithIdentity.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomer();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.ID == id);
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomer() => new List<Customer>
        { 
            new Customer {ID = 1, Name = "Alam"},
            new Customer{ ID = 2, Name = "Naved"} 
        };
    }
}