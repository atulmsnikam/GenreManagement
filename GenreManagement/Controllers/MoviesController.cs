using GenreManagement.Helpers;
using GenreManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        DataContext dataContext;
        public MoviesController(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }

        [HttpGet]
        public string Get(string InputGenre)
        {
            var movies = dataContext.Movies.Where(c => c.Genre == InputGenre).Select(c => new Movie{ ID = c.ID, Genre = c.Genre , ReleaseYear = c.ReleaseYear , Title =c.Title});
            return JsonConvert.SerializeObject(movies);
        }

    }
}
