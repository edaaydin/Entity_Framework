using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03_EF_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class uc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_AuthorId",
                table: "Profiles",
                column: "AuthorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Authors_AuthorId",
                table: "Profiles",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Authors_AuthorId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_AuthorId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Profiles");
        }
    }
}
