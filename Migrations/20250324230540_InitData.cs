using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_SSMS.Migrations
{
    /// <inheritdoc />
    public partial class InitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lat",
                table: "VehiculeOBUs");

            migrationBuilder.DropColumn(
                name: "lon",
                table: "VehiculeOBUs");

            migrationBuilder.DropColumn(
                name: "Anomalie",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "lat",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "lon",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Anomalie",
                table: "Smartwatches");

            migrationBuilder.DropColumn(
                name: "lat",
                table: "Smartwatches");

            migrationBuilder.DropColumn(
                name: "lat",
                table: "Smartphones");

            migrationBuilder.DropColumn(
                name: "lon",
                table: "Smartphones");

            migrationBuilder.DropColumn(
                name: "nbConnecteddivces",
                table: "Patientss");

            migrationBuilder.DropColumn(
                name: "ReportofsuppressionaOrdeletionPath",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "lon",
                table: "Smartwatches",
                newName: "TGS_capte");

            migrationBuilder.RenameColumn(
                name: "IdSmartwatchNewGen",
                table: "Smartwatches",
                newName: "IdSmartwatch");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Timestamp",
                table: "VehiculeOBUs",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "VehiculeOBUs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "VehiculeOBUs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Timestamp",
                table: "SmartwatchNewGens",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<double>(
                name: "Body_Temperature",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Derived_BMI",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Derived_HRV",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Derived_MAP",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Derived_Pulse_Pressure",
                table: "SmartwatchNewGens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Diastolic_Blood_Pressure",
                table: "SmartwatchNewGens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Heart_Rate",
                table: "SmartwatchNewGens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Oxygen_Saturation",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Respiratory_Rate",
                table: "SmartwatchNewGens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Systolic_Blood_Pressure",
                table: "SmartwatchNewGens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "SmartwatchNewGens",
                type: "float",
                nullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Timestamp",
                table: "Smartwatches",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "FC_capte",
                table: "Smartwatches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Smartwatches",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Smartwatches",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "PAD_capte",
                table: "Smartwatches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PAS_capte",
                table: "Smartwatches",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Timestamp",
                table: "Smartphones",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Smartphones",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Smartphones",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<bool>(
                name: "SubscriptionPlan",
                table: "Patientss",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Patientss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Patientss",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "IdCGMP",
                table: "Patientss",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdSmartwatchNewGenP",
                table: "Patientss",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdSmartwatchP",
                table: "Patientss",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdVehiculeOBUP",
                table: "Patientss",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdphoneP",
                table: "Patientss",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Centress",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Centress",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Timestamp",
                table: "Centress",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "VehiculeOBUs");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "VehiculeOBUs");

            migrationBuilder.DropColumn(
                name: "Body_Temperature",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Derived_BMI",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Derived_HRV",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Derived_MAP",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Derived_Pulse_Pressure",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Diastolic_Blood_Pressure",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Heart_Rate",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Oxygen_Saturation",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Respiratory_Rate",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Systolic_Blood_Pressure",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "SmartwatchNewGens");

            migrationBuilder.DropColumn(
                name: "FC_capte",
                table: "Smartwatches");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Smartwatches");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Smartwatches");

            migrationBuilder.DropColumn(
                name: "PAD_capte",
                table: "Smartwatches");

            migrationBuilder.DropColumn(
                name: "PAS_capte",
                table: "Smartwatches");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Smartphones");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Smartphones");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Patientss");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Patientss");

            migrationBuilder.DropColumn(
                name: "IdCGMP",
                table: "Patientss");

            migrationBuilder.DropColumn(
                name: "IdSmartwatchNewGenP",
                table: "Patientss");

            migrationBuilder.DropColumn(
                name: "IdSmartwatchP",
                table: "Patientss");

            migrationBuilder.DropColumn(
                name: "IdVehiculeOBUP",
                table: "Patientss");

            migrationBuilder.DropColumn(
                name: "IdphoneP",
                table: "Patientss");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Centress");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Centress");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Centress");

            migrationBuilder.RenameColumn(
                name: "TGS_capte",
                table: "Smartwatches",
                newName: "lon");

            migrationBuilder.RenameColumn(
                name: "IdSmartwatch",
                table: "Smartwatches",
                newName: "IdSmartwatchNewGen");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Timestamp",
                table: "VehiculeOBUs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AddColumn<float>(
                name: "lat",
                table: "VehiculeOBUs",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "lon",
                table: "VehiculeOBUs",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Timestamp",
                table: "SmartwatchNewGens",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AddColumn<bool>(
                name: "Anomalie",
                table: "SmartwatchNewGens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "lat",
                table: "SmartwatchNewGens",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "lon",
                table: "SmartwatchNewGens",
                type: "real",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Timestamp",
                table: "Smartwatches",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AddColumn<bool>(
                name: "Anomalie",
                table: "Smartwatches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "lat",
                table: "Smartwatches",
                type: "real",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Timestamp",
                table: "Smartphones",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AddColumn<float>(
                name: "lat",
                table: "Smartphones",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "lon",
                table: "Smartphones",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<bool>(
                name: "SubscriptionPlan",
                table: "Patientss",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "nbConnecteddivces",
                table: "Patientss",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReportofsuppressionaOrdeletionPath",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
