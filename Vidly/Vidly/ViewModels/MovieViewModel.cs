using System.Collections.Generic;
using Vidly.Models.Movies;

namespace Vidly.ViewModels
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }

        public Movie Movie { get; set; }
    }
}
