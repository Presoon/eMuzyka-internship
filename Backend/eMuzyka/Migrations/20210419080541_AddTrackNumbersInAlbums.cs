using Microsoft.EntityFrameworkCore.Migrations;

namespace eMuzyka.Migrations
{
    public partial class AddTrackNumbersInAlbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrackNumber",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrackNumber",
                table: "Tracks");
        }
    }
}
