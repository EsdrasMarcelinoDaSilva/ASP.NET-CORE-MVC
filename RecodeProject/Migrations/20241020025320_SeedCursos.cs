using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecodeProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedCursos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "ID", "Description", "Workload" },
                values: new object[,]
                {
                    { 1, "Asp Net MVC", 40 },
                    { 2, "Banco de Dados", 30 },
                    { 3, "React", 60 },
                    { 4, "HTML e CSS", 20 },
                    { 5, "C#", 50 },
                    { 6, "Python", 45 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
