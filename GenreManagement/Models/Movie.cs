using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenreManagement.Models
{
    public sealed class Movie
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string ReleaseYear { get; set; }

    }
}
