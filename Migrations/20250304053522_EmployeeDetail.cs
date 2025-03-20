using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Peach_Clone.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContractualHours",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeNumber", "BranchNumber", "ContractualHours", "ContractualPay", "DateOfBirth", "DateOfJoining", "FirstName", "LastName", "Location", "PositionTitle" },
                values: new object[] { 101, "B001", 40, 70000m, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", "New York", "Software Engineer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 101);

            migrationBuilder.AlterColumn<string>(
                name: "ContractualHours",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
