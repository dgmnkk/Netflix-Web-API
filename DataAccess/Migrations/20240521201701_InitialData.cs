using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Comedy" },
                    { 3, "Drama" },
                    { 4, "Horror" },
                    { 5, "Sci-Fi" },
                    { 6, "Documentary" },
                    { 7, "Romance" },
                    { 8, "Thriller" },
                    { 9, "Fantasy" },
                    { 10, "Cartoon" }
                });

            migrationBuilder.InsertData(
                table: "Selections",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Top Picks for You" },
                    { 2, "Trending Now" },
                    { 3, "New Releases" },
                    { 4, "Critically Acclaimed" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Duration", "GenreId", "Image", "Limit", "Rating", "Title", "Trailer", "Video", "Year" },
                values: new object[,]
                {
                    { 1, "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", new TimeSpan(0, 2, 28, 0, 0), 5, "https://example.com/images/inception.jpg", 13, 8.8m, "Inception", "https://example.com/trailers/inception.mp4", "https://example.com/videos/inception.mp4", 2010 },
                    { 2, "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new TimeSpan(0, 2, 32, 0, 0), 1, "https://example.com/images/darkknight.jpg", 13, 9.0m, "The Dark Knight", "https://example.com/trailers/darkknight.mp4", "https://example.com/videos/darkknight.mp4", 2008 },
                    { 3, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", new TimeSpan(0, 2, 55, 0, 0), 3, "https://example.com/images/godfather.jpg", 17, 9.2m, "The Godfather", "https://example.com/trailers/godfather.mp4", "https://example.com/videos/godfather.mp4", 1972 },
                    { 4, "A cowboy doll is profoundly threatened and jealous when a new spaceman figure supplants him as top toy in a boy's room.", new TimeSpan(0, 1, 21, 0, 0), 10, "https://example.com/images/toystory.jpg", 0, 8.3m, "Toy Story", "https://example.com/trailers/toystory.mp4", "https://example.com/videos/toystory.mp4", 1995 }
                });

            migrationBuilder.InsertData(
                table: "MovieSelection",
                columns: new[] { "MoviesId", "SelectionsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieSelection",
                keyColumns: new[] { "MoviesId", "SelectionsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MovieSelection",
                keyColumns: new[] { "MoviesId", "SelectionsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MovieSelection",
                keyColumns: new[] { "MoviesId", "SelectionsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MovieSelection",
                keyColumns: new[] { "MoviesId", "SelectionsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Selections",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Selections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Selections",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Selections",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
