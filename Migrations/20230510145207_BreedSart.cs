using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CatBD.Migrations
{
    /// <inheritdoc />
    public partial class BreedSart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "breedCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adaptabiliti = table.Column<int>(type: "integer", nullable: false),
                    AttachmentTofamily = table.Column<int>(type: "integer", nullable: false),
                    GameActivity = table.Column<int>(type: "integer", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    GeneralHealth = table.Column<int>(type: "integer", nullable: false),
                    HairLoss = table.Column<int>(type: "integer", nullable: false),
                    FriendlinessForChildren = table.Column<int>(type: "integer", nullable: false),
                    FriendlyToDogs = table.Column<int>(type: "integer", nullable: false),
                    LoveForMeow = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breedCharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "famylies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FamylyName = table.Column<string>(type: "text", nullable: true),
                    IdCharacter = table.Column<int>(type: "integer", nullable: true),
                    IdInfo = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_famylies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "infoAboutTheBreeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryOfOrigin = table.Column<string>(type: "text", nullable: false),
                    LifeExpectancy = table.Column<string>(type: "text", nullable: false),
                    Size = table.Column<string>(type: "text", nullable: false),
                    Weight_kg = table.Column<int>(type: "integer", nullable: false),
                    CoatType = table.Column<string>(type: "text", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    Lifestyle = table.Column<string>(type: "text", nullable: false),
                    Group = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infoAboutTheBreeds", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "breedCharacteristics");

            migrationBuilder.DropTable(
                name: "famylies");

            migrationBuilder.DropTable(
                name: "infoAboutTheBreeds");
        }
    }
}
