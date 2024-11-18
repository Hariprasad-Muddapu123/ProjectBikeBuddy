using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeBuddy.Migrations
{
    /// <inheritdoc />
    public partial class Images : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AadharUrl",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DrivingLicenceUrl",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Users");

            migrationBuilder.AddColumn<byte[]>(
                name: "AadhaarImage",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "DrivingLicenseImage",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfileImage",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AadhaarImage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DrivingLicenseImage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "AadharUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrivingLicenceUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
