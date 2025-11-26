using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a8a39c25-f6c3-466d-8bf4-136084836784", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMHz/0v7Xt9ouV6wjhX1VMO44NrFwYtgvrigSZDvcU/RhaY7tiNHClIMLr30HhGogQ==", null, false, "bc93b95e-c6a2-46c6-8021-72dd1c49814e", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 55, 476, DateTimeKind.Local).AddTicks(9592), new DateTime(2025, 11, 26, 10, 16, 55, 476, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 55, 476, DateTimeKind.Local).AddTicks(9608), new DateTime(2025, 11, 26, 10, 16, 55, 476, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 55, 476, DateTimeKind.Local).AddTicks(9940), new DateTime(2025, 11, 26, 10, 16, 55, 476, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 55, 476, DateTimeKind.Local).AddTicks(9948), new DateTime(2025, 11, 26, 10, 16, 55, 476, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 55, 477, DateTimeKind.Local).AddTicks(96), new DateTime(2025, 11, 26, 10, 16, 55, 477, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 55, 477, DateTimeKind.Local).AddTicks(100), new DateTime(2025, 11, 26, 10, 16, 55, 477, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 55, 477, DateTimeKind.Local).AddTicks(104), new DateTime(2025, 11, 26, 10, 16, 55, 477, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 55, 477, DateTimeKind.Local).AddTicks(107), new DateTime(2025, 11, 26, 10, 16, 55, 477, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(8609), new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(8625), new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(8854), new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(8858), new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(9016), new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(9020), new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(9022), new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(9025), new DateTime(2025, 11, 26, 9, 26, 7, 185, DateTimeKind.Local).AddTicks(9025) });
        }
    }
}
