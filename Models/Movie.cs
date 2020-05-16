using System.ComponentModel.DataAnnotations;

namespace CinemaTA.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public uint ReleaseYear { get; set; }
    }
}