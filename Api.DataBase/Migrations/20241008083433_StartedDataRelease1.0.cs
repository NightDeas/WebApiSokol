using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class StartedDataRelease10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ad1ed9f-c599-4728-99aa-6e976d43ea45"), "Товар" },
                    { new Guid("c846343c-1dcb-4d5f-868f-fca120fe4255"), "Услуга" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("0ad1ed9f-c599-4728-99aa-6e976d43ea45"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("c846343c-1dcb-4d5f-868f-fca120fe4255"));
        }
    }
}
