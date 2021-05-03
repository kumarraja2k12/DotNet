using System.Collections.Generic;
using Vidly.Models.Customers;
using Vidly.Models.Movies;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
