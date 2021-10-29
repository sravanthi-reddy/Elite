using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentTechProtfolio.Migrations
{
    public partial class ChangedStudentFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProgramCode",
                table: "Student",
                newName: "Skills");

            migrationBuilder.RenameColumn(
                name: "CurrentSemester",
                table: "Student",
                newName: "CurrentProgram");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateJoinedCollege",
                table: "Student",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateJoinedCollege",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Skills",
                table: "Student",
                newName: "ProgramCode");

            migrationBuilder.RenameColumn(
                name: "CurrentProgram",
                table: "Student",
                newName: "CurrentSemester");
        }
    }
}
