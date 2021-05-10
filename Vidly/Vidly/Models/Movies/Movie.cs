using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.Movies
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public string ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        [Required]
        public string DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        public int NumberInStock { get; set; }
    }
}
