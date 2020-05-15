using System.Collections.Generic;
using CinemaTA.Models;

namespace CinemaTA.Data
{
    public static class MovieData
    {
        public static List<Movie> MockMovieList = new List<Movie>();

        /// <summary>
        /// Fills MockMovieListdata with basic data
        /// </summary>
        static MovieData()
        {
            MockMovieList.Add(new Movie("The Irishman", "Martin Scorcese", 2019));
            MockMovieList.Add(new Movie("Joker", "Todd Phillips", 2019));
            MockMovieList.Add(new Movie("The Wolf of Wall Street", "Martin Scorcese", 2013));
        }
    }
}
