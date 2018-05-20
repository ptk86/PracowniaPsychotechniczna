using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class UniqueNip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Badany_Pesel",
                table: "Badany");

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "TypBadania",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nazwisko",
                table: "Psycholog",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Imie",
                table: "Psycholog",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nip",
                table: "Firma",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "Firma",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "Firma",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Pesel",
                table: "Badany",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nazwisko",
                table: "Badany",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Imie",
                table: "Badany",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "Badany",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Firma_Nip",
                table: "Firma",
                column: "Nip",
                unique: true,
                filter: "[Nip] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Badany_Pesel",
                table: "Badany",
                column: "Pesel",
                unique: true,
                filter: "[Pesel] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Firma_Nip",
                table: "Firma");

            migrationBuilder.DropIndex(
                name: "IX_Badany_Pesel",
                table: "Badany");

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "TypBadania",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nazwisko",
                table: "Psycholog",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Imie",
                table: "Psycholog",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nip",
                table: "Firma",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "Firma",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "Firma",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pesel",
                table: "Badany",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nazwisko",
                table: "Badany",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Imie",
                table: "Badany",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "Badany",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Badany_Pesel",
                table: "Badany",
                column: "Pesel",
                unique: true);
        }
    }
}
