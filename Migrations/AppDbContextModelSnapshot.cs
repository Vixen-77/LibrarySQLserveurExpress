﻿// <auto-generated />
using System;
using LibrarySSMS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library_SSMS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibrarySSMS.Models.Admin", b =>
                {
                    b.Property<Guid>("UIDKEY")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSuspended")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportofsuppressionaOrdeletionPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("nbDeletedacount")
                        .HasColumnType("int");

                    b.Property<int?>("nbSuspendedacount")
                        .HasColumnType("int");

                    b.HasKey("UIDKEY");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("LibrarySSMS.Models.CGM", b =>
                {
                    b.Property<Guid>("IdCGM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ADRMAC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Glycemia")
                        .HasColumnType("real");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("battry")
                        .HasColumnType("real");

                    b.Property<Guid>("idporteur")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isGlyLow")
                        .HasColumnType("bit");

                    b.Property<bool>("isGlyhigh")
                        .HasColumnType("bit");

                    b.HasKey("IdCGM");

                    b.ToTable("CGMs");
                });

            modelBuilder.Entity("LibrarySSMS.Models.Centre", b =>
                {
                    b.Property<Guid>("IdC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nbamb")
                        .HasColumnType("int");

                    b.Property<string>("NomC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdC");

                    b.HasIndex("UID");

                    b.ToTable("Centress");
                });

            modelBuilder.Entity("LibrarySSMS.Models.Patient", b =>
                {
                    b.Property<Guid>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AccountStatus")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdProche")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<bool>("IsValidated")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailMed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalRecordPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NbSec")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<bool>("SubscriptionPlan")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<int?>("nbConnecteddivces")
                        .HasColumnType("int");

                    b.HasKey("UID");

                    b.HasIndex("IdProche");

                    b.ToTable("Patientss");
                });

            modelBuilder.Entity("LibrarySSMS.Models.ProS", b =>
                {
                    b.Property<Guid>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AcceptRequest")
                        .HasColumnType("bit");

                    b.Property<bool>("AccountStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("CheckedSchedule")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SubscriptionPlan")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.HasKey("UID");

                    b.ToTable("ProSs");
                });

            modelBuilder.Entity("LibrarySSMS.Models.Proche", b =>
                {
                    b.Property<Guid>("IdProche")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProche");

                    b.ToTable("Proches");
                });

            modelBuilder.Entity("LibrarySSMS.Models.RespHop", b =>
                {
                    b.Property<Guid>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AccountStatus")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SubscriptionPlan")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("isAmbulanceReady")
                        .HasColumnType("bit");

                    b.HasKey("UID");

                    b.ToTable("RespHops");
                });

            modelBuilder.Entity("LibrarySSMS.Models.Smartphone", b =>
                {
                    b.Property<Guid>("Idphone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ADRMAC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConnected")
                        .HasColumnType("bit");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<float>("battry")
                        .HasColumnType("real");

                    b.Property<Guid>("idporteur")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("lat")
                        .HasColumnType("real");

                    b.Property<float>("lon")
                        .HasColumnType("real");

                    b.HasKey("Idphone");

                    b.ToTable("Smartphones");
                });

            modelBuilder.Entity("LibrarySSMS.Models.Smartwatch", b =>
                {
                    b.Property<Guid>("IdSmartwatchNewGen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ADRMAC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Anomalie")
                        .HasColumnType("bit");

                    b.Property<bool>("IsConnected")
                        .HasColumnType("bit");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("idporteur")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("lat")
                        .HasColumnType("real");

                    b.Property<float?>("lon")
                        .HasColumnType("real");

                    b.HasKey("IdSmartwatchNewGen");

                    b.ToTable("Smartwatches");
                });

            modelBuilder.Entity("LibrarySSMS.Models.SmartwatchNewGen", b =>
                {
                    b.Property<Guid>("IdSmartwatchNewGen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ADRMAC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Anomalie")
                        .HasColumnType("bit");

                    b.Property<bool>("IsConnected")
                        .HasColumnType("bit");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("idporteur")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("lat")
                        .HasColumnType("real");

                    b.Property<float?>("lon")
                        .HasColumnType("real");

                    b.HasKey("IdSmartwatchNewGen");

                    b.ToTable("SmartwatchNewGens");
                });

            modelBuilder.Entity("LibrarySSMS.Models.SuperAdmin", b =>
                {
                    b.Property<Guid>("UIDKEY")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<Guid>("UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("nbDeletedAdminacount")
                        .HasColumnType("int");

                    b.Property<int?>("nbSuspendedAdminacount")
                        .HasColumnType("int");

                    b.HasKey("UIDKEY");

                    b.ToTable("SuperAdmins");
                });

            modelBuilder.Entity("LibrarySSMS.Models.VehiculeOBU", b =>
                {
                    b.Property<Guid>("IdVehiculeOBU")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ADRMAC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<float>("battry")
                        .HasColumnType("real");

                    b.Property<Guid>("idporteur")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isRouteur")
                        .HasColumnType("bit");

                    b.Property<float>("lat")
                        .HasColumnType("real");

                    b.Property<float>("lon")
                        .HasColumnType("real");

                    b.Property<int>("typecar")
                        .HasColumnType("int");

                    b.HasKey("IdVehiculeOBU");

                    b.ToTable("VehiculeOBUs");
                });

            modelBuilder.Entity("LibrarySSMS.Models.Centre", b =>
                {
                    b.HasOne("LibrarySSMS.Models.RespHop", "RespHop")
                        .WithMany()
                        .HasForeignKey("UID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RespHop");
                });

            modelBuilder.Entity("LibrarySSMS.Models.Patient", b =>
                {
                    b.HasOne("LibrarySSMS.Models.Proche", "Proche")
                        .WithMany()
                        .HasForeignKey("IdProche")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proche");
                });
#pragma warning restore 612, 618
        }
    }
}
