using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Skillss");

            migrationBuilder.DropColumn(
                name: "SkillsSpan",
                table: "Skillss");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Experiences",
                newName: "FirstDate");

            migrationBuilder.AddColumn<string>(
                name: "GithubUrl",
                table: "Hellos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramUrl",
                table: "Hellos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedinUrl",
                table: "Hellos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterUrl",
                table: "Hellos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Experiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GithubUrl",
                table: "Hellos");

            migrationBuilder.DropColumn(
                name: "InstagramUrl",
                table: "Hellos");

            migrationBuilder.DropColumn(
                name: "LinkedinUrl",
                table: "Hellos");

            migrationBuilder.DropColumn(
                name: "TwitterUrl",
                table: "Hellos");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "FirstDate",
                table: "Experiences",
                newName: "Date");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Skillss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillsSpan",
                table: "Skillss",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
