using System.Collections.Generic;
using VideoRentals.Models;

namespace VideoRentals.ViewModels
{
    public class RandomMovieViewModel
    {
        public MovieModel Movie { get; set; }

        public List<CustomerModel> Customers { get; set; }
    }
}
