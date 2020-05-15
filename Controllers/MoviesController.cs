using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CinemaTA.Data;
using CinemaTA.Models;
using System.Linq;

namespace CinemaTA.Controllers
{
    [Route("api/Movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // GET: api/Movies
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            foreach (var movie in MovieData.MockMovieList)
            {
                yield return movie;
            }
        }

        // GET: api/Movies/{id}
        [HttpGet("{id}", Name = "Get")]
        public Movie Get(int id)
        {
            try
            {
                return MovieData.MockMovieList.Where(m => m.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // POST: api/Movies
        [HttpPost]
        public string PostMovie(Movie movie)
        {
            MovieData.MockMovieList.Add(movie);

            return "Movie posted successfully";
        }

        // PUT: api/Movies/{id}
        [HttpPut("{id}")]
        public string Put(int id, Movie movie)
        {
            if (id != movie.Id)
                return "Provided IDs don't match each other";

            var movieToChange = MovieData.MockMovieList.Where(m => m.Id == id).FirstOrDefault();
            if (movieToChange == null)
                return "No movie with such ID";
            else
            {
                var index = MovieData.MockMovieList.IndexOf(movieToChange);
                MovieData.MockMovieList[index] = movie;
                return "Movice changed successfully";
            }
        }

        // DELETE: api/Movies/{id}
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            var movieToDelete = MovieData.MockMovieList.Where(m => m.Id == id).FirstOrDefault();
            if (movieToDelete == null) 
                return "No movie with such id";
            else
            {
                MovieData.MockMovieList.Remove(movieToDelete);
                return "Movie deleted successfully";
            }
        }
    }
}
