using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Trailer { get; set; }
        public string Video { get; set; }
        public TimeSpan Duration { get; set; }
        public int Year { get; set; }
        public int Limit { get; set; }
        public decimal Rating { get; set; }
        public Genre? Genre { get; set; }
        public int GenreId { get; set; }
        public ICollection<Selection>? Selections { get; set; }
    }
}
