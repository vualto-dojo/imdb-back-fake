using System;
using System.Collections.Generic;
using System.Text;
using Imdb.Api.Service.Interfaces;
using Imdb.Api.Service.Models;

namespace Imdb.Api.Service
{
    public class MovieService : IMovieService
    {
        public IEnumerable<Movie> GetMovieByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMoviesInRange(DateTime @from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}
