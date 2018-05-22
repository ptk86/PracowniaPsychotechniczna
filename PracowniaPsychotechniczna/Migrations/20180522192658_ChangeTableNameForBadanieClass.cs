using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class ChangeTableNameForBadanieClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Badanies_Badany_BadanyId",
                table: "Badanies");

            migrationBuilder.DropForeignKey(
                name: "FK_Badanies_Psycholog_PsychologId",
                table: "Badanies");

            migrationBuilder.DropForeignKey(
                name: "FK_Badanies_TypBadania_TypBadaniaId",
                table: "Badanies");

            migrationBuilder.DropForeignKey(
                name: "FK_FirmaBadanie_Badanies_BadanieId",
                table: "FirmaBadanie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Badanies",
                table: "Badanies");

            migrationBuilder.RenameTable(
                name: "Badanies",
                newName: "Badanie");

            migrationBuilder.RenameIndex(
                name: "IX_Badanies_TypBadaniaId",
                table: "Badanie",
                newName: "IX_Badanie_TypBadaniaId");

            migrationBuilder.RenameIndex(
                name: "IX_Badanies_PsychologId",
                table: "Badanie",
                newName: "IX_Badanie_PsychologId");

            migrationBuilder.RenameIndex(
                name: "IX_Badanies_BadanyId",
                table: "Badanie",
                newName: "IX_Badanie_BadanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Badanie",
                table: "Badanie",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Badanie_Badany_BadanyId",
                table: "Badanie",
                column: "BadanyId",
                principalTable: "Badany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Badanie_Psycholog_PsychologId",
                table: "Badanie",
                column: "PsychologId",
                principalTable: "Psycholog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Badanie_TypBadania_TypBadaniaId",
                table: "Badanie",
                column: "TypBadaniaId",
                principalTable: "TypBadania",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FirmaBadanie_Badanie_BadanieId",
                table: "FirmaBadanie",
                column: "BadanieId",
                principalTable: "Badanie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Badanie_Badany_BadanyId",
                table: "Badanie");

            migrationBuilder.DropForeignKey(
                name: "FK_Badanie_Psycholog_PsychologId",
                table: "Badanie");

            migrationBuilder.DropForeignKey(
                name: "FK_Badanie_TypBadania_TypBadaniaId",
                table: "Badanie");

            migrationBuilder.DropForeignKey(
                name: "FK_FirmaBadanie_Badanie_BadanieId",
                table: "FirmaBadanie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Badanie",
                table: "Badanie");

            migrationBuilder.RenameTable(
                name: "Badanie",
                newName: "Badanies");

            migrationBuilder.RenameIndex(
                name: "IX_Badanie_TypBadaniaId",
                table: "Badanies",
                newName: "IX_Badanies_TypBadaniaId");

            migrationBuilder.RenameIndex(
                name: "IX_Badanie_PsychologId",
                table: "Badanies",
                newName: "IX_Badanies_PsychologId");

            migrationBuilder.RenameIndex(
                name: "IX_Badanie_BadanyId",
                table: "Badanies",
                newName: "IX_Badanies_BadanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Badanies",
                table: "Badanies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Badanies_Badany_BadanyId",
                table: "Badanies",
                column: "BadanyId",
                principalTable: "Badany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Badanies_Psycholog_PsychologId",
                table: "Badanies",
                column: "PsychologId",
                principalTable: "Psycholog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Badanies_TypBadania_TypBadaniaId",
                table: "Badanies",
                column: "TypBadaniaId",
                principalTable: "TypBadania",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FirmaBadanie_Badanies_BadanieId",
                table: "FirmaBadanie",
                column: "BadanieId",
                principalTable: "Badanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
