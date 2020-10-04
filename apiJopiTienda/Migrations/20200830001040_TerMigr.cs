using Microsoft.EntityFrameworkCore.Migrations;

namespace apiJopiTienda.Migrations
{
    public partial class TerMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartHist",
                columns: table => new
                {
                    Sku = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    OrderId = table.Column<string>(nullable: true),
                    OrdenId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartHist", x => x.Sku);
                    table.ForeignKey(
                        name: "FK_CartHist_Ordenes_OrdenId",
                        column: x => x.OrdenId,
                        principalTable: "Ordenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartHist_OrdenId",
                table: "CartHist",
                column: "OrdenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartHist");
        }
    }
}
