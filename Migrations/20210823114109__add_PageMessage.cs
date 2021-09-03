using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class _add_PageMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "546c6307-8e0f-4e61-89f1-12d925d646be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74cd20c5-31dd-4aed-9c77-ba37dccb7553", "AQAAAAEAACcQAAAAEJDHEEbNcg5NILsHhd6GyyzzgXT2OWhQpyyVULU2IPlZWCf4WsKYA5m7ZPSWdoOGNQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3a02b0bf-2972-4413-9244-0a8a3d324998"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 11, 41, 8, 627, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 11, 41, 8, 627, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 11, 41, 8, 626, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 23, 11, 41, 8, 627, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Email", "MetaDescription", "MetaKeywords", "MetaTitle", "Status", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("10ec47ed-d48e-4e3e-909c-b31e6b209fa1"), "PageMessage", new DateTime(2021, 8, 23, 11, 41, 8, 627, DateTimeKind.Utc).AddTicks(678), null, null, null, null, null, null, "Содержание заполняется администратором", "Написать админу", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("10ec47ed-d48e-4e3e-909c-b31e6b209fa1"));

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
    }
}
