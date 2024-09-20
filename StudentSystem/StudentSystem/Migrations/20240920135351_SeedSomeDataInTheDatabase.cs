using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedSomeDataInTheDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Resources",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Resources",
                type: "Nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.InsertData(
                table: "Coursecs",
                columns: new[] { "Id", "Description", "EndDate", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, "Learn C#", new DateTime(2024, 12, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6648), "C#", 5000.0, new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6643) },
                    { 2, "Learn C++", new DateTime(2024, 11, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6665), "C++", 2000.0, new DateTime(2024, 9, 30, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6657) },
                    { 3, "Learn Java", new DateTime(2026, 1, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6677), "Java", 10000.0, new DateTime(2025, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6672) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthday", "Name", "PhoneNumber", "RegistredOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdelrahman Yasser", "010191765", new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6237) },
                    { 2, new DateTime(2001, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Momen Abdo", "011554789", new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6345) },
                    { 3, new DateTime(2005, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohamed Nagah", "0155586674", new DateTime(2024, 10, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6354) }
                });

            migrationBuilder.InsertData(
                table: "HomeWorks",
                columns: new[] { "HomeWorkId", "Content", "ContentType", "CourseId", "CourseId1", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { 1, "https://learn.microsoft.com/en-us/dotnet/csharp/", 0, 1, null, 1, new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6766) },
                    { 2, "https://devdocs.io/cpp/", 0, 2, null, 2, new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6774) },
                    { 3, "https://www.cs.cmu.edu/afs/cs.cmu.edu/user/gchen/www/download/java/LearnJava.pdf", 1, 3, null, 3, new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6780) }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "CourseId", "Name", "ResourceType", "Url" },
                values: new object[,]
                {
                    { 1, 1, "C# Tutorial", 2, "https://learn.microsoft.com/en-us/dotnet/csharp/" },
                    { 2, 2, "C++ Tutorial", 2, "https://devdocs.io/cpp/" },
                    { 3, 3, "Java Tutorial", 3, "https://www.cs.cmu.edu/afs/cs.cmu.edu/user/gchen/www/download/java/LearnJava.pdf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HomeWorks",
                keyColumn: "HomeWorkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HomeWorks",
                keyColumn: "HomeWorkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HomeWorks",
                keyColumn: "HomeWorkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coursecs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coursecs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coursecs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Resources",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Resources",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Nvarchar(50)");
        }
    }
}
