using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Models.Customers;
using Vidly.Models.Movies;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private VidlyDbContext _context;

        public MoviesController(VidlyDbContext context)
        {
            _context = context;
        }

        public IActionResult MovieForm()
        {
            var model = new MovieViewModel
            {
                Genre = _context.Genre.ToList()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(MovieViewModel model)
        {
            if (model.Movie.Id == 0)
            {
                _context.Movies.Add(model.Movie);
            }
            else
            {
                var movieInDb =_context.Movies.Single(m => m.Id == model.Movie.Id);

                movieInDb.Name = model.Movie.Name;
                movieInDb.NumberInStock = model.Movie.NumberInStock;
                movieInDb.DateAdded = model.Movie.DateAdded;
                movieInDb.GenreId = model.Movie.GenreId;
            }

            try
            {
                _context.SaveChanges(); 

            } catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            

            return RedirectToAction("Index", "Movies");
        }

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

        public async Task<ActionResult> Index()
        {
            var movies = await _context.Movies.Include(m => m.Genre).ToListAsync();
            return View(movies);
        }

        public ActionResult MovieDetails(int? Id)
        {
            if (Id.HasValue)
            {
                var movie = _context.Movies
                    .Include(c => c.Genre)
                    .FirstOrDefault(m => m.Id == Id);

                var model = new MovieViewModel
                {
                    Movie = movie,
                    Genre = _context.Genre.ToList()
                };

                return View("MovieForm", model);
            }

            return NotFound();
        }
    }
}
