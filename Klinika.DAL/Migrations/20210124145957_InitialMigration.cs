using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klinika.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titula", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacijent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRođenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<int>(type: "int", nullable: false),
                    SpolID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacijent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacijent_Spol_SpolID",
                        column: x => x.SpolID,
                        principalTable: "Spol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ljekar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifra = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    TitulaID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ljekar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ljekar_Titula_TitulaID",
                        column: x => x.TitulaID,
                        principalTable: "Titula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prijem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumVrijeme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitniPrijem = table.Column<bool>(type: "bit", nullable: false),
                    PacijentID = table.Column<int>(type: "int", nullable: false),
                    LjekarID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prijem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prijem_Ljekar_LjekarID",
                        column: x => x.LjekarID,
                        principalTable: "Ljekar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prijem_Pacijent_PacijentID",
                        column: x => x.PacijentID,
                        principalTable: "Pacijent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nalaz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumVrijeme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrijemID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nalaz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nalaz_Prijem_PrijemID",
                        column: x => x.PrijemID,
                        principalTable: "Prijem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Spol",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "Naziv" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 24, 14, 59, 56, 620, DateTimeKind.Utc).AddTicks(1331), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Musko" },
                    { 2, new DateTime(2021, 1, 24, 14, 59, 56, 620, DateTimeKind.Utc).AddTicks(1815), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zensko" },
                    { 3, new DateTime(2021, 1, 24, 14, 59, 56, 620, DateTimeKind.Utc).AddTicks(1824), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nepoznato" }
                });

            migrationBuilder.InsertData(
                table: "Titula",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "Naziv" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(6251), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Specijalista" },
                    { 2, new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(6295), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Specijalizant" },
                    { 3, new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(6298), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Med Sestra" }
                });

            migrationBuilder.InsertData(
                table: "Ljekar",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Ime", "ModifiedAt", "Prezime", "Sifra", "TitulaID" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(814), "hmuftic", "Husein", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muftic", 1, 1 },
                    { 2, new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(884), "hmuftic", "Edin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malcinovic", 2, 2 },
                    { 3, new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(886), "hmuftic", "Ahmed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sehovic", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Pacijent",
                columns: new[] { "Id", "Adresa", "CreatedAt", "CreatedBy", "DatumRođenja", "ImePrezime", "ModifiedAt", "SpolID", "Telefon" },
                values: new object[,]
                {
                    { 1, "Breza", new DateTime(2021, 1, 24, 14, 59, 56, 618, DateTimeKind.Utc).AddTicks(1369), null, new DateTime(1998, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Husein Muftić", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 62528494 },
                    { 2, "Sarajevo", new DateTime(2021, 1, 24, 14, 59, 56, 618, DateTimeKind.Utc).AddTicks(4352), null, new DateTime(1995, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eldin Velic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 62222494 },
                    { 3, "Sarajevo", new DateTime(2021, 1, 24, 14, 59, 56, 618, DateTimeKind.Utc).AddTicks(4405), null, new DateTime(1995, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elma Avdukic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 62222224 }
                });

            migrationBuilder.InsertData(
                table: "Prijem",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DatumVrijeme", "HitniPrijem", "LjekarID", "ModifiedAt", "PacijentID" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2448), "hmuftic", new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2451), false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2479), "hmuftic", new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2480), false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2481), "hmuftic", new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2482), false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 1, new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(1095), "hmuftic", new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(1101), false, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ljekar_TitulaID",
                table: "Ljekar",
                column: "TitulaID");

            migrationBuilder.CreateIndex(
                name: "IX_Nalaz_PrijemID",
                table: "Nalaz",
                column: "PrijemID");

            migrationBuilder.CreateIndex(
                name: "IX_Pacijent_SpolID",
                table: "Pacijent",
                column: "SpolID");

            migrationBuilder.CreateIndex(
                name: "IX_Prijem_LjekarID",
                table: "Prijem",
                column: "LjekarID");

            migrationBuilder.CreateIndex(
                name: "IX_Prijem_PacijentID",
                table: "Prijem",
                column: "PacijentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nalaz");

            migrationBuilder.DropTable(
                name: "Prijem");

            migrationBuilder.DropTable(
                name: "Ljekar");

            migrationBuilder.DropTable(
                name: "Pacijent");

            migrationBuilder.DropTable(
                name: "Titula");

            migrationBuilder.DropTable(
                name: "Spol");
        }
    }
}
