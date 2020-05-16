using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using CinemaTA.Models;
using CinemaTA.Services;

namespace CinemaTA.Services
{
    public class MovieServices
    {
        private readonly MoviesContext database;
        public MovieServices(MoviesContext context) => database = context;

        public async Task<ActionResult<IEnumerable<Movie>>> ReadMovies()
        {
            return await database.Movies.ToListAsync();
        }

        public async Task<ActionResult<IEnumerable<Movie>>> ReadSpecificMovie(int id)
        {
            Movie movie = await database.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
                return new ObjectResult(StatusCodes.Status404NotFound);

            return new ObjectResult(movie);
        }

        public async Task<ActionResult<IEnumerable<Movie>>> CreateNewMovie(Movie movie)
        {
            if (movie == null)
                return new ObjectResult(StatusCodes.Status400BadRequest);

            database.Movies.Add(movie);
            await database.SaveChangesAsync();
            return new ObjectResult(StatusCodes.Status200OK);
        }

        public async Task<ActionResult<IEnumerable<Movie>>> UpdateMovie(Movie movie)
        {
            if (movie == null)
                return new ObjectResult(StatusCodes.Status400BadRequest);

            if (!database.Movies.Any(m => m.Id == movie.Id))
                return new ObjectResult(StatusCodes.Status404NotFound);

            database.Update(movie);
            await database.SaveChangesAsync();
            return new ObjectResult(StatusCodes.Status200OK);
        }

        public async Task<ActionResult<IEnumerable<Movie>>> DeleteMovie(int id)
        {
            Movie movie = database.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
                return new ObjectResult(StatusCodes.Status404NotFound);

            database.Movies.Remove(movie);
            await database.SaveChangesAsync();
            return new ObjectResult(StatusCodes.Status204NoContent);
        }
    }
}