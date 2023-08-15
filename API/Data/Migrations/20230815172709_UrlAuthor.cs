using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UrlAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Urls",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Urls_AuthorId",
                table: "Urls",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urls_AspNetUsers_AuthorId",
                table: "Urls",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urls_AspNetUsers_AuthorId",
                table: "Urls");

            migrationBuilder.DropIndex(
                name: "IX_Urls_AuthorId",
                table: "Urls");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Urls");
        }
    }
}
