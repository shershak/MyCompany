using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class _add_New_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NewsItems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "4268af13-55f4-4d50-9d96-a67257fd4e5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80f347b4-ecbd-48ba-a6ee-bc35e19afb28", "AQAAAAEAACcQAAAAEPAnIBtpK9Jyc2S9ZFurmE6EESa0IgIU/iKEFoWs3tjY5GcZvkWyAJxNMEIfxE4/7A==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("10ec47ed-d48e-4e3e-909c-b31e6b209fa1"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 12, 38, 37, 908, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3a02b0bf-2972-4413-9244-0a8a3d324998"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 12, 38, 37, 908, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 12, 38, 37, 908, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 12, 38, 37, 908, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 12, 38, 37, 908, DateTimeKind.Utc).AddTicks(4651));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "563b71e7-9290-4b02-a67b-08d5fddcccdb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f3721e7-73fb-4dc9-b488-e9d717a9425c", "AQAAAAEAACcQAAAAEBKqkBPzkisdMecYR/1Si0kcEc4bK8v3/R8kTUW0424CpmWpovdfQu3eWesCYJFQtQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("10ec47ed-d48e-4e3e-909c-b31e6b209fa1"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 12, 5, 56, 350, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3a02b0bf-2972-4413-9244-0a8a3d324998"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 12, 5, 56, 350, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 12, 5, 56, 350, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 12, 5, 56, 350, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 12, 5, 56, 350, DateTimeKind.Utc).AddTicks(9386));
        }
    }
}
