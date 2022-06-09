using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class FixRoomModelRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Guests_GuestId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_GuestId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Guests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guests_RoomId",
                table: "Guests",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Rooms_RoomId",
                table: "Guests",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Rooms_RoomId",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_RoomId",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Guests");

            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_GuestId",
                table: "Rooms",
                column: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Guests_GuestId",
                table: "Rooms",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
