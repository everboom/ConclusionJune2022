using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demos.Day4.DemoModel.Migrations
{
    public partial class RoomSeats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfSeats",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfSeats",
                table: "Rooms");
        }
    }

}
