using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return await database.Movies.ToListAsync();
        }

        // GET: api/Movies/{id}
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<IEnumerable<Movie>>> Get(int id)
        {
            Movie movie = await database.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null) 
                return NotFound();

            return new ObjectResult(movie);
        }

        // POST: api/Movies
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Movie>>> PostMovie(Movie movie)
        {
            if (movie == null)
                return BadRequest();

            database.Movies.Add(movie);
            await database.SaveChangesAsync();
            return Ok(movie);
        }

        // PUT: api/Movies
        [HttpPut]
        public async Task<ActionResult<IEnumerable<Movie>>> Put(Movie movie)
        {
            if (movie == null)
                return BadRequest();

            if (!database.Movies.Any(m => m.Id == movie.Id))
                return NotFound();

            database.Update(movie);
            await database.SaveChangesAsync();
            return Ok(movie);
        }

        // DELETE: api/Movies/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<Movie>>> Delete(int id)
        {
            Movie movie = database.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
                return NotFound();

            database.Movies.Remove(movie);
            await database.SaveChangesAsync();
            return NoContent();
        }
    }
}
