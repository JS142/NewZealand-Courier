using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace NewZealand_Courier.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourierDeliver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryPerson_Name = table.Column<string>(nullable: true),
                    DeliveryPerson_Address = table.Column<string>(nullable: true),
                    DeliveryPerson_Contact = table.Column<string>(nullable: true),
                    DeliveryPerson_EmailId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourierDeliver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourierOffice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Office_Name = table.Column<string>(nullable: true),
                    Contact_Number = table.Column<string>(nullable: true),
                    Email_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourierOffice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourierReceiver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Receiver_Name = table.Column<string>(nullable: true),
                    Receiver_Address = table.Column<string>(nullable: true),
                    Receiver_Contact = table.Column<string>(nullable: true),
                    CourierDeliveryID = table.Column<int>(nullable: false),
                    CourierDeliver_IDId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourierReceiver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourierReceiver_CourierDeliver_CourierDeliver_IDId",
                        column: x => x.CourierDeliver_IDId,
                        principalTable: "CourierDeliver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourierReceiver_CourierDeliver_IDId",
                table: "CourierReceiver",
                column: "CourierDeliver_IDId");
            var sqlFile = Path.Combine(".\\DatabaseScript", @"data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourierOffice");

            migrationBuilder.DropTable(
                name: "CourierReceiver");

            migrationBuilder.DropTable(
                name: "CourierDeliver");
        }
    }
}
