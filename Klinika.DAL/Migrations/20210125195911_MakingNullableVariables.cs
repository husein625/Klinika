using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klinika.DAL.Migrations
{
    public partial class MakingNullableVariables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefon",
                table: "Pacijent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Ljekar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 353, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Ljekar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 353, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Ljekar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 353, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Nalaz",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 59, 11, 355, DateTimeKind.Utc).AddTicks(2987), new DateTime(2021, 1, 25, 19, 59, 11, 355, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Nalaz",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 59, 11, 355, DateTimeKind.Utc).AddTicks(4427), new DateTime(2021, 1, 25, 19, 59, 11, 355, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 346, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 346, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 346, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(6977), new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8373), new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8407), new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Prijem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8410), new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "Spol",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 348, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Spol",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 348, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Spol",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 348, DateTimeKind.Utc).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Titula",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Titula",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Titula",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(1987));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefon",
                table: "Pacijent",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Nalaz",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 24, 15, 1, 57, 648, DateTimeKind.Utc).AddTicks(2571), new DateTime(2021, 1, 24, 15, 1, 57, 648, DateTimeKind.Utc).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Nalaz",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DatumVrijeme" },
                values: new object[] { new DateTime(2021, 1, 24, 15, 1, 57, 648, DateTimeKind.Utc).AddTicks(3943), new DateTime(2021, 1, 24, 15, 1, 57, 648, DateTimeKind.Utc).AddTicks(3953) });

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
    }
}
