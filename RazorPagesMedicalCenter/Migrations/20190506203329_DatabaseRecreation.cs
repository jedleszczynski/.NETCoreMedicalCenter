using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMedicalCenter.Migrations
{
    public partial class DatabaseRecreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PatientDateOfBirth",
                table: "Patient",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientDateOfBirth",
                table: "Patient");
        }
    }
}
