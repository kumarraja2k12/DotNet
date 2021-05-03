using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models.Customers;
using Vidly.Models.Movies;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/random
        public IActionResult Random()
        {
            var movie = new Movie { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2"}
            };

            return View(new RandomMovieViewModel { Movie = movie, Customers = customers  });
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
        }
    }
}
