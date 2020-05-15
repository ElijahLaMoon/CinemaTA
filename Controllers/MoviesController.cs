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

        [HttpPost]
        public void PostMovie(Movie movie)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, Movie movie)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
