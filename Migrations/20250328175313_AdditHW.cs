using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_SSMS.Migrations
{
    /// <inheritdoc />
    public partial class AdditHW : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "SmartwatchNewGens");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Patientss",
                newName: "Name");

            migrationBuilder.AddColumn<Guid>(
                name: "IdVehiculeOBUSV",
                table: "RespHops",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdSmartphoneProS",
                table: "ProSs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdVehiculeOBUSVP",
                table: "ProSs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Patientss",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Patientss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Patientss",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdVehiculeOBUSV",
                table: "RespHops");

            migrationBuilder.DropColumn(
                name: "IdSmartphoneProS",
                table: "ProSs");

            migrationBuilder.DropColumn(
                name: "IdVehiculeOBUSVP",
                table: "ProSs");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Patientss");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Patientss");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Patientss");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Patientss",
                newName: "FullName");

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: true);
        }
    }
}
