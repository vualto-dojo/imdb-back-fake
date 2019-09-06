using System;
using System.Collections.Generic;
using System.Text;
using Imdb.Api.Service.Models;

namespace Imdb.Api.Service.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetMovieByTitle(string title);
        Movie GetMovieById(Guid id);
        IEnumerable<Movie> GetMoviesInRange(DateTime from, DateTime to);
    }
}
