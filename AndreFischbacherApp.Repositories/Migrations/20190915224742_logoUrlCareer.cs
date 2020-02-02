using Microsoft.EntityFrameworkCore.Migrations;

namespace AndreFischbacherApp.DataContext.Migrations
{
    public partial class logoUrlCareer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "CareerContents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "CareerContents");
        }
    }
}
