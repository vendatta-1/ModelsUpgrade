using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelsUpgrade.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDurationNullability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassportDateInfo_EndDate",
                table: "EduStudentData");

            migrationBuilder.DropColumn(
                name: "PassportDateInfo_StartDate",
                table: "EduStudentData");

            migrationBuilder.RenameColumn(
                name: "WorkPlanDuration_StartDate",
                table: "WorkPlanHeader",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "WorkPlanDuration_EndDate",
                table: "WorkPlanHeader",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "ContractDuration_StartDate",
                table: "RntContractsHeader",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "ContractDuration_EndDate",
                table: "RntContractsHeader",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "Duration_StartDate",
                table: "PItemsHeader",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Duration_EndDate",
                table: "PItemsHeader",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "DurationInfo_StartDate",
                table: "ItemsHeader",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DurationInfo_EndDate",
                table: "ItemsHeader",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "ReservationDuration_StartDate",
                table: "HotelReservationMaster",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "ReservationDuration_EndDate",
                table: "HotelReservationMaster",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "JobDuration_StartDate",
                table: "EmployeeJob",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "JobDuration_EndDate",
                table: "EmployeeJob",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "ContractDuration_StartDate",
                table: "EmpContractHeader",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "ContractDuration_EndDate",
                table: "EmpContractHeader",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "StudentDuration_StartDate",
                table: "EduStudentData",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "StudentDuration_EndDate",
                table: "EduStudentData",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "CourseDuration_StartDate",
                table: "EduStudentCourse",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "CourseDuration_EndDate",
                table: "EduStudentCourse",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "DelegateDuration_StartDate",
                table: "DelegateData",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DelegateDuration_EndDate",
                table: "DelegateData",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "ProjectDuration_StartDate",
                table: "ConProjectsData",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "ProjectDuration_EndDate",
                table: "ConProjectsData",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "Duration_StartDate",
                table: "ConContractorExtractMaster",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Duration_EndDate",
                table: "ConContractorExtractMaster",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "ContractorDuration_StartDate",
                table: "ConContractorData",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "ContractorDuration_EndDate",
                table: "ConContractorData",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "BankContractDuration_StartDate",
                table: "BankContract",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "BankContractDuration_EndDate",
                table: "BankContract",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "FiscalYearDuration_StartDate",
                table: "AccountFiscalYear",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "FiscalYearDuration_EndDate",
                table: "AccountFiscalYear",
                newName: "EndDate");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "RntContractsHeader",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "PItemsHeader",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "ItemsHeader",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "EmployeeJob",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "EmpContractHeader",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "EduStudentData",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "EduStudentCourse",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "DelegateData",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "BankContract",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "WorkPlanHeader",
                newName: "WorkPlanDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "WorkPlanHeader",
                newName: "WorkPlanDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "RntContractsHeader",
                newName: "ContractDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "RntContractsHeader",
                newName: "ContractDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "PItemsHeader",
                newName: "Duration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "PItemsHeader",
                newName: "Duration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "ItemsHeader",
                newName: "DurationInfo_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "ItemsHeader",
                newName: "DurationInfo_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "HotelReservationMaster",
                newName: "ReservationDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "HotelReservationMaster",
                newName: "ReservationDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "EmployeeJob",
                newName: "JobDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "EmployeeJob",
                newName: "JobDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "EmpContractHeader",
                newName: "ContractDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "EmpContractHeader",
                newName: "ContractDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "EduStudentData",
                newName: "StudentDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "EduStudentData",
                newName: "StudentDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "EduStudentCourse",
                newName: "CourseDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "EduStudentCourse",
                newName: "CourseDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "DelegateData",
                newName: "DelegateDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "DelegateData",
                newName: "DelegateDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "ConProjectsData",
                newName: "ProjectDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "ConProjectsData",
                newName: "ProjectDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "ConContractorExtractMaster",
                newName: "Duration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "ConContractorExtractMaster",
                newName: "Duration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "ConContractorData",
                newName: "ContractorDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "ConContractorData",
                newName: "ContractorDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "BankContract",
                newName: "BankContractDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "BankContract",
                newName: "BankContractDuration_EndDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "AccountFiscalYear",
                newName: "FiscalYearDuration_StartDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "AccountFiscalYear",
                newName: "FiscalYearDuration_EndDate");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ContractDuration_StartDate",
                table: "RntContractsHeader",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Duration_StartDate",
                table: "PItemsHeader",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DurationInfo_StartDate",
                table: "ItemsHeader",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "JobDuration_StartDate",
                table: "EmployeeJob",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ContractDuration_StartDate",
                table: "EmpContractHeader",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StudentDuration_StartDate",
                table: "EduStudentData",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "PassportDateInfo_EndDate",
                table: "EduStudentData",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "PassportDateInfo_StartDate",
                table: "EduStudentData",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CourseDuration_StartDate",
                table: "EduStudentCourse",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DelegateDuration_StartDate",
                table: "DelegateData",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "BankContractDuration_StartDate",
                table: "BankContract",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);
        }
    }
}
