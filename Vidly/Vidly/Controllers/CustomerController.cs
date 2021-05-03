using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models.Customers;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int Id)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1,  Name = "Customer 1" },
                new Customer { Id = 2,  Name = "Customer 2" }
            };

            var customer = customers.Where(customer => customer.Id == Id)?.FirstOrDefault();

            if (customer != null)
            {
                return View(customer);
            }

            return new NotFoundResult();
        }
    }
}
