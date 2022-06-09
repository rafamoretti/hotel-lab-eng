using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class FixModelCheckIn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_CheckIns_CheckInId",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_CheckInId",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "CheckInId",
                table: "Guests");

            migrationBuilder.AddColumn<int>(
                name: "GuestsId",
                table: "CheckIns",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_GuestsId",
                table: "CheckIns",
                column: "GuestsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIns_Guests_GuestsId",
                table: "CheckIns",
                column: "GuestsId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckIns_Guests_GuestsId",
                table: "CheckIns");

            migrationBuilder.DropIndex(
                name: "IX_CheckIns_GuestsId",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "GuestsId",
                table: "CheckIns");

            migrationBuilder.AddColumn<int>(
                name: "CheckInId",
                table: "Guests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guests_CheckInId",
                table: "Guests",
                column: "CheckInId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_CheckIns_CheckInId",
                table: "Guests",
                column: "CheckInId",
                principalTable: "CheckIns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
