using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

            builder.Entity<Selection>().HasData(new[]
            {
            new Selection { Id = 1, Title = "Top Picks for You" },
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
                Image = "https://example.com/images/inception.jpg",
                Trailer = "https://example.com/trailers/inception.mp4",
                Video = "https://example.com/videos/inception.mp4",
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
                Image = "https://example.com/images/darkknight.jpg",
                Trailer = "https://example.com/trailers/darkknight.mp4",
                Video = "https://example.com/videos/darkknight.mp4",
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
                Image = "https://example.com/images/godfather.jpg",
                Trailer = "https://example.com/trailers/godfather.mp4",
                Video = "https://example.com/videos/godfather.mp4",
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
                Image = "https://example.com/images/toystory.jpg",
                Trailer = "https://example.com/trailers/toystory.mp4",
                Video = "https://example.com/videos/toystory.mp4",
                Duration = new TimeSpan(1, 21, 0),
                Year = 1995,
                Limit = 0,
                Rating = 8.3m,
                GenreId = 10
            }
        });

            builder.Entity<Selection>()
                .HasMany(s => s.Movies)
                .WithMany(m => m.Selections)
                .UsingEntity(j => j.HasData(
                    new { SelectionsId = 1, MoviesId = 1 },
                    new { SelectionsId = 1, MoviesId = 2 },
                    new { SelectionsId = 2, MoviesId = 3 },
                    new { SelectionsId = 3, MoviesId = 4 }
                ));
        }
    }
}
