using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentTechProtfolio.Migrations
{
    public partial class ChangedStudentFieldss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IndustryExperience",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndustryExperience",
                table: "Student");
        }
    }
}
