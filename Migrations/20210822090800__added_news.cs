using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class _added_news : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TextFields",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "TextFields",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ServiceItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ServiceItems",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NewsItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    TitleImagePath = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Subtitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsItems", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Email", "MetaDescription", "MetaKeywords", "MetaTitle", "Status", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("3a02b0bf-2972-4413-9244-0a8a3d324998"), "PageNews", new DateTime(2021, 8, 22, 9, 8, 0, 124, DateTimeKind.Utc).AddTicks(1278), null, null, null, null, null, null, "Содержание заполняется администратором", "Новости", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsItems");

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3a02b0bf-2972-4413-9244-0a8a3d324998"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ServiceItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "debbbc2d-362c-41aa-a161-b2afb3b1b4f7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0827de45-cba1-424e-9f02-2860a88ad9ba", "AQAAAAEAACcQAAAAEFoEKuKLu1EGHQC/F2KPCFMjLUyMh+mMewMXy8efy8lV0D5kJ2rDJLQeFhg3nlhP/Q==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 19, 19, 45, 2, 584, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 19, 19, 45, 2, 584, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 19, 19, 45, 2, 584, DateTimeKind.Utc).AddTicks(6035));
        }
    }
}
