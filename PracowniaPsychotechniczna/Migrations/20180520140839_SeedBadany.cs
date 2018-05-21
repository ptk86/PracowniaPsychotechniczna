using Microsoft.EntityFrameworkCore.Migrations;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class SeedBadany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT PracowniaPsychologiczna.dbo.Badany ON;
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (1, '59051777672', 'Medard', 'Reczek', 'Konwaliowa 03, 04-213 Słupsk' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (2, '93101625137', 'Kajetan', 'Knapik', 'Żeglarska 12/39, 52-095 Skalbmierz' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (3, '64111664214', 'Kuba', 'Machak', 'Dąbrowskiego Jarosława 96/72, 39-603 Nowe Kramsko' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (4, '61071421958', 'Benedykt', 'Regula', 'Dębowa 94/91, 23-997 Śrem' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (5, '67052391951', 'Franciszek', 'Jakubowski', 'Rynek 06A, 10-737 Darłowo' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (6, '70031647716', 'Ludomir', 'Demko', 'Pocztowa 01A/65, 90-904 Chojnice' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (7, '62051033196', 'Gościsław', 'Klecha', 'Stawowa 45A/21, 85-913 Świętochłowice' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (8, '55120128891', 'Olgierd', 'Karpiak', 'Świerkowa 54A, 07-537 Szteklin' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (9, '69091776551', 'Bogumił', 'Jachowski', 'Złota 75A, 16-038 Sieradz' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (10, '51071719993', 'Świętosław', 'Pienkowski', 'Lechicka 25/22, 73-364 Braniewo' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (11, '57110478319', 'Gaweł', 'Dombkowski', 'Odrzańska 45A/72, 03-357 Konstancin-Jeziorna' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (12, '95041352632', 'Narcyz', 'Pniewski', 'Daleka 45/70, 16-307 Kamienica Królewska' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (13, '62090469699', 'Fortunat', 'Gornik', 'Wesoła 23A/51, 90-610 Jelenia Góra' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (14, '71011594532', 'Więcesław', 'Moch', 'Zamenhofa Ludwika 41/22, 98-167 Orzesze' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (15, '59022473611', 'Tytus', 'Rafalko', 'Prusa Bolesława 40A, 54-941 Gorzów Wielkopolski' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (16, '53072728394', 'Leon', 'Pisarek', 'Legnicka 95/43, 80-204 Gdańsk' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (17, '76120993416', 'Marcel', 'Drewek', 'Miła 95A, 97-290 Świebodzice' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (18, '85110377956', 'Oleg', 'Staszak', 'Krakowska 53A, 10-782 Łomianki' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (19, '86081673793', 'Konstantyn', 'Malkus', 'Jesionowa 24A/95, 83-529 Jeziorna' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (20, '97062556512', 'Melchior', 'Kalinowski', 'Olimpijska 79, 39-810 Żywiec' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (21, '53042733887', 'Marlena', 'Galczynska', 'Powstańców Śląskich 76A/05, 73-759 Ciechanów' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (22, '86051734161', 'Pelagia', 'Zydowo', 'Tęczowa 59A, 11-155 Siemianowice Śląskie' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (23, '54052062228', 'Dagmara', 'Winnicka', 'Solna 59A, 30-679 Legionowo' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (24, '68060921747', 'Maryna', 'Michniewicz', 'Zakątek 26A/35, 31-625 Gorzów Wielkopolski' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (25, '83052547321', 'Szarlota', 'Zoldak', 'Wysoka 60A, 71-237 Konstancin-Jeziorna' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (26, '94112784428', 'Donata', 'Dunin', 'Wesoła 35, 85-336 Lubliniec' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (27, '54033176526', 'Genowefa', 'Major', 'Radomska 33/82, 00-338 Opole' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (28, '70120213527', 'Aurelia', 'Sokal', 'Dąbrowskiego Jarosława 51A, 12-953 Wejherowo' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (29, '95121674229', 'Ludwika', 'Zinda', 'Królewska 93, 31-660 Wodzisław Śląski' );
                INSERT INTO PracowniaPsychologiczna.dbo.Badany (Id, Pesel, Imie, Nazwisko, Adres) VALUES (30, '72071857469', 'Odeta', 'Majkowska', 'Żwirowa 92A/87, 17-584 Jaworzno' );
                SET IDENTITY_INSERT PracowniaPsychologiczna.dbo.Badany OFF;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
              DELETE FROM PracowniaPsychologiczna.dbo.bADANY;
            ");

        }
    }
}
