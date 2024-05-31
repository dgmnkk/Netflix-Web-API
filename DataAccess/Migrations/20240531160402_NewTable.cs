using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieSelection_Movies_MoviesId",
                table: "MovieSelection");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSelection_Selections_SelectionsId",
                table: "MovieSelection");

            migrationBuilder.RenameColumn(
                name: "SelectionsId",
                table: "MovieSelection",
                newName: "SelectionId");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "MovieSelection",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieSelection_SelectionsId",
                table: "MovieSelection",
                newName: "IX_MovieSelection_SelectionId");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Trailer", "Video" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg", "https://www.youtube.com/embed/YoHD9XEInc0?si=opW8GH5IUHDsAC3B", "https://www.youtube.com/embed/YoHD9XEInc0?si=opW8GH5IUHDsAC3B" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Trailer", "Video" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg", "https://www.youtube.com/embed/EXeTwQWrcwY?si=hddCS66gMkU1nVQc", "https://www.youtube.com/embed/EXeTwQWrcwY?si=hddCS66gMkU1nVQc" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Trailer", "Video" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg", "https://www.youtube.com/embed/UaVTIH8mujA?si=yzboJoRqQfriwnTr", "https://www.youtube.com/embed/UaVTIH8mujA?si=yzboJoRqQfriwnTr" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Trailer", "Video" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMDU2ZWJlMjktMTRhMy00ZTA5LWEzNDgtYmNmZTEwZTViZWJkXkEyXkFqcGdeQXVyNDQ2OTk4MzI@._V1_.jpg", "https://www.youtube.com/embed/CxwTLktovTU?si=1AQilNCmR71uFVpH", "https://www.youtube.com/embed/CxwTLktovTU?si=1AQilNCmR71uFVpH" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSelection_Movies_MovieId",
                table: "MovieSelection",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSelection_Selections_SelectionId",
                table: "MovieSelection",
                column: "SelectionId",
                principalTable: "Selections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieSelection_Movies_MovieId",
                table: "MovieSelection");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSelection_Selections_SelectionId",
                table: "MovieSelection");

            migrationBuilder.RenameColumn(
                name: "SelectionId",
                table: "MovieSelection",
                newName: "SelectionsId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "MovieSelection",
                newName: "MoviesId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieSelection_SelectionId",
                table: "MovieSelection",
                newName: "IX_MovieSelection_SelectionsId");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Trailer", "Video" },
                values: new object[] { "https://example.com/images/inception.jpg", "https://example.com/trailers/inception.mp4", "https://example.com/videos/inception.mp4" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Trailer", "Video" },
                values: new object[] { "https://example.com/images/darkknight.jpg", "https://example.com/trailers/darkknight.mp4", "https://example.com/videos/darkknight.mp4" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Trailer", "Video" },
                values: new object[] { "https://example.com/images/godfather.jpg", "https://example.com/trailers/godfather.mp4", "https://example.com/videos/godfather.mp4" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Trailer", "Video" },
                values: new object[] { "https://example.com/images/toystory.jpg", "https://example.com/trailers/toystory.mp4", "https://example.com/videos/toystory.mp4" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSelection_Movies_MoviesId",
                table: "MovieSelection",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSelection_Selections_SelectionsId",
                table: "MovieSelection",
                column: "SelectionsId",
                principalTable: "Selections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
