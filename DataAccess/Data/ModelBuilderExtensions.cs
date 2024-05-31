using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Genre>().HasData(new[]
            {
            new Genre { Id = 1, Title = "Action" },
            new Genre { Id = 2, Title = "Comedy" },
            new Genre { Id = 3, Title = "Drama" },
            new Genre { Id = 4, Title = "Horror" },
            new Genre { Id = 5, Title = "Sci-Fi" },
            new Genre { Id = 6, Title = "Documentary" },
            new Genre { Id = 7, Title = "Romance" },
            new Genre { Id = 8, Title = "Thriller" },
            new Genre { Id = 9, Title = "Fantasy" },
            new Genre { Id = 10, Title = "Cartoon" }
        });

            builder.Entity<MovieSelection>().HasData(new[]
            {
                new MovieSelection{ MovieId= 1, SelectionId= 1 },
                new MovieSelection{MovieId= 1, SelectionId = 4},
                new MovieSelection{ MovieId= 2, SelectionId= 2},
                new MovieSelection{MovieId= 3, SelectionId= 3},
                new MovieSelection{MovieId= 3, SelectionId = 4},
                new MovieSelection{MovieId= 4, SelectionId= 4}
            });

            builder.Entity<Selection>().HasData(new[]
            {
            new Selection { Id = 1, Title = "Top Picks for You"},
            new Selection { Id = 2, Title = "Trending Now" },
            new Selection { Id = 3, Title = "New Releases" },
            new Selection { Id = 4, Title = "Critically Acclaimed" }
        });

            
            builder.Entity<Movie>().HasData(new[]
            {
            new Movie
            {
                Id = 1,
                Title = "Inception",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                Image = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg",
                Trailer = "https://www.youtube.com/embed/YoHD9XEInc0?si=opW8GH5IUHDsAC3B",
                Video = "https://www.youtube.com/embed/YoHD9XEInc0?si=opW8GH5IUHDsAC3B",
                Duration = new TimeSpan(2, 28, 0),
                Year = 2010,
                Limit = 13,
                Rating = 8.8m,
                GenreId = 5
            },
            new Movie
            {
                Id = 2,
                Title = "The Dark Knight",
                Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                Image = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg",
                Trailer = "https://www.youtube.com/embed/EXeTwQWrcwY?si=hddCS66gMkU1nVQc",
                Video = "https://www.youtube.com/embed/EXeTwQWrcwY?si=hddCS66gMkU1nVQc",
                Duration = new TimeSpan(2, 32, 0),
                Year = 2008,
                Limit = 13,
                Rating = 9.0m,
                GenreId = 1
            },
            new Movie
            {
                Id = 3,
                Title = "The Godfather",
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                Image = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                Trailer = "https://www.youtube.com/embed/UaVTIH8mujA?si=yzboJoRqQfriwnTr",
                Video = "https://www.youtube.com/embed/UaVTIH8mujA?si=yzboJoRqQfriwnTr",
                Duration = new TimeSpan(2, 55, 0),
                Year = 1972,
                Limit = 17,
                Rating = 9.2m,
                GenreId = 3
            },
            new Movie
            {
                Id = 4,
                Title = "Toy Story",
                Description = "A cowboy doll is profoundly threatened and jealous when a new spaceman figure supplants him as top toy in a boy's room.",
                Image = "https://m.media-amazon.com/images/M/MV5BMDU2ZWJlMjktMTRhMy00ZTA5LWEzNDgtYmNmZTEwZTViZWJkXkEyXkFqcGdeQXVyNDQ2OTk4MzI@._V1_.jpg",
                Trailer = "https://www.youtube.com/embed/CxwTLktovTU?si=1AQilNCmR71uFVpH",
                Video = "https://www.youtube.com/embed/CxwTLktovTU?si=1AQilNCmR71uFVpH",
                Duration = new TimeSpan(1, 21, 0),
                Year = 1995,
                Limit = 0,
                Rating = 8.3m,
                GenreId = 10
            }
        });
        }
    }
}
