using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zusammen.Data.Migrations
{
    /// <inheritdoc />
    public partial class userDBtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "schoolhousing",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "schoolyear",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "schoolhousing",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "schoolyear",
                table: "AspNetUsers");
        }
    }
}
