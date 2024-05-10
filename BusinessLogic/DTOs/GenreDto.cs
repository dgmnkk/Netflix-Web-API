using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class GenreDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<MovieDto>? Movies { get; set; }
    }
}
