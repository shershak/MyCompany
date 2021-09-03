using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class add_unique_title : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "NewsItems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "NewsItems",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a8fb6dea-722e-4492-9f60-05bacd08ac0c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "972a70a4-287d-4fe5-ac57-92da8f9e367f", "AQAAAAEAACcQAAAAEKpS/iC7KNt7SsntJliwC8EkPFGk9cuImOay8q4NllQ6m7SCDqeCOIcVhSG/PyHYdg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3a02b0bf-2972-4413-9244-0a8a3d324998"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 22, 15, 25, 14, 247, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 22, 15, 25, 14, 247, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 22, 15, 25, 14, 247, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 22, 15, 25, 14, 247, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.CreateIndex(
                name: "IX_NewsItems_Title",
                table: "NewsItems",
                column: "Title",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_NewsItems_Title",
                table: "NewsItems");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c27e6544-1e85-479b-816f-0cf9a9da6319");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17abed97-da3d-4aba-a166-ba573d3ec144", "AQAAAAEAACcQAAAAECr+PnPQoLHsG7u+2tiI/d5osfWwqUTU20btuVsFFI0Enpw/jijvN4mANJmxamSonw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3a02b0bf-2972-4413-9244-0a8a3d324998"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 22, 9, 8, 0, 124, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 22, 9, 8, 0, 124, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 22, 9, 8, 0, 123, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 22, 9, 8, 0, 124, DateTimeKind.Utc).AddTicks(1176));
        }
    }
}
