using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalPojects.Data.Migrations
{
    /// <inheritdoc />
    public partial class mmm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScientificName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PharmaceuticalForm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToUse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageSize = table.Column<int>(type: "int", nullable: false),
                    LegalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistributeArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicPrice = table.Column<float>(type: "real", nullable: false),
                    StorageConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarktingCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicine");
        }
    }
}
