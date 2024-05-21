using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class CreateMovieModel
    {
        public string Title { get; set; }   
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public string Trailer { get; set; }
        public string Video { get; set; }
        public TimeSpan Duration { get; set; }
        public int Year {  get; set; }
        public int Limit { get; set; }
        public decimal Rating { get; set; }
        public int GenreId { get; set; }
    }
}
