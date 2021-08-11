using Microsoft.EntityFrameworkCore.Migrations;

namespace NewZealand_Courier.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourierReceiver_CourierDeliver_CourierDeliver_IDId",
                table: "CourierReceiver");

            migrationBuilder.DropIndex(
                name: "IX_CourierReceiver_CourierDeliver_IDId",
                table: "CourierReceiver");

            migrationBuilder.DropColumn(
                name: "CourierDeliver_IDId",
                table: "CourierReceiver");

            migrationBuilder.DropColumn(
                name: "CourierDeliveryID",
                table: "CourierReceiver");

            migrationBuilder.AddColumn<decimal>(
                name: "Barcode",
                table: "CourierReceiver",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "CourierReceiver");

            migrationBuilder.AddColumn<int>(
                name: "CourierDeliver_IDId",
                table: "CourierReceiver",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourierDeliveryID",
                table: "CourierReceiver",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourierReceiver_CourierDeliver_IDId",
                table: "CourierReceiver",
                column: "CourierDeliver_IDId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourierReceiver_CourierDeliver_CourierDeliver_IDId",
                table: "CourierReceiver",
                column: "CourierDeliver_IDId",
                principalTable: "CourierDeliver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
