using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class AddFirmaBadanie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Badanies_Firma_FrimaBadanegoId",
                table: "Badanies");

            migrationBuilder.DropIndex(
                name: "IX_Badanies_FrimaBadanegoId",
                table: "Badanies");

            migrationBuilder.DropColumn(
                name: "FrimaBadanegoId",
                table: "Badanies");

            migrationBuilder.CreateTable(
                name: "FirmaBadanie",
                columns: table => new
                {
                    FirmaId = table.Column<int>(nullable: false),
                    BadanieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmaBadanie", x => new { x.FirmaId, x.BadanieId });
                    table.ForeignKey(
                        name: "FK_FirmaBadanie_Badanies_BadanieId",
                        column: x => x.BadanieId,
                        principalTable: "Badanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FirmaBadanie_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FirmaBadanie_BadanieId",
                table: "FirmaBadanie",
                column: "BadanieId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirmaBadanie");

            migrationBuilder.AddColumn<int>(
                name: "FrimaBadanegoId",
                table: "Badanies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Badanies_FrimaBadanegoId",
                table: "Badanies",
                column: "FrimaBadanegoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Badanies_Firma_FrimaBadanegoId",
                table: "Badanies",
                column: "FrimaBadanegoId",
                principalTable: "Firma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
