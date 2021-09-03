using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class _change_type_of_Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "729b40cd-60f7-44dc-a730-e193e9db8717");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32753390-6f9a-49d7-b169-5e81ce09cdc4", "AQAAAAEAACcQAAAAENQdsKLoigosrJtRbvxaYKBZiYjpmEUGYJkbNpWCfYh+GhAaVSO46PKmHsuLt9cE6g==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3a02b0bf-2972-4413-9244-0a8a3d324998"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 9, 10, 8, 304, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 9, 10, 8, 304, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 9, 10, 8, 303, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 9, 10, 8, 303, DateTimeKind.Utc).AddTicks(9942));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "875fdfaf-4d30-44cb-807a-22926d76ba78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e643bd01-de6f-471d-8487-88ce5f5c60ae", "AQAAAAEAACcQAAAAEOj5le1z0unGr9ZpBU3OyJshvz41T0udzcsqkQFDqTgpxhb+OtXSfLgRxVfyE/4crw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3a02b0bf-2972-4413-9244-0a8a3d324998"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 9, 7, 2, 962, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 9, 7, 2, 962, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 9, 7, 2, 962, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 9, 7, 2, 962, DateTimeKind.Utc).AddTicks(6092));
        }
    }
}
