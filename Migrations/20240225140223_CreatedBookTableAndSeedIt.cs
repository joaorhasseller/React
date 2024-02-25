using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreatedBookTableAndSeedIt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LauchDate",
                table: "Books",
                newName: "LaunchDate");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "LaunchDate", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "John Doe", new DateTime(2023, 8, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7159), 29.99m, "The Art of Programming" },
                    { 2, "Jane Smith", new DateTime(2023, 2, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7186), 19.99m, "Data Science Basics" },
                    { 3, "Robert Johnson", new DateTime(2023, 11, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7189), 24.99m, "Machine Learning Fundamentals" },
                    { 4, "Emily White", new DateTime(2023, 5, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7192), 14.99m, "Web Development Essentials" },
                    { 5, "Michael Brown", new DateTime(2023, 7, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7194), 39.99m, "Deep Learning Techniques" },
                    { 6, "Sophia Davis", new DateTime(2023, 9, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7198), 17.99m, "Introduction to C# Programming" },
                    { 7, "Daniel Wilson", new DateTime(2023, 4, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7200), 32.99m, "The Art of Database Design" },
                    { 8, "Olivia Taylor", new DateTime(2023, 6, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7203), 21.99m, "Agile Software Development" },
                    { 9, "Ethan Miller", new DateTime(2023, 10, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7205), 27.99m, "iOS App Development Guide" },
                    { 10, "Ava Martinez", new DateTime(2023, 3, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7209), 19.99m, "JavaScript for Beginners" },
                    { 11, "Liam Anderson", new DateTime(2023, 12, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7211), 34.99m, "Python Programming Mastery" },
                    { 12, "Emma Harris", new DateTime(2024, 1, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7213), 23.99m, "UI/UX Design Principles" },
                    { 13, "Jackson Turner", new DateTime(2023, 6, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7216), 29.99m, "Network Security Essentials" },
                    { 14, "Grace Murphy", new DateTime(2023, 7, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7219), 26.99m, "Android App Development Basics" },
                    { 15, "Carter Wright", new DateTime(2023, 11, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7221), 31.99m, "Cybersecurity Fundamentals" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.RenameColumn(
                name: "LaunchDate",
                table: "Books",
                newName: "LauchDate");
        }
    }
}
