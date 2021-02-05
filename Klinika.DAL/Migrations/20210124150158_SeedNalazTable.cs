using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klinika.DAL.Migrations
{
    public partial class SeedNalazTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ljekar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 646, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Ljekar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 646, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Ljekar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 646, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.InsertData(
                table: "Nalaz",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DatumVrijeme", "ModifiedAt", "Opis", "PrijemID" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 24, 15, 1, 57, 648, DateTimeKind.Utc).AddTicks(2571), "hmuftic", new DateTime(2021, 1, 24, 15, 1, 57, 648, DateTimeKind.Utc).AddTicks(3042), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OpisNalaza", 1 },
                    { 2, new DateTime(2021, 1, 24, 15, 1, 57, 648, DateTimeKind.Utc).AddTicks(3943), "hmuftic", new DateTime(2021, 1, 24, 15, 1, 57, 648, DateTimeKind.Utc).AddTicks(3953), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OpisNalaza", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 639, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 639, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 639, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(6687), new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(8036), new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(8072), new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(8075), new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Spol",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 641, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Spol",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 641, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Spol",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 641, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Titula",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Titula",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Titula",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 15, 1, 57, 647, DateTimeKind.Utc).AddTicks(1944));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nalaz",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nalaz",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Ljekar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Ljekar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Ljekar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 618, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 618, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 618, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(1095), new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2448), new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2479), new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2481), new DateTime(2021, 1, 24, 14, 59, 56, 626, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Spol",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 620, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Spol",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 620, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Spol",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 620, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Titula",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Titula",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Titula",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 14, 59, 56, 625, DateTimeKind.Utc).AddTicks(6298));
        }
    }
}
