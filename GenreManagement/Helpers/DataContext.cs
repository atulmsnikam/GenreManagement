using GenreManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenreManagement.Helpers
{
    public class DataContext :DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}
