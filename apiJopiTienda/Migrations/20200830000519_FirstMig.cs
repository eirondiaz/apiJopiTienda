using Microsoft.EntityFrameworkCore.Migrations;

namespace apiJopiTienda.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sku",
                table: "CartHist",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sku",
                table: "CartHist",
                type: "int",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
