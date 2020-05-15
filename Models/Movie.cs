using System.ComponentModel.DataAnnotations;

namespace CinemaTA.Models
{
    public class Movie
    {
        [Key]
        public uint Id { get; private set; }
        [Required]
        public string Title { get; private set; }
        [Required]
        public string Director { get; private set; }
        [Required]
        public uint ReleaseYear { get; private set; }

        // This field is used for providing correct IDs without user interaction.
        // Basically, replaces autoincrement ID functionality available in most databases
        private static uint movieCounter;

        public Movie() { }
        static Movie() => movieCounter = 0;
        public Movie(string title, string director, uint releaseYear)
        {
            movieCounter++;
            this.Id = movieCounter;
            this.Title = title;
            this.Director = director;
            this.ReleaseYear = releaseYear;
        }
    }
}