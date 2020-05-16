using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CinemaTA.Models;
using CinemaTA.Services;

namespace CinemaTA.Controllers
{
    [ApiController]
    [Route("api/Movies")]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesContext database;
        public MoviesController(MoviesContext context) => database = context;

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Get()
        {
            return await new MovieServices(database).ReadMovies();
        }

        // GET: api/Movies/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Movie>>> Get(int id)
        {
            return await new MovieServices(database).ReadSpecificMovie(id);
        }

        // POST: api/Movies
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Movie>>> PostMovie(Movie movie)
        {
            return await new MovieServices(database).CreateNewMovie(movie);
        }

        // PUT: api/Movies
        [HttpPut]
        public async Task<ActionResult<IEnumerable<Movie>>> Put(Movie movie)
        {
            return await new MovieServices(database).UpdateMovie(movie);
        }

        // DELETE: api/Movies/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<Movie>>> Delete(int id)
        {
            return await new MovieServices(database).DeleteMovie(id);
        }
    }
}
