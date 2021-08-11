using Microsoft.EntityFrameworkCore.Migrations;

namespace NewZealand_Courier.Migrations
{
    public partial class sz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email_Id",
                table: "CourierOffice");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "CourierOffice",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "CourierOffice");

            migrationBuilder.AddColumn<string>(
                name: "Email_Id",
                table: "CourierOffice",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
