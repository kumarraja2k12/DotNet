using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models.Customers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1,  Name = "Customer 1" },
                new Customer { Id = 2,  Name = "Customer 2" }
            };

            return View(customers);
        }
    }
}
