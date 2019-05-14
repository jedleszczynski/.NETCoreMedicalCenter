﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesMedicalCenter.Models;

namespace RazorPagesMedicalCenter.Migrations
{
    [DbContext(typeof(RazorPagesMedicalCenterContext))]
    [Migration("20190514045124_isClinicalPatient")]
    partial class isClinicalPatient
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesMedicalCenter.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AppointmentPrice");

                    b.Property<int>("MedProcedureID");

                    b.Property<int>("PatientID");

                    b.Property<int>("ReferralID");

                    b.HasKey("AppointmentID");

                    b.HasIndex("PatientID");

                    b.HasIndex("ReferralID");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("RazorPagesMedicalCenter.Models.MedProcedure", b =>
                {
                    b.Property<int>("MedProcedureID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentID");

                    b.Property<string>("MedProcedureName");

                    b.Property<string>("MedProcedureType");

                    b.Property<int>("PhysicianID");

                    b.HasKey("MedProcedureID");

                    b.HasIndex("AppointmentID");

                    b.HasIndex("PhysicianID");

                    b.ToTable("MedProcedure");
                });

            modelBuilder.Entity("RazorPagesMedicalCenter.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PatientCity");

                    b.Property<DateTime>("PatientDateOfBirth");

                    b.Property<string>("PatientEmail");

                    b.Property<string>("PatientFName");

                    b.Property<bool>("PatientIsClinical");

                    b.Property<string>("PatientLName");

                    b.Property<string>("PatientPhoneNum");

                    b.Property<string>("PatientStreet");

                    b.Property<string>("PatientZIP");

                    b.HasKey("PatientID");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("RazorPagesMedicalCenter.Models.Physician", b =>
                {
                    b.Property<int>("PhysicianID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhysicianFName");

                    b.Property<string>("PhysicianLName");

                    b.HasKey("PhysicianID");

                    b.ToTable("Physician");
                });

            modelBuilder.Entity("RazorPagesMedicalCenter.Models.Referral", b =>
                {
                    b.Property<int>("ReferralID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Origin");

                    b.HasKey("ReferralID");

                    b.ToTable("Referral");
                });

            modelBuilder.Entity("RazorPagesMedicalCenter.Models.Appointment", b =>
                {
                    b.HasOne("RazorPagesMedicalCenter.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RazorPagesMedicalCenter.Models.Referral", "Referral")
                        .WithMany()
                        .HasForeignKey("ReferralID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RazorPagesMedicalCenter.Models.MedProcedure", b =>
                {
                    b.HasOne("RazorPagesMedicalCenter.Models.Appointment")
                        .WithMany("MedProcedures")
                        .HasForeignKey("AppointmentID");

                    b.HasOne("RazorPagesMedicalCenter.Models.Physician", "Physician")
                        .WithMany("MedProcedures")
                        .HasForeignKey("PhysicianID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}