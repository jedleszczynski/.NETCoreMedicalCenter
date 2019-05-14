using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMedicalCenter.Migrations
{
    public partial class isClinicalPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PatientIsClinical",
                table: "Patient",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Physician",
                columns: table => new
                {
                    PhysicianID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhysicianFName = table.Column<string>(nullable: true),
                    PhysicianLName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physician", x => x.PhysicianID);
                });

            migrationBuilder.CreateTable(
                name: "Referral",
                columns: table => new
                {
                    ReferralID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Origin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referral", x => x.ReferralID);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PatientID = table.Column<int>(nullable: false),
                    ReferralID = table.Column<int>(nullable: false),
                    MedProcedureID = table.Column<int>(nullable: false),
                    AppointmentPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_Appointment_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointment_Referral_ReferralID",
                        column: x => x.ReferralID,
                        principalTable: "Referral",
                        principalColumn: "ReferralID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedProcedure",
                columns: table => new
                {
                    MedProcedureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedProcedureType = table.Column<string>(nullable: true),
                    MedProcedureName = table.Column<string>(nullable: true),
                    PhysicianID = table.Column<int>(nullable: false),
                    AppointmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedProcedure", x => x.MedProcedureID);
                    table.ForeignKey(
                        name: "FK_MedProcedure_Appointment_AppointmentID",
                        column: x => x.AppointmentID,
                        principalTable: "Appointment",
                        principalColumn: "AppointmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedProcedure_Physician_PhysicianID",
                        column: x => x.PhysicianID,
                        principalTable: "Physician",
                        principalColumn: "PhysicianID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientID",
                table: "Appointment",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ReferralID",
                table: "Appointment",
                column: "ReferralID");

            migrationBuilder.CreateIndex(
                name: "IX_MedProcedure_AppointmentID",
                table: "MedProcedure",
                column: "AppointmentID");

            migrationBuilder.CreateIndex(
                name: "IX_MedProcedure_PhysicianID",
                table: "MedProcedure",
                column: "PhysicianID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedProcedure");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Physician");

            migrationBuilder.DropTable(
                name: "Referral");

            migrationBuilder.DropColumn(
                name: "PatientIsClinical",
                table: "Patient");
        }
    }
}
