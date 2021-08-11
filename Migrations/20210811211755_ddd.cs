using Microsoft.EntityFrameworkCore.Migrations;

namespace NewZealand_Courier.Migrations
{
    public partial class ddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryPerson_Name = table.Column<string>(nullable: true),
                    CourierDeliverId = table.Column<int>(nullable: true),
                    Vehicle_Name = table.Column<string>(nullable: true),
                    Vehicle_Make = table.Column<string>(nullable: true),
                    Vehicle_Redgo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_CourierDeliver_CourierDeliverId",
                        column: x => x.CourierDeliverId,
                        principalTable: "CourierDeliver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CourierDeliverId",
                table: "Vehicles",
                column: "CourierDeliverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
