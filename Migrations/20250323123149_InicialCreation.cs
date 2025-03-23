using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_SSMS.Migrations
{
    /// <inheritdoc />
    public partial class InicialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    UIDKEY = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    nbSuspendedacount = table.Column<int>(type: "int", nullable: true),
                    nbDeletedacount = table.Column<int>(type: "int", nullable: true),
                    ReportofsuppressionaOrdeletionPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSuspended = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.UIDKEY);
                });

            migrationBuilder.CreateTable(
                name: "CGMs",
                columns: table => new
                {
                    IdCGM = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ADRMAC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idporteur = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Glycemia = table.Column<float>(type: "real", nullable: true),
                    isGlyhigh = table.Column<bool>(type: "bit", nullable: false),
                    isGlyLow = table.Column<bool>(type: "bit", nullable: false),
                    battry = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CGMs", x => x.IdCGM);
                });

            migrationBuilder.CreateTable(
                name: "Proches",
                columns: table => new
                {
                    IdProche = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proches", x => x.IdProche);
                });

            migrationBuilder.CreateTable(
                name: "ProSs",
                columns: table => new
                {
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    AcceptRequest = table.Column<bool>(type: "bit", nullable: false),
                    CheckedSchedule = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccountStatus = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    SubscriptionPlan = table.Column<bool>(type: "bit", nullable: false),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProSs", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "RespHops",
                columns: table => new
                {
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    isAmbulanceReady = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccountStatus = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    SubscriptionPlan = table.Column<bool>(type: "bit", nullable: false),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespHops", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "Smartphones",
                columns: table => new
                {
                    Idphone = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ADRMAC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idporteur = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    battry = table.Column<float>(type: "real", nullable: false),
                    IsConnected = table.Column<bool>(type: "bit", nullable: false),
                    lat = table.Column<float>(type: "real", nullable: false),
                    lon = table.Column<float>(type: "real", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smartphones", x => x.Idphone);
                });

            migrationBuilder.CreateTable(
                name: "Smartwatches",
                columns: table => new
                {
                    IdSmartwatchNewGen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ADRMAC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idporteur = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsConnected = table.Column<bool>(type: "bit", nullable: false),
                    Anomalie = table.Column<bool>(type: "bit", nullable: false),
                    lat = table.Column<float>(type: "real", nullable: true),
                    lon = table.Column<float>(type: "real", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smartwatches", x => x.IdSmartwatchNewGen);
                });

            migrationBuilder.CreateTable(
                name: "SmartwatchNewGens",
                columns: table => new
                {
                    IdSmartwatchNewGen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ADRMAC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idporteur = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsConnected = table.Column<bool>(type: "bit", nullable: false),
                    Anomalie = table.Column<bool>(type: "bit", nullable: false),
                    lat = table.Column<float>(type: "real", nullable: true),
                    lon = table.Column<float>(type: "real", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartwatchNewGens", x => x.IdSmartwatchNewGen);
                });

            migrationBuilder.CreateTable(
                name: "SuperAdmins",
                columns: table => new
                {
                    UIDKEY = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: true),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    nbSuspendedAdminacount = table.Column<int>(type: "int", nullable: true),
                    nbDeletedAdminacount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperAdmins", x => x.UIDKEY);
                });

            migrationBuilder.CreateTable(
                name: "VehiculeOBUs",
                columns: table => new
                {
                    IdVehiculeOBU = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ADRMAC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idporteur = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    battry = table.Column<float>(type: "real", nullable: false),
                    typecar = table.Column<int>(type: "int", nullable: false),
                    isRouteur = table.Column<bool>(type: "bit", nullable: false),
                    lat = table.Column<float>(type: "real", nullable: false),
                    lon = table.Column<float>(type: "real", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculeOBUs", x => x.IdVehiculeOBU);
                });

            migrationBuilder.CreateTable(
                name: "Patientss",
                columns: table => new
                {
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailMed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NbSec = table.Column<int>(type: "int", nullable: true),
                    IdProche = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccountStatus = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    SubscriptionPlan = table.Column<bool>(type: "bit", nullable: false),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    nbConnecteddivces = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsValidated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patientss", x => x.UID);
                    table.ForeignKey(
                        name: "FK_Patientss_Proches_IdProche",
                        column: x => x.IdProche,
                        principalTable: "Proches",
                        principalColumn: "IdProche",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Centress",
                columns: table => new
                {
                    IdC = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nbamb = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centress", x => x.IdC);
                    table.ForeignKey(
                        name: "FK_Centress_RespHops_UID",
                        column: x => x.UID,
                        principalTable: "RespHops",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Centress_UID",
                table: "Centress",
                column: "UID");

            migrationBuilder.CreateIndex(
                name: "IX_Patientss_IdProche",
                table: "Patientss",
                column: "IdProche");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Centress");

            migrationBuilder.DropTable(
                name: "CGMs");

            migrationBuilder.DropTable(
                name: "Patientss");

            migrationBuilder.DropTable(
                name: "ProSs");

            migrationBuilder.DropTable(
                name: "Smartphones");

            migrationBuilder.DropTable(
                name: "Smartwatches");

            migrationBuilder.DropTable(
                name: "SmartwatchNewGens");

            migrationBuilder.DropTable(
                name: "SuperAdmins");

            migrationBuilder.DropTable(
                name: "VehiculeOBUs");

            migrationBuilder.DropTable(
                name: "RespHops");

            migrationBuilder.DropTable(
                name: "Proches");
        }
    }
}
