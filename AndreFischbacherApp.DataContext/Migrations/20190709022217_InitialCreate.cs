using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AndreFischbacherApp.DataContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CareerContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    PositionTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    LastModified = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterestContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Contents = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CareerInformationContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CareerContentId = table.Column<Guid>(nullable: false),
                    CareerInformation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerInformationContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CareerInformationContents_CareerContents_CareerContentId",
                        column: x => x.CareerContentId,
                        principalTable: "CareerContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareerInformationContents_CareerContentId",
                table: "CareerInformationContents",
                column: "CareerContentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutContents");

            migrationBuilder.DropTable(
                name: "CareerInformationContents");

            migrationBuilder.DropTable(
                name: "InterestContents");

            migrationBuilder.DropTable(
                name: "CareerContents");
        }
    }
}
