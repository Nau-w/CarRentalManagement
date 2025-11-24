using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(3716), new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(3730), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(3734), new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(3734), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4004), new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4005), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4008), new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4009), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4097), new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4098), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4100), new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4101), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4103), new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4104), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4106), new DateTime(2025, 11, 24, 16, 30, 36, 620, DateTimeKind.Local).AddTicks(4107), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
