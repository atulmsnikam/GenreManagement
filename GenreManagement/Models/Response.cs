using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenreManagement.Models
{
    public sealed class Response
    {
        public bool Succeeded { get; set; }
        public string Data {get; set; }
        public string Message { get; set; }

    }
}
