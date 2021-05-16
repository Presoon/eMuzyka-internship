using Microsoft.EntityFrameworkCore.Migrations;

namespace eMuzyka.Infrastructure.Migrations
{
    public partial class AddCoversToAlbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Albums");
        }
    }
}
