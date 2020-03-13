using Microsoft.EntityFrameworkCore.Migrations;

namespace Yahooストア.Migrations.RazorPagesProduct
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Thick = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Vertical = table.Column<int>(nullable: false),
                    Lid = table.Column<int>(nullable: false),
                    YahooModel = table.Column<string>(nullable: true),
                    FukuroinModel = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
