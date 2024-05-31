using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MovieSelection",
                columns: new[] { "MovieId", "SelectionId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieSelection",
                keyColumns: new[] { "MovieId", "SelectionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MovieSelection",
                keyColumns: new[] { "MovieId", "SelectionId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "MovieSelection",
                keyColumns: new[] { "MovieId", "SelectionId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MovieSelection",
                keyColumns: new[] { "MovieId", "SelectionId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "MovieSelection",
                keyColumns: new[] { "MovieId", "SelectionId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "MovieSelection",
                keyColumns: new[] { "MovieId", "SelectionId" },
                keyValues: new object[] { 4, 4 });
        }
    }
}
