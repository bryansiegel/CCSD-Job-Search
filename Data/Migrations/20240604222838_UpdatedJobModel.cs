using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCSD_Job_Search.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedJobModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobCategory",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobCategory",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Job");
        }
    }
}
