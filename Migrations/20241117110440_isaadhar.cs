using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeBuddy.Migrations
{
    /// <inheritdoc />
    public partial class isaadhar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAadhaarUploaded",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDrivingLicenseUploaded",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsAadhaarUploaded",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDrivingLicenseUploaded",
                table: "Users");
        }
    }
}
