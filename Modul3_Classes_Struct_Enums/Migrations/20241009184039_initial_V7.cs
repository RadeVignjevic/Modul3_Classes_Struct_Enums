using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modul3_Classes_Struct_Enums.Migrations
{
    /// <inheritdoc />
    public partial class initial_V7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserDescription",
                table: "DboUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserDescription",
                table: "DboUser");
        }
    }
}
