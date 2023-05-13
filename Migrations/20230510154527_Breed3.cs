using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatBD.Migrations
{
    /// <inheritdoc />
    public partial class Breed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCharacter",
                table: "famylies");

            migrationBuilder.DropColumn(
                name: "IdInfo",
                table: "famylies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCharacter",
                table: "famylies",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInfo",
                table: "famylies",
                type: "integer",
                nullable: true);
        }
    }
}
