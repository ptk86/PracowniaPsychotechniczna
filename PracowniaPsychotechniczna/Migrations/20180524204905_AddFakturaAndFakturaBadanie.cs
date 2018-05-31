using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class AddFakturaAndFakturaBadanie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faktura",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faktura", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FakturaBadanie",
                columns: table => new
                {
                    FakturaId = table.Column<int>(nullable: false),
                    BadanieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FakturaBadanie", x => new { x.FakturaId, x.BadanieId });
                    table.ForeignKey(
                        name: "FK_FakturaBadanie_Badanie_BadanieId",
                        column: x => x.BadanieId,
                        principalTable: "Badanie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FakturaBadanie_Faktura_FakturaId",
                        column: x => x.FakturaId,
                        principalTable: "Faktura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FakturaBadanie_BadanieId",
                table: "FakturaBadanie",
                column: "BadanieId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FakturaBadanie");

            migrationBuilder.DropTable(
                name: "Faktura");
        }
    }
}
