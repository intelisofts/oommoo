using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oommoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Capacity_Venue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "capacity",
                table: "venue",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "capacity",
                table: "venue");
        }
    }
}
