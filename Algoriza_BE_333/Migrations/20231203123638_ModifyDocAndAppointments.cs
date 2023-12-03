using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Algoriza_BE_333.Migrations
{
    public partial class ModifyDocAndAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "doctors");
        }
    }
}
