using Microsoft.EntityFrameworkCore.Migrations;

namespace AndreFischbacherApp.DataContext.Migrations
{
    public partial class isSubcard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubcard",
                table: "AboutContents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AboutContents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubcard",
                table: "AboutContents");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AboutContents");
        }
    }
}
