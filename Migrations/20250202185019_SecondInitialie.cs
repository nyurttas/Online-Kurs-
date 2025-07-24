using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _9_EFOnlineCourseDB.Migrations
{
    /// <inheritdoc />
    public partial class SecondInitialie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ExamResults");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "Registrations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "ExamResults",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
