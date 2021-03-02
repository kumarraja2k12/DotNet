using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VideoRentals.Models;
using VideoRentals.ViewModels;

namespace VideoRentals.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index(int? Id)
        {
            List<MovieModel> movies = new List<MovieModel>
            {
                new MovieModel { Id =1,  Name = "Shrek !" },
                new MovieModel { Id =2, Name = "Wall-E" }
            };

            if (Id.HasValue)
            {
                if (movies.Select(m => m.Id == Id)?.Count() > 0)
                {
                    return View(movies.Where(m => m.Id == Id).ToList());
                }
            }

            return View(movies);
        }

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
