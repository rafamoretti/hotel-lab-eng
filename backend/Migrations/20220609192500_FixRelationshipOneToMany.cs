using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class FixRelationshipOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_CheckIns_CheckInId",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_CheckInId",
                table: "Guests");

            migrationBuilder.AlterColumn<int>(
                name: "CheckInId",
                table: "Guests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_CheckIns_CheckInId",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_CheckInId",
                table: "Guests");

            migrationBuilder.AlterColumn<int>(
                name: "CheckInId",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
