﻿using Ardalis.Specification;
using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BusinessLogic.Specifications
{
    public static class MovieSpecs
    {
        public class All : Specification<Movie>
        {
            public All()
            {
                Query.Include(x => x.Genre).Include(x => x.MovieSelection);
            }
        }
        public class ById : Specification<Movie>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x => x.Genre).Include(x => x.MovieSelection);
            }
        }
        public class ByIds : Specification<Movie>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.Genre).Include(x => x.MovieSelection);
            }
        }

        public class ByGenre : Specification<Movie>
        {
            public ByGenre(int genreId)
            {
                Query
                    .Where(x => x.GenreId == genreId)
                    .Include(x => x.Genre).Include(x => x.MovieSelection);
            }
        }

        public class BySelection : Specification<Movie>
        {
            public BySelection(int selectionId)
            {
                Query
                    .Where(movie => movie.MovieSelection.Any(ms => ms.SelectionId == selectionId))
                    .Include(movie => movie.Genre)
                    .Include(movie => movie.MovieSelection);
            }
        }
    }
}
