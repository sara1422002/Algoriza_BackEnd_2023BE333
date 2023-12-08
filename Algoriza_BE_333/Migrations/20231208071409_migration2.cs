using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Algoriza_BE_333.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_admins_ApplicationUsers_UserRoleId",
                table: "admins");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_ApplicationUsers_UserRoleID",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_patients_ApplicationUsers_UserRoleID",
                table: "patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserRoleName",
                table: "ApplicationUsers");

            migrationBuilder.RenameColumn(
                name: "UserRoleID",
                table: "ApplicationUsers",
                newName: "AccessFailedCount");

            migrationBuilder.AlterColumn<string>(
                name: "UserRoleID",
                table: "patients",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "patients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserRoleID",
                table: "doctors",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ApplicationUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "ApplicationUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "ApplicationUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "ApplicationUsers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "ApplicationUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "ApplicationUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserRoleId",
                table: "admins",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_admins_ApplicationUsers_UserRoleId",
                table: "admins",
                column: "UserRoleId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_ApplicationUsers_UserRoleID",
                table: "doctors",
                column: "UserRoleID",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_ApplicationUsers_UserRoleID",
                table: "patients",
                column: "UserRoleID",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_admins_ApplicationUsers_UserRoleId",
                table: "admins");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_ApplicationUsers_UserRoleID",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_patients_ApplicationUsers_UserRoleID",
                table: "patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "ApplicationUsers");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "ApplicationUsers",
                newName: "UserRoleID");

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleID",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleID",
                table: "doctors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleID",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "UserRoleName",
                table: "ApplicationUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "admins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers",
                column: "UserRoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_admins_ApplicationUsers_UserRoleId",
                table: "admins",
                column: "UserRoleId",
                principalTable: "ApplicationUsers",
                principalColumn: "UserRoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_ApplicationUsers_UserRoleID",
                table: "doctors",
                column: "UserRoleID",
                principalTable: "ApplicationUsers",
                principalColumn: "UserRoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patients_ApplicationUsers_UserRoleID",
                table: "patients",
                column: "UserRoleID",
                principalTable: "ApplicationUsers",
                principalColumn: "UserRoleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
