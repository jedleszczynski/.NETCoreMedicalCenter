﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesMedicalCenter.Models;

namespace RazorPagesMedicalCenter.Migrations
{
    [DbContext(typeof(RazorPagesMedicalCenterContext))]
    [Migration("20190505212756_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesMedicalCenter.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PatientCity");

                    b.Property<string>("PatientEmail");

                    b.Property<string>("PatientFName");

                    b.Property<string>("PatientLName");

                    b.Property<string>("PatientPhoneNum");

                    b.Property<string>("PatientStreet");

                    b.Property<string>("PatientZIP");

                    b.HasKey("PatientID");

                    b.ToTable("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
