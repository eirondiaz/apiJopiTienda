using Microsoft.EntityFrameworkCore.Migrations;

namespace apiJopiTienda.Migrations
{
    public partial class CuartMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartHist_Ordenes_OrdenId",
                table: "CartHist");

            migrationBuilder.DropIndex(
                name: "IX_CartHist_OrdenId",
                table: "CartHist");

            migrationBuilder.DropColumn(
                name: "OrdenId",
                table: "CartHist");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "CartHist");

            migrationBuilder.AddColumn<string>(
                name: "Productos",
                table: "Ordenes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Productos",
                table: "Ordenes");

            migrationBuilder.AddColumn<string>(
                name: "OrdenId",
                table: "CartHist",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderId",
                table: "CartHist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartHist_OrdenId",
                table: "CartHist",
                column: "OrdenId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartHist_Ordenes_OrdenId",
                table: "CartHist",
                column: "OrdenId",
                principalTable: "Ordenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
