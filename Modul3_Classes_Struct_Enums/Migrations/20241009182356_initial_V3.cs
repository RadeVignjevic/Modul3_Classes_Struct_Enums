using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modul3_Classes_Struct_Enums.Migrations
{
    /// <inheritdoc />
    public partial class initial_V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Users_UserId",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "DboUser");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "DboPost");

            migrationBuilder.RenameIndex(
                name: "IX_Post_UserId",
                table: "DboPost",
                newName: "IX_DboPost_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DboUser",
                table: "DboUser",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DboPost",
                table: "DboPost",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_DboPost_DboUser_UserId",
                table: "DboPost",
                column: "UserId",
                principalTable: "DboUser",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DboPost_DboUser_UserId",
                table: "DboPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DboUser",
                table: "DboUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DboPost",
                table: "DboPost");

            migrationBuilder.RenameTable(
                name: "DboUser",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "DboPost",
                newName: "Post");

            migrationBuilder.RenameIndex(
                name: "IX_DboPost_UserId",
                table: "Post",
                newName: "IX_Post_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Users_UserId",
                table: "Post",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
