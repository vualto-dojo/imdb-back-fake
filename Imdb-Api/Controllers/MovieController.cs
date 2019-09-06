using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imdb.Api.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Imdb_Api.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var movies = _movieService.GetMoviesInRange(DateTime.Now.AddDays(-31), DateTime.Now);
            return Ok(movies);
        }
    }
}