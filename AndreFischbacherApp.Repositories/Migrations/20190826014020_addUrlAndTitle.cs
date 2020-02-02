using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AndreFischbacherApp.DataContext.Migrations
{
    public partial class addUrlAndTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "AboutContents");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "InterestContents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "InterestContents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "InterestContents");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "InterestContents");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Year",
                table: "AboutContents",
                nullable: true);
        }
    }
}
