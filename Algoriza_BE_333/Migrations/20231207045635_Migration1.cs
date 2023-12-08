using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Algoriza_BE_333.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_doctors_DoctorID",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_patients_PatientID",
                table: "appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patients",
                table: "patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctors",
                table: "doctors");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "patients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "doctors",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "patients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "patients",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "doctors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "doctors",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "admins",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_patients",
                table: "patients",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctors",
                table: "doctors",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_doctors_DoctorID",
                table: "appointments",
                column: "DoctorID",
                principalTable: "doctors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_patients_PatientID",
                table: "appointments",
                column: "PatientID",
                principalTable: "patients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_doctors_DoctorID",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_patients_PatientID",
                table: "appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patients",
                table: "patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctors",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "admins");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "patients",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "doctors",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "doctors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_patients",
                table: "patients",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctors",
                table: "doctors",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_doctors_DoctorID",
                table: "appointments",
                column: "DoctorID",
                principalTable: "doctors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_patients_PatientID",
                table: "appointments",
                column: "PatientID",
                principalTable: "patients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
