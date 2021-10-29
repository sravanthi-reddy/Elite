using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentTechProtfolio.Migrations
{
    public partial class finalChangess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GitHubUrl",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedInProfile",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StackOverflowUrl",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GitHubUrl",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "LinkedInProfile",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StackOverflowUrl",
                table: "Student");
        }
    }
}
