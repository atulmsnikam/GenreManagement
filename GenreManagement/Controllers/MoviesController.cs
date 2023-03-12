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
        public Response Get(string InputGenre)
        {
            var response = new Response();
            var returnMessage= string.Empty;
            try
            {
            if (string.IsNullOrEmpty(InputGenre))
                throw new Exception($"Input Genre is Null Or Empty !");

            var movies = dataContext.Movies.Where(c => c.Genre.ToLower().Trim() == InputGenre.ToLower().Trim()).Select(c => new Movie{ ID = c.ID, Genre = c.Genre , ReleaseYear = c.ReleaseYear , Title =c.Title});

            if (movies.Count() == 0)
                throw new Exception($"No Data Found for the input Genre !");

            response.Data= JsonConvert.SerializeObject(movies);
            response.Message = $"API Call Is Successful";
            response.Succeeded = true;
            }
            catch (Exception ex)
            {
                response.Succeeded = false;
                response.Message = $"API Call Failed Due To Error : {ex.Message}";
            }
            return response;
        }

    }
}
