using Microsoft.EntityFrameworkCore.Migrations;

namespace apiJopiTienda.Migrations
{
    public partial class SecMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartHist");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartHist",
                columns: table => new
                {
                    Sku = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrdenId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
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
    }
}
