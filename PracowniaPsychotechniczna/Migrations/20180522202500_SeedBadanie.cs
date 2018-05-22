using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class SeedBadanie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT PracowniaPsychologiczna.dbo.Badanie ON;
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 1, 14, '2017-05-27', 2, 9 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 2, 27, '2017-06-01', 2, 8 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 3, 2, '2017-06-03', 3, 2 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 4, 18, '2017-06-06', 2, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 5, 25, '2017-06-10', 2, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 6, 5, '2017-06-12', 2, 2 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 7, 30, '2017-06-15', 2, 9 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 8, 6, '2017-06-19', 3, 9 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 9, 26, '2017-06-19', 3, 9 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 10, 2, '2017-06-22', 2, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 11, 4, '2017-06-24', 2, 1 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 12, 5, '2017-06-27', 2, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 13, 1, '2017-06-29', 1, 8 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 14, 7, '2017-07-01', 1, 5 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 15, 15, '2017-07-05', 2, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 16, 8, '2017-07-06', 1, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 17, 9, '2017-07-15', 2, 8 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 18, 27, '2017-07-22', 3, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 19, 29, '2017-07-24', 1, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 20, 23, '2017-07-28', 2, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 21, 17, '2017-07-31', 2, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 22, 18, '2017-08-03', 3, 8 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 23, 21, '2017-08-06', 1, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 24, 4, '2017-08-23', 2, 7 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 25, 5, '2017-09-04', 3, 9 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 26, 16, '2017-09-09', 1, 7 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 27, 19, '2017-09-23', 2, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 28, 27, '2017-09-25', 1, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 29, 17, '2017-09-26', 3, 5 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 30, 10, '2017-10-08', 3, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 31, 4, '2017-10-09', 2, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 32, 25, '2017-10-11', 2, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 33, 18, '2017-10-14', 3, 5 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 34, 18, '2017-10-14', 3, 5 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 35, 24, '2017-10-25', 1, 1 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 36, 17, '2017-11-09', 2, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 37, 28, '2017-11-11', 3, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 38, 23, '2017-11-16', 3, 1 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 39, 14, '2017-11-20', 2, 5 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 40, 22, '2017-11-23', 2, 9 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 41, 21, '2017-11-25', 3, 8 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 42, 3, '2017-12-05', 3, 9 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 43, 8, '2017-12-12', 3, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 44, 11, '2017-12-15', 3, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 45, 26, '2017-12-29', 3, 5 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 46, 1, '2018-01-15', 3, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 47, 9, '2018-01-16', 1, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 48, 27, '2018-01-16', 1, 1 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 49, 30, '2018-01-16', 3, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 50, 19, '2018-01-18', 1, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 51, 3, '2018-01-19', 1, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 52, 1, '2018-01-28', 1, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 53, 29, '2018-01-30', 1, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 54, 8, '2018-02-03', 3, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 55, 27, '2018-02-06', 1, 8 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 56, 26, '2018-02-06', 3, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 57, 29, '2018-02-21', 3, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 58, 19, '2018-03-05', 3, 7 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 59, 12, '2018-03-07', 2, 8 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 60, 10, '2018-03-09', 3, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 61, 17, '2018-03-10', 3, 9 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 62, 16, '2018-03-11', 1, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 63, 8, '2018-03-12', 1, 8 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 64, 12, '2018-03-15', 2, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 65, 13, '2018-03-15', 1, 6 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 66, 25, '2018-03-16', 2, 1 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 67, 23, '2018-03-24', 2, 1 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 68, 11, '2018-03-26', 3, 2 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 69, 11, '2018-03-30', 2, 9 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 70, 3, '2018-03-30', 2, 1 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 71, 10, '2018-03-31', 3, 5 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 72, 22, '2018-04-01', 2, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 73, 13, '2018-04-04', 2, 8 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 74, 24, '2018-04-13', 2, 3 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 75, 16, '2018-04-21', 3, 2 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 76, 4, '2018-05-01', 3, 2 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 77, 30, '2018-05-05', 2, 4 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 78, 7, '2018-05-15', 3, 1 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 79, 1, '2018-05-21', 1, 2 );
                INSERT INTO PracowniaPsychologiczna.dbo.Badanie (Id, BadanyId, DataBadania, PsychologId, TypBadaniaId) VALUES ( 80, 29, '2018-05-21', 2, 3 );

                SET IDENTITY_INSERT PracowniaPsychologiczna.dbo.Badanie OFF;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
              DELETE FROM PracowniaPsychologiczna.dbo.Badanie;
            ");
        }
    }
}
