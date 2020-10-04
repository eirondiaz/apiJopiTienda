using Microsoft.EntityFrameworkCore.Migrations;

namespace apiJopiTienda.Migrations
{
    public partial class QuintMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Productos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Productos");
        }
    }
}
