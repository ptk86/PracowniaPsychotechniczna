using Microsoft.EntityFrameworkCore.Migrations;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class ChangeCenaPropertyToInteger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cena",
                table: "TypBadania",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Cena",
                table: "TypBadania",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
