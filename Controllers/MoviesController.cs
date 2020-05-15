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

        [HttpGet("{id}", Name = "Get")]
        public void Get(int id)
        {
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
