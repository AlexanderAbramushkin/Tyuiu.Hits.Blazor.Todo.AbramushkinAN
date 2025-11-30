using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class addRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 19, 16, 19, 499, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 19, 16, 19, 499, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 19, 16, 19, 499, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 19, 16, 19, 499, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 19, 16, 19, 499, DateTimeKind.Local).AddTicks(9692));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 17, 56, 13, 954, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 17, 56, 13, 954, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 17, 56, 13, 954, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 17, 56, 13, 954, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 17, 56, 13, 954, DateTimeKind.Local).AddTicks(9334));
        }
    }
}
