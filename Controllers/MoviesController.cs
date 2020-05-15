using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CinemaTA.Data;
using CinemaTA.Models;

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
                return MovieData.MockMovieList[id - 1];
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
                return "IDs don't match each other";

            try
            {
                MovieData.MockMovieList[id - 1] = movie;
                return "Movice changed successfully";
            }
            catch (Exception)
            {
                return "No movie with such ID";
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
