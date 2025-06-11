using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oommoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProperties_Venue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "current_management",
                table: "venue",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "venue",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "opened_on",
                table: "venue",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone_number",
                table: "venue",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "show_score",
                table: "venue",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "stage_door",
                table: "venue",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "current_management",
                table: "venue");

            migrationBuilder.DropColumn(
                name: "location",
                table: "venue");

            migrationBuilder.DropColumn(
                name: "opened_on",
                table: "venue");

            migrationBuilder.DropColumn(
                name: "phone_number",
                table: "venue");

            migrationBuilder.DropColumn(
                name: "show_score",
                table: "venue");

            migrationBuilder.DropColumn(
                name: "stage_door",
                table: "venue");
        }
    }
}
