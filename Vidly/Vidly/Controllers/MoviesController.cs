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
                return View(movie);
            }

            return NotFound();
        }
    }
}
