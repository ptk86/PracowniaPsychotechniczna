using Microsoft.EntityFrameworkCore.Migrations;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class SeedFirma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT PracowniaPsychologiczna.dbo.Firma ON;
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (1, N'Popiełuszki Jerzego 99/81, 18-791 Łomża',N'Wójcik Ltd',N'1332851214' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (2, N'Radomska 77, 03-292 Nowa Ruda',N'Brzeziński Ltd',N'1368865340' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (3, N'Kopalniana 88A/88, 83-801 Toruń',N'Piotrowski Ltd',N'7409190593' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (4, N'Modra 67, 12-985 Rzeszów',N'Sawicki Ltd',N'8633845318' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (5, N'Obrońców Westerplatte 14A, 77-765 Suwałki',N'Gajewski Ltd',N'1497470230' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (6, N'Stawowa 83, 33-699 Krapkowice',N'Chojnacki Ltd',N'5593206489' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (7, N'Zamkowa 32/50, 38-757 Świdnica',N'Wiśniewski Ltd',N'8750925953' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (8, N'Różana 18/90, 23-162 Bochnia',N'Krajewski Ltd',N'4807598033' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (9, N'Modra 31, 61-701 Bielsko-Biała',N'Kaczmarek Ltd',N'9213336450' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (10, N'Cicha 75/00, 58-415 Krosno',N'Jasiński Ltd',N'8251887832' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (11, N'Środkowa 73, 69-342 Suwałki',N'Jakubowski Ltd',N'2794437751' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (12, N'Powstańców Wielkopolskich 10/14, 40-896 Grodzisk Mazowiecki',N'Majewski Ltd',N'3067924103' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (13, N'Zamkowa 59A/47, 03-432 Piła',N'Ciesielski Ltd',N'4826464121' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (14, N'Plater Emilii 34A/23, 35-513 Legnica',N'Domański Ltd',N'7983344792' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (15, N'Bracka 89/91, 07-169 Kłodzko',N'Cieślak Ltd',N'7190968948' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (16, N'Letnia 36A, 43-546 Lędziny',N'Lis Ltd',N'7825495983' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (17, N'Pułaskiego Kazimierza 71/57, 04-956 Toruń',N'Bąk Ltd',N'8701909405' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (18, N'Wyzwolenia Al. 12, 00-910 Jelenia Góra',N'Maciejewski Ltd',N'9556844602' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (19, N'Górnicza 47/37, 48-288 Pisz',N'Wróblewski Ltd',N'6661795258' );
                INSERT INTO PracowniaPsychologiczna.dbo.Firma (Id, Adres, Nazwa, Nip) VALUES (20, N'Świętokrzyska 70, 71-464 Czarna Woda',N'Sokołowski Ltd',N'3379049272' );
                SET IDENTITY_INSERT PracowniaPsychologiczna.dbo.Firma OFF;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
              DELETE FROM PracowniaPsychologiczna.dbo.Firma;
            ");
        }
    }
}
