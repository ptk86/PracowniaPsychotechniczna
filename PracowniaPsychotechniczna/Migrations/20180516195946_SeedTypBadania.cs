using Microsoft.EntityFrameworkCore.Migrations;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class SeedTypBadania : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT PracowniaPsychologiczna.dbo.TypBadania ON;
                INSERT INTO PracowniaPsychologiczna.dbo.TypBadania (Id, Nazwa, Cena) VALUES (1, N'Prokurator', 200);
                INSERT INTO PracowniaPsychologiczna.dbo.TypBadania (Id, Nazwa, Cena) VALUES (2, N'Sędzia', 200);
                INSERT INTO PracowniaPsychologiczna.dbo.TypBadania (Id, Nazwa, Cena) VALUES (3, N'Komornik', 200);
                INSERT INTO PracowniaPsychologiczna.dbo.TypBadania (Id, Nazwa, Cena) VALUES (4, N'Kierowca zawodowy pwyżej 3,5 t', 150);
                INSERT INTO PracowniaPsychologiczna.dbo.TypBadania (Id, Nazwa, Cena) VALUES (5, N'Kierowca zawodowy pniżej 3,5 t', 150);
                INSERT INTO PracowniaPsychologiczna.dbo.TypBadania (Id, Nazwa, Cena) VALUES (6, N'Po odebraniu prawa jazdy - alkohol', 250);
                INSERT INTO PracowniaPsychologiczna.dbo.TypBadania (Id, Nazwa, Cena) VALUES (7, N'Po odebraniu prawa jazdy - punkty', 200);
                INSERT INTO PracowniaPsychologiczna.dbo.TypBadania (Id, Nazwa, Cena) VALUES (8, N'Pozwolenie na broń', 250);
                INSERT INTO PracowniaPsychologiczna.dbo.TypBadania (Id, Nazwa, Cena) VALUES (9, N'Wózek widłowy', 60);
                SET IDENTITY_INSERT PracowniaPsychologiczna.dbo.TypBadania OFF;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
              DELETE FROM PracowniaPsychologiczna.dbo.TypBadania;
            ");
        }
    }
}
