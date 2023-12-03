using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Algoriza_BE_333.Migrations
{
    public partial class ModifyAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_appointments_PatientID",
                table: "appointments",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_patients_PatientID",
                table: "appointments",
                column: "PatientID",
                principalTable: "patients",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_patients_PatientID",
                table: "appointments");

            migrationBuilder.DropIndex(
                name: "IX_appointments_PatientID",
                table: "appointments");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "appointments");
        }
    }
}
