using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_SSMS.Migrations
{
    /// <inheritdoc />
    public partial class SimpleRajout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Patientss",
                newName: "Adresse");

            migrationBuilder.AddColumn<int>(
                name: "DBmanipulation",
                table: "SuperAdmins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "bloodType",
                table: "Patientss",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DBmanipulation",
                table: "SuperAdmins");

            migrationBuilder.DropColumn(
                name: "bloodType",
                table: "Patientss");

            migrationBuilder.RenameColumn(
                name: "Adresse",
                table: "Patientss",
                newName: "City");
        }
    }
}
