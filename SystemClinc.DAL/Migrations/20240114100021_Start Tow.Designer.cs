﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SystemClinc.DAL.MyDbContext;

#nullable disable

namespace SystemClinc.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240114100021_Start Tow")]
    partial class StartTow
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Clinic_Registration_and_Management_System.Model.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentID"), 1L, 1);

                    b.Property<int?>("AdminID")
                        .HasColumnType("int");

                    b.Property<string>("Appointment_Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Appointment_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Appointment_Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientID")
                        .HasColumnType("int");

                    b.Property<int?>("SpecializationID")
                        .HasColumnType("int");

                    b.HasKey("AppointmentID");

                    b.HasIndex("AdminID");

                    b.HasIndex("PatientID");

                    b.HasIndex("SpecializationID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Clinic_Registration_and_Management_System.Model.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Clinic_Registration_and_Management_System.Model.Specialization", b =>
                {
                    b.Property<int>("SpecializationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecializationID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecializationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SpecializationID");

                    b.ToTable("Specialization");
                });

            modelBuilder.Entity("SystemClinc.Model.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Clinic_Registration_and_Management_System.Model.Appointment", b =>
                {
                    b.HasOne("SystemClinc.Model.Admin", "Admin")
                        .WithMany("Appointments")
                        .HasForeignKey("AdminID");

                    b.HasOne("Clinic_Registration_and_Management_System.Model.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientID");

                    b.HasOne("Clinic_Registration_and_Management_System.Model.Specialization", "Specialization")
                        .WithMany("Appointments")
                        .HasForeignKey("SpecializationID");

                    b.Navigation("Admin");

                    b.Navigation("Patient");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("Clinic_Registration_and_Management_System.Model.Patient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Clinic_Registration_and_Management_System.Model.Specialization", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("SystemClinc.Model.Admin", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
