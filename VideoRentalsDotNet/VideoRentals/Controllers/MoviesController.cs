using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VideoRentals.Models;
using VideoRentals.ViewModels;

namespace VideoRentals.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /movies/random
        public IActionResult Random()
        {
            var movie = new MovieModel { Name = "The Blind side.." };
            var customers = new List<CustomerModel>
            {
                new CustomerModel { Name = "Ashok", Id= 1 },
                new CustomerModel { Name = "Sudhakar", Id = 2 } 
            };

            var model = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(model);
        }
    }
}
