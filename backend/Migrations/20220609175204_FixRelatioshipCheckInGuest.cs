using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class FixRelatioshipCheckInGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_CheckIns_RoomId",
                table: "Guests");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_CheckInId",
                table: "Guests",
                column: "CheckInId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_CheckIns_CheckInId",
                table: "Guests",
                column: "CheckInId",
                principalTable: "CheckIns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_CheckIns_CheckInId",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_CheckInId",
                table: "Guests");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_CheckIns_RoomId",
                table: "Guests",
                column: "RoomId",
                principalTable: "CheckIns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
