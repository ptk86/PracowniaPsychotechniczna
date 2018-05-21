using Microsoft.EntityFrameworkCore.Migrations;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class UniqeConstraintOnPeselProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pesel",
                table: "Badany",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Badany_Pesel",
                table: "Badany",
                column: "Pesel",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Badany_Pesel",
                table: "Badany");

            migrationBuilder.AlterColumn<string>(
                name: "Pesel",
                table: "Badany",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
