using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zusammen.Data.Migrations
{
    /// <inheritdoc />
    public partial class MajoreditionImhigh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "major",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "major",
                table: "AspNetUsers");
        }
    }
}
