using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatBD.Migrations
{
    /// <inheritdoc />
    public partial class Breed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharacteristicId",
                table: "famylies",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InformationId",
                table: "famylies",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_famylies_CharacteristicId",
                table: "famylies",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_famylies_InformationId",
                table: "famylies",
                column: "InformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_famylies_breedCharacteristics_CharacteristicId",
                table: "famylies",
                column: "CharacteristicId",
                principalTable: "breedCharacteristics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_famylies_infoAboutTheBreeds_InformationId",
                table: "famylies",
                column: "InformationId",
                principalTable: "infoAboutTheBreeds",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_famylies_breedCharacteristics_CharacteristicId",
                table: "famylies");

            migrationBuilder.DropForeignKey(
                name: "FK_famylies_infoAboutTheBreeds_InformationId",
                table: "famylies");

            migrationBuilder.DropIndex(
                name: "IX_famylies_CharacteristicId",
                table: "famylies");

            migrationBuilder.DropIndex(
                name: "IX_famylies_InformationId",
                table: "famylies");

            migrationBuilder.DropColumn(
                name: "CharacteristicId",
                table: "famylies");

            migrationBuilder.DropColumn(
                name: "InformationId",
                table: "famylies");
        }
    }
}
