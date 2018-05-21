using Microsoft.EntityFrameworkCore.Migrations;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class SeedPsychologTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT PracowniaPsychologiczna.dbo.Psycholog ON;
                INSERT INTO PracowniaPsychologiczna.dbo.Psycholog (Id, Imie, Nazwisko) VALUES (1, 'Łukasz', 'Koziarski');
                INSERT INTO PracowniaPsychologiczna.dbo.Psycholog (Id, Imie, Nazwisko) VALUES (2, 'Amadeusz', 'Nowak');
                INSERT INTO PracowniaPsychologiczna.dbo.Psycholog (Id, Imie, Nazwisko) VALUES (3, 'Piotr', 'Kiliński');
                SET IDENTITY_INSERT PracowniaPsychologiczna.dbo.Psycholog OFF;

            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM PracowniaPsychologiczna.dbo.Psycholog;
            ");
        }
    }
}
