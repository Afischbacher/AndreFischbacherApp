using Microsoft.EntityFrameworkCore.Migrations;

namespace AndreFischbacherApp.DataContext.Migrations
{
    public partial class codeIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LogoUrl",
                table: "CareerContents",
                newName: "IconCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IconCode",
                table: "CareerContents",
                newName: "LogoUrl");
        }
    }
}
