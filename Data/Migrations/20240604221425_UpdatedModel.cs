using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCSD_Job_Search.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ccode",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "Division",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "Job");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Job",
                newName: "TermsOfEmployment");

            migrationBuilder.RenameColumn(
                name: "JobCategory",
                table: "Job",
                newName: "JobFamily");

            migrationBuilder.AddColumn<string>(
                name: "ClassCode",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Classification",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DistinguishingCharacteristics",
                table: "Job",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentsRequiredAtTimeOfApplication",
                table: "Job",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EssentialDutiesAndResponsibilities",
                table: "Job",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExamplesOfAssignedWorkAreas",
                table: "Job",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExamplesOfEquipmentSupplies",
                table: "Job",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FLSAStatus",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KnowledgeSkillsandAbilities",
                table: "Job",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionRequirements",
                table: "Job",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PositionSummary",
                table: "Job",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "WorkEnvironment",
                table: "Job",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassCode",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "Classification",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "DistinguishingCharacteristics",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "DocumentsRequiredAtTimeOfApplication",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "EssentialDutiesAndResponsibilities",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "ExamplesOfAssignedWorkAreas",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "ExamplesOfEquipmentSupplies",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "FLSAStatus",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "KnowledgeSkillsandAbilities",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "PositionRequirements",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "PositionSummary",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "WorkEnvironment",
                table: "Job");

            migrationBuilder.RenameColumn(
                name: "TermsOfEmployment",
                table: "Job",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "JobFamily",
                table: "Job",
                newName: "JobCategory");

            migrationBuilder.AddColumn<string>(
                name: "Ccode",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Division",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
