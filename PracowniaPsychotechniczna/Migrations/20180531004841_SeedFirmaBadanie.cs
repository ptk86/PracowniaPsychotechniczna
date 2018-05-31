using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PracowniaPsychotechniczna.Migrations
{
    public partial class SeedFirmaBadanie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (1, 1);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (3, 5);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (4, 1);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (11, 14);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (12, 16);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (13, 5);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (14, 19);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (15, 5);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (19, 2);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (20, 13);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (21, 2);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (25, 18);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (26, 6);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (27, 4);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (28, 14);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (31, 16);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (32, 2);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (33, 13);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (34, 16);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (35, 9);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (36, 6);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (37, 18);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (39, 10);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (41, 9);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (42, 14);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (43, 16);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (46, 7);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (47, 11);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (48, 15);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (49, 6);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (50, 19);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (53, 11);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (54, 7);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (55, 1);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (58, 2);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (59, 8);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (60, 11);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (61, 13);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (63, 14);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (65, 16);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (67, 11);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (68, 11);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (69, 16);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (70, 18);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (71, 9);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (73, 17);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (74, 2);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (76, 13);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (79, 10);
                INSERT INTO PracowniaPsychologiczna.dbo.FirmaBadanie (BadanieId,FirmaId) VALUES (80, 16);
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM PracowniaPsychologiczna.dbo.FirmaBadanie;
            ");
        }
    }
}
