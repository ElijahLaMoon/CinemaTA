using Microsoft.AspNetCore.Mvc;
using CinemaTA.Models;

namespace CinemaTA.Controllers
{
    [Route("api/Movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {
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
