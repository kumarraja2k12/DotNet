using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.Movies
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public string ReleaseDate { get; set; }

        [Required]
        public string DateAdded { get; set; }

        [Required]
        public int NumberInStock { get; set; }
    }
}
