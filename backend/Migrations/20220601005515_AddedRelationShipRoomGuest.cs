using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class AddedRelationShipRoomGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "GuestId",
                table: "Rooms",
                type: "varbinary(16)",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
