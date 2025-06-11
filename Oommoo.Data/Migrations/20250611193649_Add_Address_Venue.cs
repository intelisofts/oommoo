using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oommoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Address_Venue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "venue_address",
                table: "venue",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "venue_address",
                table: "venue");
        }
    }
}
