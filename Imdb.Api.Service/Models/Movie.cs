using System;
using System.Collections.Generic;
using System.Text;

namespace Imdb.Api.Service.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
    }
}
