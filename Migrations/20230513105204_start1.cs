using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatBD.Migrations
{
    /// <inheritdoc />
    public partial class start1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_breedCharacteristics_famylies_famylyId",
                table: "breedCharacteristics");

            migrationBuilder.DropForeignKey(
                name: "FK_infoAboutTheBreeds_famylies_famylyId",
                table: "infoAboutTheBreeds");

            migrationBuilder.RenameColumn(
                name: "famylyId",
                table: "infoAboutTheBreeds",
                newName: "FamylyId");

            migrationBuilder.RenameIndex(
                name: "IX_infoAboutTheBreeds_famylyId",
                table: "infoAboutTheBreeds",
                newName: "IX_infoAboutTheBreeds_FamylyId");

            migrationBuilder.RenameColumn(
                name: "famylyId",
                table: "breedCharacteristics",
                newName: "FamylyId");

            migrationBuilder.RenameIndex(
                name: "IX_breedCharacteristics_famylyId",
                table: "breedCharacteristics",
                newName: "IX_breedCharacteristics_FamylyId");

            migrationBuilder.AddForeignKey(
                name: "FK_breedCharacteristics_famylies_FamylyId",
                table: "breedCharacteristics",
                column: "FamylyId",
                principalTable: "famylies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_infoAboutTheBreeds_famylies_FamylyId",
                table: "infoAboutTheBreeds",
                column: "FamylyId",
                principalTable: "famylies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_breedCharacteristics_famylies_FamylyId",
                table: "breedCharacteristics");

            migrationBuilder.DropForeignKey(
                name: "FK_infoAboutTheBreeds_famylies_FamylyId",
                table: "infoAboutTheBreeds");

            migrationBuilder.RenameColumn(
                name: "FamylyId",
                table: "infoAboutTheBreeds",
                newName: "famylyId");

            migrationBuilder.RenameIndex(
                name: "IX_infoAboutTheBreeds_FamylyId",
                table: "infoAboutTheBreeds",
                newName: "IX_infoAboutTheBreeds_famylyId");

            migrationBuilder.RenameColumn(
                name: "FamylyId",
                table: "breedCharacteristics",
                newName: "famylyId");

            migrationBuilder.RenameIndex(
                name: "IX_breedCharacteristics_FamylyId",
                table: "breedCharacteristics",
                newName: "IX_breedCharacteristics_famylyId");

            migrationBuilder.AddForeignKey(
                name: "FK_breedCharacteristics_famylies_famylyId",
                table: "breedCharacteristics",
                column: "famylyId",
                principalTable: "famylies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_infoAboutTheBreeds_famylies_famylyId",
                table: "infoAboutTheBreeds",
                column: "famylyId",
                principalTable: "famylies",
                principalColumn: "Id");
        }
    }
}
