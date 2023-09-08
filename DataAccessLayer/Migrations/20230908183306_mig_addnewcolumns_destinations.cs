using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_addnewcolumns_destinations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DExplanation1",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DExplanation2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DExplanation3",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DImage1",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DImage2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DImageLarge",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DTitle",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DExplanation1",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DExplanation2",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DExplanation3",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DImage1",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DImage2",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DImageLarge",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DTitle",
                table: "Destinations");
        }
    }
}
