using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Badany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adres = table.Column<string>(nullable: false),
                    Imie = table.Column<string>(nullable: false),
                    Nazwisko = table.Column<string>(nullable: false),
                    Pesel = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adres = table.Column<string>(nullable: false),
                    Nazwa = table.Column<string>(nullable: false),
                    Nip = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Psycholog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imie = table.Column<string>(nullable: false),
                    Nazwisko = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psycholog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypBadania",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cena = table.Column<decimal>(nullable: false),
                    Nazwa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypBadania", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Badanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BadanyId = table.Column<int>(nullable: false),
                    DataBadania = table.Column<DateTime>(nullable: false),
                    FrimaBadanegoId = table.Column<int>(nullable: true),
                    PsychologId = table.Column<int>(nullable: false),
                    TypBadaniaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Badanies_Badany_BadanyId",
                        column: x => x.BadanyId,
                        principalTable: "Badany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Badanies_Firma_FrimaBadanegoId",
                        column: x => x.FrimaBadanegoId,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Badanies_Psycholog_PsychologId",
                        column: x => x.PsychologId,
                        principalTable: "Psycholog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Badanies_TypBadania_TypBadaniaId",
                        column: x => x.TypBadaniaId,
                        principalTable: "TypBadania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Badanies_BadanyId",
                table: "Badanies",
                column: "BadanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Badanies_FrimaBadanegoId",
                table: "Badanies",
                column: "FrimaBadanegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Badanies_PsychologId",
                table: "Badanies",
                column: "PsychologId");

            migrationBuilder.CreateIndex(
                name: "IX_Badanies_TypBadaniaId",
                table: "Badanies",
                column: "TypBadaniaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Badanies");

            migrationBuilder.DropTable(
                name: "Badany");

            migrationBuilder.DropTable(
                name: "Firma");

            migrationBuilder.DropTable(
                name: "Psycholog");

            migrationBuilder.DropTable(
                name: "TypBadania");
        }
    }
}
