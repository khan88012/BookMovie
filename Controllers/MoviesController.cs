using BookMovie.Models;
using BookMovie.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMoviesService _movieService;

        public MoviesController( IMoviesService moviesService )
        {
            _movieService = moviesService;
        }

        [HttpGet(Name = "GetMovies")]
        public MoviesList Get()
        {
            return _movieService.GetMovies();
        }
    }
}
