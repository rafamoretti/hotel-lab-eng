using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class AddedRelatioshipCheckInGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CheckInId",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_CheckIns_RoomId",
                table: "Guests",
                column: "RoomId",
                principalTable: "CheckIns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_CheckIns_RoomId",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "CheckInId",
                table: "Guests");
        }
    }
}
