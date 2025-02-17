using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelsUpgrade.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountFication",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountFication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountMenu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountNature",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountNature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    CodeTax = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "APIURLTaxServer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    APIName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    APIURLtax = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServerTypeId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    APIURLTaxPostmanId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APIURLTaxServer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationMessage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttachmentFilesType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentFilesType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BalanceName",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeTaxTabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrmContact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrmOpportunityStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmOpportunityStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrmTaskstatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmTaskstatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrmTaskType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmTaskType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeRate = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerModes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatabaseDescription",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LeavelCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    ParentCodeNavigationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatabaseDescription_DatabaseDescription_ParentCodeNavigationId",
                        column: x => x.ParentCodeNavigationId,
                        principalTable: "DatabaseDescription",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeliveryModes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeTax = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryModes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LevelCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DiscountPercent = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentsMode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    DocumentTypeVersion = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentsMode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationStimate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationStimate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EduQuestionType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduQuestionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpAcceptType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpAcceptType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpAttendType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpAttendType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpContractType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpContractType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpDayWeek",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpDayWeek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpElementNature",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpElementNature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpElementType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpElementType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpLevelType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpLevelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpLoansType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpLoansType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenderData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralAccountType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralAccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeaderText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardTextRight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardTextLeft = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FooterText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryValuation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryValuation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoicingResult",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Uuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InternalId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HashKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicingResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemsCodeType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsCodeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemsType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JournalEntriesTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntriesTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Month",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Month", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeTax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecruitmentData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitmentData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServerType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SizeType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxableType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaxTable = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    TaxCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TaxPercent = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ParentCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LevelCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxableType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxableType_TaxableType_ParentCodeId",
                        column: x => x.ParentCodeId,
                        principalTable: "TaxableType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tenant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeTax = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UniversityData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WhatsAppCompanyData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstanceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobilNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ExpireDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatsAppCompanyData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WhatsAppUrl",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatsAppUrl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttatchmentFile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttachmentFilesTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentNumber = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilesUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttatchmentFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttatchmentFile_AttachmentFilesType_AttachmentFilesTypeId",
                        column: x => x.AttachmentFilesTypeId,
                        principalTable: "AttachmentFilesType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GovernorateCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GovernorateCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GovernorateCode_CountryCode_CountryCodeId",
                        column: x => x.CountryCodeId,
                        principalTable: "CountryCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CrmOpportunity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmOpportunity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrmOpportunity_CrmContact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "CrmContact",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CrmOpportunity_CrmOpportunityStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "CrmOpportunityStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpElementData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpElemntNaturId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmpElemntTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MonthNotActive = table.Column<bool>(type: "bit", nullable: true),
                    EmpElemntNatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpElementData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpElementData_EmpElementNature_EmpElemntNatureId",
                        column: x => x.EmpElemntNatureId,
                        principalTable: "EmpElementNature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpElementData_EmpElementType_EmpElemntTypeId",
                        column: x => x.EmpElemntTypeId,
                        principalTable: "EmpElementType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TenantUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disabled = table.Column<bool>(type: "bit", nullable: false),
                    IsTenantAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CurrentUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenantUser_Tenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CityCode_GovernorateCode_GovernorateCodeId",
                        column: x => x.GovernorateCodeId,
                        principalTable: "GovernorateCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CrmTask",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpportunityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrmTask_CrmOpportunity_OpportunityId",
                        column: x => x.OpportunityId,
                        principalTable: "CrmOpportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrmTask_CrmTaskType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CrmTaskType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrmTask_CrmTaskstatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "CrmTaskstatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OpeningTime_MorningTime1 = table.Column<TimeOnly>(type: "time", nullable: true),
                    OpeningTime_MorningTime2 = table.Column<TimeOnly>(type: "time", nullable: true),
                    OpeningTime_EveningPeriod1 = table.Column<TimeOnly>(type: "time", nullable: true),
                    OpeningTime_EveningPeriod2 = table.Column<TimeOnly>(type: "time", nullable: true),
                    Address_AddressInformation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address_BuildingNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Address_FloorNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Address_RoomNumber = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Address_LandMark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactInformation_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInformation_AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInformation_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInformation_ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInformation_CommercialRegisterNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInformation_TaxesErrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInformation_CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInformation_SpecializationL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInformation_SpecializationL2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyData_ActivityCode_ActivityCodeId",
                        column: x => x.ActivityCodeId,
                        principalTable: "ActivityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyData_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AccountFiscalYear",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FiscalYearDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    FiscalYearDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CloseDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsClosed = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountFiscalYear", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountFiscalYear_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AccountName",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ParentCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LevelCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    CurrencyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountFicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NotMenu = table.Column<bool>(type: "bit", nullable: true),
                    AccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountName_AccountFication_AccountFicationId",
                        column: x => x.AccountFicationId,
                        principalTable: "AccountFication",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountName_AccountMenu_AccountMenuId",
                        column: x => x.AccountMenuId,
                        principalTable: "AccountMenu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountName_AccountName_AccountNameId",
                        column: x => x.AccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountName_AccountName_ParentCode",
                        column: x => x.ParentCode,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountName_AccountNature_AccountNatureId",
                        column: x => x.AccountNatureId,
                        principalTable: "AccountNature",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountName_AccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountName_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountName_CurrencyData_CurrencyDataId",
                        column: x => x.CurrencyDataId,
                        principalTable: "CurrencyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationSetting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SettingNumber = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InventoryValuationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNumberActivate = table.Column<bool>(type: "bit", nullable: true),
                    AccountNumberValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarCodeItems = table.Column<bool>(type: "bit", nullable: true),
                    BarCodeStartValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationSetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationSetting_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationSetting_CountryCode_CountryCodeId",
                        column: x => x.CountryCodeId,
                        principalTable: "CountryCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationSetting_InventoryValuation_InventoryValuationId",
                        column: x => x.InventoryValuationId,
                        principalTable: "InventoryValuation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BankCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrencyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Contacts_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankCode_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BankCode_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BankCode_CountryCode_CountryCodeId",
                        column: x => x.CountryCodeId,
                        principalTable: "CountryCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BankCode_CurrencyData_CurrencyDataId",
                        column: x => x.CurrencyDataId,
                        principalTable: "CurrencyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BankCode_GovernorateCode_GovernorateCodeId",
                        column: x => x.GovernorateCodeId,
                        principalTable: "GovernorateCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConProjectItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConProjectItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConProjectItem_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemCodeTax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LevelCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    ParentCodeNavigationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsGroup_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsGroup_ItemsGroup_ParentCodeNavigationId",
                        column: x => x.ParentCodeNavigationId,
                        principalTable: "ItemsGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PItemsGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemCodeTax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ParentCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LevelCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    ParentCodeNavigationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PItemsGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PItemsGroup_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsGroup_PItemsGroup_ParentCodeNavigationId",
                        column: x => x.ParentCodeNavigationId,
                        principalTable: "PItemsGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConProjectsData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountsNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ProjectDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ProjectValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConProjectsData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConProjectsData_AccountName_AccountsNameId",
                        column: x => x.AccountsNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConProjectsData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DelegateData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DelegateBarCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DelegateAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DelegateNationalId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Contacts_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountsNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SalesValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DelegateDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DelegateDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelegateData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DelegateData_AccountName_AccountsNameId",
                        column: x => x.AccountsNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DelegateData_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DelegateData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FinancialCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FinancialNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountFicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionInfo_Debit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_Credit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_TotalDebit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_TotalCredit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialCenter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinancialCenter_AccountFication_AccountFicationId",
                        column: x => x.AccountFicationId,
                        principalTable: "AccountFication",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinancialCenter_AccountName_AccountNameId",
                        column: x => x.AccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinancialCenter_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacebookId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_BankCode_BankCodeId",
                        column: x => x.BankCodeId,
                        principalTable: "BankCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BankContract",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BankContractDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    BankContractDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    AtmNumber = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    ContractValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankContract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankContract_BankCode_BankCodeId",
                        column: x => x.BankCodeId,
                        principalTable: "BankCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerCategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerBarCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Address_AddressInformation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address_BuildingNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Address_FloorNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Address_RoomNumber = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Address_LandMark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Contacts_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountsNameSalesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RepresentativeDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerData_AccountName_AccountsNameSalesId",
                        column: x => x.AccountsNameSalesId,
                        principalTable: "AccountName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerData_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerData_CustomerCategories_CustomerCategoriesId",
                        column: x => x.CustomerCategoriesId,
                        principalTable: "CustomerCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerData_CustomerModes_CustomerModesId",
                        column: x => x.CustomerModesId,
                        principalTable: "CustomerModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerData_DelegateData_RepresentativeDataId",
                        column: x => x.RepresentativeDataId,
                        principalTable: "DelegateData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountFixedDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountFicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameLevel2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BuyDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "0"),
                    Months = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    CostCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    LastUpdateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CurrentValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "0"),
                    DepreciationAccId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountFixedDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountFixedDetail_AccountFication_AccountFicationId",
                        column: x => x.AccountFicationId,
                        principalTable: "AccountFication",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountFixedDetail_AccountName_AccountNameId",
                        column: x => x.AccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountFixedDetail_AccountName_AccountNameLevel2Id",
                        column: x => x.AccountNameLevel2Id,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountFixedDetail_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AccountsBalanceFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountFicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountsBalanceHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsBalanceFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountsBalanceFooter_AccountFication_AccountFicationId",
                        column: x => x.AccountFicationId,
                        principalTable: "AccountFication",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountsBalanceFooter_AccountName_AccountNameId",
                        column: x => x.AccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AccountsBalanceHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    BalanceNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDebit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalCredit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsBalanceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountsBalanceHeader_BalanceName_BalanceNameId",
                        column: x => x.BalanceNameId,
                        principalTable: "BalanceName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountsBalanceHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionAdjustment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionAdjustment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionAdjustment_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationMenu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuUd = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "0"),
                    ParentCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LevelCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationMenu_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspPermission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OpenForm = table.Column<bool>(type: "bit", nullable: true),
                    AddForm = table.Column<bool>(type: "bit", nullable: true),
                    EditForm = table.Column<bool>(type: "bit", nullable: true),
                    DeleteForm = table.Column<bool>(type: "bit", nullable: true),
                    ReadForm = table.Column<bool>(type: "bit", nullable: true),
                    SearchForm = table.Column<bool>(type: "bit", nullable: true),
                    FilterForm = table.Column<bool>(type: "bit", nullable: true),
                    PrinterReport = table.Column<bool>(type: "bit", nullable: true),
                    ExportFile = table.Column<bool>(type: "bit", nullable: true),
                    ExportDataGrid = table.Column<bool>(type: "bit", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspPermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspPermission_AppUser_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspPermission_ApplicationMenu_ApplicationMenuId",
                        column: x => x.ApplicationMenuId,
                        principalTable: "ApplicationMenu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProgramOption",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramOption_ApplicationMenu_ApplicationMenuId",
                        column: x => x.ApplicationMenuId,
                        principalTable: "ApplicationMenu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReportsName",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportsName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportsName_ApplicationMenu_ApplicationMenuId",
                        column: x => x.ApplicationMenuId,
                        principalTable: "ApplicationMenu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsePermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OpenForm = table.Column<bool>(type: "bit", nullable: true),
                    AddForm = table.Column<bool>(type: "bit", nullable: true),
                    EditForm = table.Column<bool>(type: "bit", nullable: true),
                    DeleteForm = table.Column<bool>(type: "bit", nullable: true),
                    ReadForm = table.Column<bool>(type: "bit", nullable: true),
                    SearchForm = table.Column<bool>(type: "bit", nullable: true),
                    FilterForm = table.Column<bool>(type: "bit", nullable: true),
                    PrinterReport = table.Column<bool>(type: "bit", nullable: true),
                    ExportFile = table.Column<bool>(type: "bit", nullable: true),
                    ExportDataGrid = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsePermissions_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsePermissions_ApplicationMenu_ApplicationMenuId",
                        column: x => x.ApplicationMenuId,
                        principalTable: "ApplicationMenu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BankAtm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BankCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AtmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtmSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtmCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtmAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtmcounterForMonth = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    AtmLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtmLong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtmLat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAtm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankAtm_BankCode_BankCodeId",
                        column: x => x.BankCodeId,
                        principalTable: "BankCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BankAtm_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BankAtm_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BankAtm_CountryCode_CountryCodeId",
                        column: x => x.CountryCodeId,
                        principalTable: "CountryCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BankAtm_GovernorateCode_GovernorateCodeId",
                        column: x => x.GovernorateCodeId,
                        principalTable: "GovernorateCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BranchesData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchTaxId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_AddressInformation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address_BuildingNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Address_FloorNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Address_RoomNumber = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Address_LandMark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BranchContactInfo_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchContactInfo_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchContactInfo_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchContactInfo_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchContactInfo_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchesData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchesData_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BranchesData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BranchesList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchesList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchesList_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BranchesList_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClientDataToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientSecret1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientSecret2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDataToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientDataToken_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientDataToken_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CostCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NotMenu = table.Column<bool>(type: "bit", nullable: true),
                    CostInformation_Levelcode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    CostInformation_CostNumber = table.Column<long>(type: "bigint", nullable: false),
                    CostInformation_CenterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostInformation_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostCenter_AccountMenu_AccountMenuId",
                        column: x => x.AccountMenuId,
                        principalTable: "AccountMenu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CostCenter_AccountNature_AccountNatureId",
                        column: x => x.AccountNatureId,
                        principalTable: "AccountNature",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CostCenter_AccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CostCenter_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CostCenter_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CostCenter_CostCenter_ParentCodeId",
                        column: x => x.ParentCodeId,
                        principalTable: "CostCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CostGeneralAccountHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrencyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDebit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalCredit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "0"),
                    Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    Date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostGeneralAccountHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostGeneralAccountHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CostGeneralAccountHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CostGeneralAccountHeader_CurrencyData_CurrencyDataId",
                        column: x => x.CurrencyDataId,
                        principalTable: "CurrencyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CostJournalHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrencyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDebit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalCredit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "0"),
                    Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    Date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostJournalHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostJournalHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CostJournalHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CostJournalHeader_CurrencyData_CurrencyDataId",
                        column: x => x.CurrencyDataId,
                        principalTable: "CurrencyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EduAcademyCourse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CourseLeavel = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    CourseValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduAcademyCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduAcademyCourse_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduAcademyCourse_EduAcademyCourse_ParentCourseId",
                        column: x => x.ParentCourseId,
                        principalTable: "EduAcademyCourse",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EduStudentData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RecruitmentDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EducationDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UniversityDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EducationeStimateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenderDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SocialDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentAddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    StudentBarCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    StudentDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportDateInfo_StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    PassportDateInfo_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    ContactInfo_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YareEducation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduStudentData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduStudentData_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentData_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentData_EducationData_EducationDataId",
                        column: x => x.EducationDataId,
                        principalTable: "EducationData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentData_EducationStimate_EducationeStimateId",
                        column: x => x.EducationeStimateId,
                        principalTable: "EducationStimate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentData_GenderData_GenderDataId",
                        column: x => x.GenderDataId,
                        principalTable: "GenderData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentData_RecruitmentData_RecruitmentDataId",
                        column: x => x.RecruitmentDataId,
                        principalTable: "RecruitmentData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentData_SocialData_SocialDataId",
                        column: x => x.SocialDataId,
                        principalTable: "SocialData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentData_UniversityData_UniversityDataId",
                        column: x => x.UniversityDataId,
                        principalTable: "UniversityData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpGroupWork",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TimeInfo_OnTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    TimeInfo_OutTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    TimeInfo_OnTimes = table.Column<TimeOnly>(type: "time", nullable: true),
                    TimeInfo_OutTimes = table.Column<TimeOnly>(type: "time", nullable: true),
                    TimeInfo_TotalDelayTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    TimeInfo_TotalEarlyTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    Accept = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    EmployeeLevel = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    OverTime = table.Column<bool>(type: "bit", nullable: true),
                    TotalTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    TotalTimeNotActive = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpGroupWork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpGroupWork_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GeneralAccountHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GeneralAccountTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrencyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDebit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalCredit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "0"),
                    Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    Date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralAccountHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralAccountHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneralAccountHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelRoomData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LevelCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    RoomType = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRoomData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelRoomData_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelRoomData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelRoomData_HotelRoomData_ParentId",
                        column: x => x.ParentId,
                        principalTable: "HotelRoomData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HotelService",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServicesValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelService_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelService_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InstallmentHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    FirstBatch = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    InterestRate = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "0"),
                    NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    NumberInstallments = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    ValueInstallment = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    InstallmentPeriod = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    DelayInterestRate = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "0"),
                    Declaration = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallmentHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstallmentHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstallmentHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstallmentHeader_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JournalHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JournalNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDebit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalCredit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "0"),
                    Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    Date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JournalHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JournalHeader_CurrencyData_CurrencyDataId",
                        column: x => x.CurrencyDataId,
                        principalTable: "CurrencyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LockersData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LockersData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LockersData_AccountName_AccountNameId",
                        column: x => x.AccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LockersData_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LockersData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedAnalysisName",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedAnalysisName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedAnalysisName_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedMedicalService",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicalServicesValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedMedicalService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedMedicalService_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedPartnerData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartnerDataNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartnerDataBarCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PartnerAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PartnerContacInfo_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnerContacInfo_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnerContacInfo_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnerContacInfo_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnerContacInfo_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedPartnerData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedPartnerData_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedPartnerData_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedPartnerData_JobData_JobDataId",
                        column: x => x.JobDataId,
                        principalTable: "JobData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedRaysName",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedRaysName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedRaysName_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedSurgicalService",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SurgicalServicesValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedSurgicalService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedSurgicalService_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PosMachine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MachineSerial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosMachine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosMachine_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PosSale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BarcodeInvoice = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TotalDiscounts = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxTotals = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosSale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosSale_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosSale_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosSale_PriceType_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PRequestReservationHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptNo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRequestReservationHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRequestReservationHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRequestReservationHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PReturnReservationHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptNo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PReturnReservationHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PReturnReservationHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PReturnReservationHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestReservationHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestReservationHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestReservationHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestReservationHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RntActivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RntActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RntActivity_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RntCustomerPercentHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    TotalRevenu = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TotalExpenses = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    NetRevenu = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RntCustomerPercentHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RntCustomerPercentHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RntCustomerPercentHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RntCustomerPercentHeader_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RntExpenseType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RntExpenseType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RntExpenseType_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RntFloor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FloorsCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LevelCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    ParentCodeNavigationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RntFloor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RntFloor_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RntFloor_RntFloor_ParentCodeNavigationId",
                        column: x => x.ParentCodeNavigationId,
                        principalTable: "RntFloor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WhatsAppMessageData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatsAppMessageData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhatsAppMessageData_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WhatsAppMessageData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkPlanHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkPlanDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    WorkPlanDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlanHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkPlanHeader_BankCode_BankCodeId",
                        column: x => x.BankCodeId,
                        principalTable: "BankCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkPlanHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkPlanHeader_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkPlanHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkPlanHeader_CountryCode_CountryCodeId",
                        column: x => x.CountryCodeId,
                        principalTable: "CountryCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkPlanHeader_GovernorateCode_GovernorateCodeId",
                        column: x => x.GovernorateCodeId,
                        principalTable: "GovernorateCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClientAccessToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientDataTokenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccessToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiresIn = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    TokenType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Scope = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAccessToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientAccessToken_ClientDataToken_ClientDataTokenId",
                        column: x => x.ClientDataTokenId,
                        principalTable: "ClientDataToken",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CheckNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PaymentDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CheckSignDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateInfo_Year = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    DateInfo_CheckDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateInfo_DueDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateInfo_PaymentDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateInfo_CheckSignDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CheckName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    NotifyDays = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    CheckSiteName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnderlineCheck = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RepetitionTimes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CheckImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    BankNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CostCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CheckTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameFromId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameToId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CheckStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrencyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckDetail_AccountName_AccountNameFromId",
                        column: x => x.AccountNameFromId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckDetail_AccountName_AccountNameToId",
                        column: x => x.AccountNameToId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckDetail_BankCode_BankNameId",
                        column: x => x.BankNameId,
                        principalTable: "BankCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckDetail_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckDetail_CheckStatus_CheckStatusId",
                        column: x => x.CheckStatusId,
                        principalTable: "CheckStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckDetail_CheckType_CheckTypeId",
                        column: x => x.CheckTypeId,
                        principalTable: "CheckType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckDetail_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckDetail_CostCenter_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckDetail_CurrencyData_CurrencyDataId",
                        column: x => x.CurrencyDataId,
                        principalTable: "CurrencyData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MoneyPayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FromAccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ToAccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FromCashId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CostCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaperNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoneyPayment_AccountName_FromAccountNameId",
                        column: x => x.FromAccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyPayment_AccountName_FromCashId",
                        column: x => x.FromCashId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyPayment_AccountName_ToAccountNameId",
                        column: x => x.ToAccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyPayment_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyPayment_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyPayment_CostCenter_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MoneyReceive",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FromAccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ToAccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FromCashId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CostCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaperNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyReceive", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoneyReceive_AccountName_FromAccountNameId",
                        column: x => x.FromAccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyReceive_AccountName_FromCashId",
                        column: x => x.FromCashId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyReceive_AccountName_ToAccountNameId",
                        column: x => x.ToAccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyReceive_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyReceive_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyReceive_CostCenter_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReservationDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationUd = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CostCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReservationFromId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReservationToId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReservationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ReservationValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationDebit_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationDebit_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationDebit_CostCenter_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationDebit_ReservationDebit_ReservationFromId",
                        column: x => x.ReservationFromId,
                        principalTable: "ReservationDebit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationDebit_ReservationDebit_ReservationToId",
                        column: x => x.ReservationToId,
                        principalTable: "ReservationDebit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationDebit_ReservationStatus_ReservationStatusId",
                        column: x => x.ReservationStatusId,
                        principalTable: "ReservationStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CostGeneralAccountFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JournalHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Credit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostGeneralAccountFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostGeneralAccountFooter_CostCenter_AccountNameId",
                        column: x => x.AccountNameId,
                        principalTable: "CostCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CostGeneralAccountFooter_CostGeneralAccountHeader_JournalHeaderId",
                        column: x => x.JournalHeaderId,
                        principalTable: "CostGeneralAccountHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CostJournalFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JournalHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Credit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostJournalFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostJournalFooter_CostCenter_AccountNameId",
                        column: x => x.AccountNameId,
                        principalTable: "CostCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CostJournalFooter_CostJournalHeader_JournalHeaderId",
                        column: x => x.JournalHeaderId,
                        principalTable: "CostJournalHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EduQuestionsMaster",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AcademyCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QuestionTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QuestionInfo_QuestionDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionInfo_QuestionAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionInfo_QuestionValue = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    QuestionInfo_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduQuestionsMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduQuestionsMaster_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduQuestionsMaster_EduAcademyCourse_AcademyCourseId",
                        column: x => x.AcademyCourseId,
                        principalTable: "EduAcademyCourse",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduQuestionsMaster_EduQuestionType_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "EduQuestionType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EduStudentCourse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AcademyCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CourseDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CourseDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduStudentCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduStudentCourse_EduStudentData_StudentDataId",
                        column: x => x.StudentDataId,
                        principalTable: "EduStudentData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EduStudentPayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AcademyCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Credit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduStudentPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduStudentPayment_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentPayment_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentPayment_EduAcademyCourse_AcademyCourseId",
                        column: x => x.AcademyCourseId,
                        principalTable: "EduAcademyCourse",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EduStudentPayment_EduStudentData_StudentDataId",
                        column: x => x.StudentDataId,
                        principalTable: "EduStudentData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RecruitmentDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EducationDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UniversityDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EducationeStimateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenderDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SocialDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BasicSalary = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    YareEducation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeTimeInfo_DateStart = table.Column<DateOnly>(type: "date", nullable: true),
                    EmployeeTimeInfo_DateFinsh = table.Column<DateOnly>(type: "date", nullable: true),
                    EmployeeTimeInfo_TimeStartWork = table.Column<TimeOnly>(type: "time", nullable: true),
                    EmployeeTimeInfo_TimeEndWork = table.Column<TimeOnly>(type: "time", nullable: true),
                    EmployeeTimeInfo_DateBarith = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactInfo_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationStimateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupWorkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeData_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeData_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeData_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeData_EducationData_EducationDataId",
                        column: x => x.EducationDataId,
                        principalTable: "EducationData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeData_EducationStimate_EducationStimateId",
                        column: x => x.EducationStimateId,
                        principalTable: "EducationStimate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeData_EmpGroupWork_GroupWorkId",
                        column: x => x.GroupWorkId,
                        principalTable: "EmpGroupWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeData_GenderData_GenderDataId",
                        column: x => x.GenderDataId,
                        principalTable: "GenderData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeData_JobData_JobDataId",
                        column: x => x.JobDataId,
                        principalTable: "JobData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeData_PaymentMode_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeData_RecruitmentData_RecruitmentDataId",
                        column: x => x.RecruitmentDataId,
                        principalTable: "RecruitmentData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeData_SocialData_SocialDataId",
                        column: x => x.SocialDataId,
                        principalTable: "SocialData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeData_UniversityData_UniversityDataId",
                        column: x => x.UniversityDataId,
                        principalTable: "UniversityData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GeneralAccountFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GeneralAccountHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CostCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Credit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralAccountFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralAccountFooter_AccountName_AccountNameId",
                        column: x => x.AccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GeneralAccountFooter_CostCenter_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GeneralAccountFooter_GeneralAccountHeader_GeneralAccountHeaderId",
                        column: x => x.GeneralAccountHeaderId,
                        principalTable: "GeneralAccountHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HotelReservationMaster",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReservationDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ReservationDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EntryTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    OutTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    NumberDays = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    ReservationValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelReservationMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelReservationMaster_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelReservationMaster_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelReservationMaster_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelReservationMaster_HotelRoomData_RoomId",
                        column: x => x.RoomId,
                        principalTable: "HotelRoomData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InstallmentFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstallmentHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstallmentValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    InstallmentNumber = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    PostedInstallment = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallmentFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstallmentFooter_InstallmentHeader_InstallmentHeaderId",
                        column: x => x.InstallmentHeaderId,
                        principalTable: "InstallmentHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JournalFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JournalHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CostCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Credit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalFooter_AccountName_AccountNameId",
                        column: x => x.AccountNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JournalFooter_CostCenter_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JournalFooter_JournalHeader_JournalHeaderId",
                        column: x => x.JournalHeaderId,
                        principalTable: "JournalHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedCustomerMedicalService",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicalServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedCustomerMedicalService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedCustomerMedicalService_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedCustomerMedicalService_MedMedicalService_MedicalServicesId",
                        column: x => x.MedicalServicesId,
                        principalTable: "MedMedicalService",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedCustomerDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AnalysisNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RaysNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedCustomerDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedCustomerDetail_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedCustomerDetail_MedAnalysisName_AnalysisNameId",
                        column: x => x.AnalysisNameId,
                        principalTable: "MedAnalysisName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedCustomerDetail_MedRaysName_RaysNameId",
                        column: x => x.RaysNameId,
                        principalTable: "MedRaysName",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedCustomerSurgicalService",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SurgicalServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedCustomerSurgicalService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedCustomerSurgicalService_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedCustomerSurgicalService_MedSurgicalService_SurgicalServicesId",
                        column: x => x.SurgicalServicesId,
                        principalTable: "MedSurgicalService",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PosPaymentDaily",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentNo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PossalesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    PaymentModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionInfo_Debit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_Credit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_Balance = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosPaymentDaily", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosPaymentDaily_PaymentMode_PaymentModesId",
                        column: x => x.PaymentModesId,
                        principalTable: "PaymentMode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PosPaymentDaily_PosSale_PossalesId",
                        column: x => x.PossalesId,
                        principalTable: "PosSale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestReservationHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BarcodeInvoice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentsModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TotalDiscounts = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TotalAfterDiscounts = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxTotals = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_DocumentsMode_DocumentsModesId",
                        column: x => x.DocumentsModesId,
                        principalTable: "DocumentsMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_PaymentMode_PaymentModesId",
                        column: x => x.PaymentModesId,
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_PriceType_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_RequestReservationHeader_RequestReservationHeaderId",
                        column: x => x.RequestReservationHeaderId,
                        principalTable: "RequestReservationHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RntContractsHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActivitiesId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    RentalMonthes = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    InsuranceMonthes = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    ContractMonthes = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    ContractDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ContractDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IncreasingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActivitiesId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RntContractsHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RntContractsHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RntContractsHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RntContractsHeader_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RntContractsHeader_RntActivity_ActivitiesId1",
                        column: x => x.ActivitiesId1,
                        principalTable: "RntActivity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RntCustomerPercentData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerPercentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RevenuPercent = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    RevenuValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RntCustomerPercentData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RntCustomerPercentData_RntCustomerPercentHeader_CustomerPercentId",
                        column: x => x.CustomerPercentId,
                        principalTable: "RntCustomerPercentHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RntExpense",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpenseCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpenseTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ExpenseValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RntExpense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RntExpense_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RntExpense_RntExpenseType_ExpenseTypeId",
                        column: x => x.ExpenseTypeId,
                        principalTable: "RntExpenseType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WhatsAppResult",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResultNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MessageDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SendDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatsAppResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhatsAppResult_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WhatsAppResult_WhatsAppMessageData_MessageDataId",
                        column: x => x.MessageDataId,
                        principalTable: "WhatsAppMessageData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkPlanFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkPlanHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BankAtmid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderNumberFooter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CounterForRejectTime = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "0"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlanFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkPlanFooter_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkPlanFooter_BankAtm_BankAtmid",
                        column: x => x.BankAtmid,
                        principalTable: "BankAtm",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkPlanFooter_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkPlanFooter_WorkPlanHeader_WorkPlanHeaderId",
                        column: x => x.WorkPlanHeaderId,
                        principalTable: "WorkPlanHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EduQuestionDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionsMasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QuestionsAnswer = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AnswerCheck = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduQuestionDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduQuestionDetail_EduQuestionsMaster_QuestionsMasterId",
                        column: x => x.QuestionsMasterId,
                        principalTable: "EduQuestionsMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConContractorData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContractorGroupsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContractorManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountsNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContractorBarCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContractorName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    ContractorAddress_AddressInformation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContractorAddress_BuildingNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ContractorAddress_PostalCode = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    ContractorAddress_FloorNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ContractorAddress_RoomNumber = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ContractorAddress_LandMark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactInfo_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    IsCustomer = table.Column<bool>(type: "bit", nullable: true),
                    IsCompany = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActiveTax = table.Column<bool>(type: "bit", nullable: true),
                    TaxRegistrationNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TaxesErrand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommercialRegisterNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ContractorDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ContractorDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConContractorData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConContractorData_AccountName_AccountsNameId",
                        column: x => x.AccountsNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConContractorData_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConContractorData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConContractorData_CountryCode_CountryCodeId",
                        column: x => x.CountryCodeId,
                        principalTable: "CountryCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConContractorData_EmployeeData_ContractorManagerId",
                        column: x => x.ContractorManagerId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConContractorData_GovernorateCode_GovernorateCodeId",
                        column: x => x.GovernorateCodeId,
                        principalTable: "GovernorateCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConContractorData_SupplierGroup_ContractorGroupsId",
                        column: x => x.ContractorGroupsId,
                        principalTable: "SupplierGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpAccept",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmpAcceptTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DateInfo_StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateInfo_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateInfo_Year = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpAccept", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpAccept_EmpAcceptType_EmpAcceptTypeId",
                        column: x => x.EmpAcceptTypeId,
                        principalTable: "EmpAcceptType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmpAccept_EmployeeData_EmployeesDataId",
                        column: x => x.EmployeesDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpAttend",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttendTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmpDayWeekId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    TimeInfo_OnTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    TimeInfo_OutTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    TimeInfo_OnTimes = table.Column<TimeOnly>(type: "time", nullable: true),
                    TimeInfo_OutTimes = table.Column<TimeOnly>(type: "time", nullable: true),
                    TimeInfo_OverTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    TimeInfo_TotalTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpAttend", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpAttend_EmpAttendType_AttendTypeId",
                        column: x => x.AttendTypeId,
                        principalTable: "EmpAttendType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmpAttend_EmpDayWeek_EmpDayWeekId",
                        column: x => x.EmpDayWeekId,
                        principalTable: "EmpDayWeek",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmpAttend_EmployeeData_EmployeesDataId",
                        column: x => x.EmployeesDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpContractHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmpContractTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContractDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ContractDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpContractHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpContractHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpContractHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpContractHeader_EmpContractType_EmpContractTypeId",
                        column: x => x.EmpContractTypeId,
                        principalTable: "EmpContractType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmpContractHeader_EmployeeData_EmployeesDataId",
                        column: x => x.EmployeesDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpLevel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateInfo_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EmpLevelTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpLevel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpLevel_EmpLevelType_EmpLevelTypeId",
                        column: x => x.EmpLevelTypeId,
                        principalTable: "EmpLevelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmpLevel_EmployeeData_EmployeesDataId",
                        column: x => x.EmployeesDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpLoans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmpLoansTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    ValueMonth = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthLoans = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpLoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpLoans_EmpLoansType_EmpLoansTypeId",
                        column: x => x.EmpLoansTypeId,
                        principalTable: "EmpLoansType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmpLoans_EmployeeData_EmployeesDataId",
                        column: x => x.EmployeesDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCourse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Years = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Academy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeCourse_EmployeeData_EmployeeDataId",
                        column: x => x.EmployeeDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJob",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobDuration_StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    JobDuration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Time = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    PayrollValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJob", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeJob_EmployeeData_EmployeeDataId",
                        column: x => x.EmployeeDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SkillsName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Darega = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSkills_EmployeeData_EmployeeDataId",
                        column: x => x.EmployeeDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FinalData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    Month = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    Basicsalary = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ActualDayes = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance6 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance7 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance8 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance9 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance10 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance11 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance12 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance13 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance14 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance15 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance16 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance17 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance18 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance19 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance20 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance21 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance22 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance23 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance24 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance25 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance26 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance27 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance28 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance29 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance30 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance31 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance32 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance33 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance34 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance35 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance36 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance37 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance38 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance39 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance40 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance41 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance42 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance43 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance44 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance45 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance46 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance47 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance48 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance49 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance50 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance51 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance52 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance53 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance54 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance55 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance56 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance57 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance58 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance59 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance60 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    AllowanceSum = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction6 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction7 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction8 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction9 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction10 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction11 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction12 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction13 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction14 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction15 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction16 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction17 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction18 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction19 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction20 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction21 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction22 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction23 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction24 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction25 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction26 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction27 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction28 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction29 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction30 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction31 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction32 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction33 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction34 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction35 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction36 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction37 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction38 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction39 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction40 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction41 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction42 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction43 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction44 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction45 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction46 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction47 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction48 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction49 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction50 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction51 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction52 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction53 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction54 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction55 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction56 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction57 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction58 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction59 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction60 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DeductionSum = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TaxableBool = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TaxExemptBool = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Tax = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    CalculatorSalary = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc6 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc7 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc8 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc9 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc10 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc11 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc12 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc13 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc14 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc15 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc16 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc17 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc18 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc19 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc20 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc21 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc22 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc23 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc24 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc25 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc26 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc27 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc28 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc29 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc30 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc31 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc32 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc33 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc34 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc35 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc36 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc37 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc38 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc39 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc40 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc41 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc42 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc43 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc44 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc45 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc46 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc47 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc48 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc49 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc50 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc51 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc52 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc53 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc54 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc55 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc56 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc57 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc58 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc59 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc60 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc6 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc7 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc8 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc9 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc10 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc11 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc12 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc13 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc14 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc15 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc16 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc17 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc18 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc19 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc20 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc21 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc22 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc23 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc24 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc25 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc26 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc27 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc28 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc29 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc30 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc31 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc32 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc33 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc34 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc35 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc36 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc37 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc38 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc39 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc40 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc41 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc42 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc43 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc44 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc45 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc46 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc47 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc48 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc49 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc50 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc51 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc52 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc53 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc54 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc55 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc56 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc57 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc58 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc59 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc60 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary6 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary7 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary8 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary9 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary10 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary11 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary12 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    SumMonthBasicSalary = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    SumBasicSalary = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthDays = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    CompanyMedicalInsPercent = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    EmpMedicalInsPercent = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    EmpMedicalInsValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    CompMedicalInsValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    CompFamilyMedicalInsValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    EmpFamilyMedicalInsValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DaysBeforJoin = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DaysAfterLeave = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    InsuranceStatCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    NSalaryExchanged = table.Column<bool>(type: "bit", nullable: true),
                    SubDepCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    GenralDescripation1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenralDescripation2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenralDescripation3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenralDescripation4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenralDescripation5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalData_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalData_EmployeeData_EmployeeDataId",
                        column: x => x.EmployeeDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinalDataFixed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    Month = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    Basicsalary = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ActualDayes = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance6 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance7 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance8 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance9 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance10 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance11 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance12 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance13 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance14 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance15 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance16 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance17 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance18 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance19 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance20 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance21 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance22 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance23 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance24 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance25 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance26 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance27 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance28 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance29 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance30 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance31 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance32 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance33 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance34 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance35 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance36 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance37 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance38 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance39 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance40 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance41 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance42 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance43 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance44 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance45 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance46 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance47 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance48 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance49 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance50 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance51 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance52 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance53 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance54 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance55 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance56 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance57 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance58 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance59 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allowance60 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    AllowanceSum = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction6 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction7 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction8 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction9 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction10 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction11 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction12 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction13 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction14 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction15 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction16 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction17 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction18 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction19 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction20 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction21 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction22 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction23 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction24 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction25 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction26 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction27 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction28 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction29 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction30 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction31 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction32 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction33 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction34 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction35 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction36 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction37 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction38 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction39 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction40 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction41 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction42 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction43 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction44 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction45 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction46 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction47 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction48 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction49 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction50 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction51 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction52 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction53 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction54 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction55 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction56 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction57 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction58 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction59 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Deduction60 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DeductionSum = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TaxableBool = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TaxExemptBool = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Tax = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    CalculatorSalary = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc6 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc7 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc8 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc9 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc10 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc11 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc12 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc13 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc14 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc15 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc16 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc17 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc18 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc19 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc20 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc21 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc22 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc23 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc24 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc25 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc26 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc27 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc28 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc29 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc30 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc31 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc32 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc33 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc34 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc35 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc36 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc37 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc38 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc39 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc40 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc41 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc42 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc43 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc44 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc45 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc46 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc47 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc48 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc49 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc50 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc51 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc52 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc53 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc54 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc55 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc56 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc57 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc58 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc59 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Allc60 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc6 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc7 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc8 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc9 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc10 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc11 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc12 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc13 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc14 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc15 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc16 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc17 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc18 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc19 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc20 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc21 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc22 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc23 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc24 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc25 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc26 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc27 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc28 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc29 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc30 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc31 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc32 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc33 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc34 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc35 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc36 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc37 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc38 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc39 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc40 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc41 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc42 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc43 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc44 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc45 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc46 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc47 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc48 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc49 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc50 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc51 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc52 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc53 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc54 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc55 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc56 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc57 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc58 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc59 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Dedc60 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary6 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary7 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary8 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary9 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary10 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary11 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthBasicSalary12 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    SumMonthBasicSalary = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    SumBasicSalary = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MonthDays = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    CompanyMedicalInsPercent = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    EmpMedicalInsPercent = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    EmpMedicalInsValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    CompMedicalInsValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    CompFamilyMedicalInsValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    EmpFamilyMedicalInsValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DaysBeforJoin = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DaysAfterLeave = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    InsuranceStatCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    NSalaryExchanged = table.Column<bool>(type: "bit", nullable: true),
                    SubDepCode = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    GenralDescripation1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenralDescripation2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenralDescripation3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenralDescripation4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenralDescripation5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalDataFixed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalDataFixed_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalDataFixed_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalDataFixed_EmployeeData_EmployeeDataId",
                        column: x => x.EmployeeDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PosSession",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateHeureOpen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateHeureClose = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosSession_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosSession_EmployeeData_EmployeesDataId",
                        column: x => x.EmployeesDataId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoreData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ContactInformation_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreManager = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountsNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreManagerNavigationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreData_AccountName_AccountsNameId",
                        column: x => x.AccountsNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreData_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreData_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreData_EmployeeData_StoreManagerNavigationId",
                        column: x => x.StoreManagerNavigationId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierGroupsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierBarCode = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GovernorateCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Address_AddressInformation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address_BuildingNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Address_FloorNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Address_RoomNumber = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Address_LandMark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Contacts_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierManager = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsCustomer = table.Column<bool>(type: "bit", nullable: true),
                    IsCompany = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActiveTax = table.Column<bool>(type: "bit", nullable: true),
                    AccountsNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaxRegistrationNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TaxesErrand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommercialRegisterNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierManagerNavigationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplierData_AccountName_AccountsNameId",
                        column: x => x.AccountsNameId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SupplierData_CityCode_CityCodeId",
                        column: x => x.CityCodeId,
                        principalTable: "CityCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SupplierData_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SupplierData_EmployeeData_SupplierManagerNavigationId",
                        column: x => x.SupplierManagerNavigationId,
                        principalTable: "EmployeeData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierData_SupplierGroup_SupplierGroupsId",
                        column: x => x.SupplierGroupsId,
                        principalTable: "SupplierGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HotelPayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HotelReservationMasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Credit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelPayment_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelPayment_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelPayment_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelPayment_HotelReservationMaster_HotelReservationMasterId",
                        column: x => x.HotelReservationMasterId,
                        principalTable: "HotelReservationMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HotelReservationDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReservationMasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_ReservationValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ServicesValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Discount = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Tax = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelReservationDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelReservationDetail_HotelReservationMaster_ReservationMasterId",
                        column: x => x.ReservationMasterId,
                        principalTable: "HotelReservationMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelReservationDetail_HotelService_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "HotelService",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReturnSalesHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnNo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceSalesHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BarcodeReturn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    CustomerDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentsModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnSalesHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnSalesHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnSalesHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnSalesHeader_CustomerData_CustomerDataId",
                        column: x => x.CustomerDataId,
                        principalTable: "CustomerData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnSalesHeader_DocumentsMode_DocumentsModesId",
                        column: x => x.DocumentsModesId,
                        principalTable: "DocumentsMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnSalesHeader_PaymentMode_PaymentModesId",
                        column: x => x.PaymentModesId,
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnSalesHeader_PriceType_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnSalesHeader_SalesInvoiceHeader_InvoiceSalesHeaderId",
                        column: x => x.InvoiceSalesHeaderId,
                        principalTable: "SalesInvoiceHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceDelivery",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceSalesHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeliveryModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Approach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Packaging = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateValidity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExportPort = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryOfOriginId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GrossWeight = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "0"),
                    NetWeight = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "0"),
                    Terms = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeliveryValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceDelivery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceDelivery_DeliveryModes_DeliveryModesId",
                        column: x => x.DeliveryModesId,
                        principalTable: "DeliveryModes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoiceDelivery_SalesInvoiceHeader_InvoiceSalesHeaderId",
                        column: x => x.InvoiceSalesHeaderId,
                        principalTable: "SalesInvoiceHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoicePayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesInvoiceHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BankCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionInfo_Debit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_Credit = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_Balance = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoicePayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoicePayment_BankCode_BankCodeId",
                        column: x => x.BankCodeId,
                        principalTable: "BankCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoicePayment_PaymentMode_PaymentModesId",
                        column: x => x.PaymentModesId,
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoicePayment_SalesInvoiceHeader_SalesInvoiceHeaderId",
                        column: x => x.SalesInvoiceHeaderId,
                        principalTable: "SalesInvoiceHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RntContractsData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractsHid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FloorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RntContractsData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RntContractsData_RntContractsHeader_ContractsHeaderId",
                        column: x => x.ContractsHeaderId,
                        principalTable: "RntContractsHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RntContractsData_RntFloor_FloorsId",
                        column: x => x.FloorsId,
                        principalTable: "RntFloor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RntContractsData_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RntReceiptsHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrencyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RntReceiptsHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RntReceiptsHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RntReceiptsHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RntReceiptsHeader_CurrencyData_CurrencyDataId",
                        column: x => x.CurrencyDataId,
                        principalTable: "CurrencyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RntReceiptsHeader_RntContractsHeader_ContractsId",
                        column: x => x.ContractsId,
                        principalTable: "RntContractsHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkPlanComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkPlanFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CommentDamag = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlanComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkPlanComment_WorkPlanFooter_WorkPlanFooterId",
                        column: x => x.WorkPlanFooterId,
                        principalTable: "WorkPlanFooter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkPlanDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkPlanFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderNumberDetails = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlanDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkPlanDetail_WorkPlanFooter_WorkPlanFooterId",
                        column: x => x.WorkPlanFooterId,
                        principalTable: "WorkPlanFooter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EduStudentQuestion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QuestionsAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionValue = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    QuestionAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduStudentQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduStudentQuestion_EduQuestionDetail_QuestionAnswerId",
                        column: x => x.QuestionAnswerId,
                        principalTable: "EduQuestionDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EduStudentQuestion_EduStudentData_StudentDataId",
                        column: x => x.StudentDataId,
                        principalTable: "EduStudentData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConContractorExtractMaster",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContractorDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Duration_StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Duration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    MasterPricing_TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MasterPricing_TotalTax = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MasterPricing_TotalDiscount = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MasterPricing_Payments = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    MasterPricing_NetTotal = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    NumberLetters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConContractorExtractMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConContractorExtractMaster_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConContractorExtractMaster_ConContractorData_ContractorDataId",
                        column: x => x.ContractorDataId,
                        principalTable: "ConContractorData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConContractorExtractMaster_ConProjectsData_ProjectDataId",
                        column: x => x.ProjectDataId,
                        principalTable: "ConProjectsData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpContractFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpContractHid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmpElementTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmpElementDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ValueElment = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpContractFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpContractFooter_EmpContractHeader_EmpContractHid",
                        column: x => x.EmpContractHid,
                        principalTable: "EmpContractHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmpContractFooter_EmpElementData_EmpElementDataId",
                        column: x => x.EmpElementDataId,
                        principalTable: "EmpElementData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmpContractFooter_EmpElementType_EmpElementTypeId",
                        column: x => x.EmpElementTypeId,
                        principalTable: "EmpElementType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InventoryOrderHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryOrderHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryOrderHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InventoryOrderHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InventoryOrderHeader_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsBalanceHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemsBalanceHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    BalanceNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsBalanceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsBalanceHeader_BalanceName_BalanceNameId",
                        column: x => x.BalanceNameId,
                        principalTable: "BalanceName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsBalanceHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsBalanceHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsBalanceHeader_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PInventoryOrderHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderNo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PInventoryOrderHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PInventoryOrderHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PInventoryOrderHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PInventoryOrderHeader_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PItemsBalanceHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    BalanceNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PItemsBalanceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PItemsBalanceHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PItemsBalanceHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PItemsBalanceHeader_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TransformationsMaster",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransformationNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    FromId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ToId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransformationsMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransformationsMaster_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransformationsMaster_StoreData_FromId",
                        column: x => x.FromId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransformationsMaster_StoreData_ToId",
                        column: x => x.ToId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsGroupsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsCodeInfo_InternationalBarCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemsCodeInfo_SupplierBarCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemsCodeInfo_InternalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemsTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsCodeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_StockLimit = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemPricePurchase = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemPriceCost = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemProfit1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemPrice1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemPrice2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemPrice3 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemPrice4 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemPrice5 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActiveTax = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActiveTaxDiscount = table.Column<bool>(type: "bit", nullable: true),
                    DurationInfo_StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DurationInfo_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsHeader_ItemsCodeType_ItemsCodeTypeId",
                        column: x => x.ItemsCodeTypeId,
                        principalTable: "ItemsCodeType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsHeader_ItemsGroup_ItemsGroupsId",
                        column: x => x.ItemsGroupsId,
                        principalTable: "ItemsGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsHeader_ItemsType_ItemsTypeId",
                        column: x => x.ItemsTypeId,
                        principalTable: "ItemsType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsHeader_SupplierData_SupplierDataId",
                        column: x => x.SupplierDataId,
                        principalTable: "SupplierData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsHeader_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PItemsHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PitemsGroupsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsCodeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountsNamePurchasId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountNameSalesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NameL1 = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    NameL2 = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    InternalCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StockLimit = table.Column<int>(type: "int", nullable: true, defaultValueSql: "0"),
                    IsNotActiveTax = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActiveTaxDiscount = table.Column<bool>(type: "bit", nullable: true),
                    Duration_StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Duration_EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PItemsHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PItemsHeader_AccountName_AccountNameSalesId",
                        column: x => x.AccountNameSalesId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsHeader_AccountName_AccountsNamePurchasId",
                        column: x => x.AccountsNamePurchasId,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PItemsHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PItemsHeader_ItemsType_ItemsTypeId",
                        column: x => x.ItemsTypeId,
                        principalTable: "ItemsType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsHeader_PItemsGroup_PitemsGroupsId",
                        column: x => x.PitemsGroupsId,
                        principalTable: "PItemsGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsHeader_SupplierData_SupplierDataId",
                        column: x => x.SupplierDataId,
                        principalTable: "SupplierData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchasesOrderHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasesOrderHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasesOrderHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasesOrderHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasesOrderHeader_SupplierData_SupplierDataId",
                        column: x => x.SupplierDataId,
                        principalTable: "SupplierData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesTaxInvoiceHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesInvoiceHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnSalesHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaxableTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaxAmount = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTaxInvoiceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesTaxInvoiceHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesTaxInvoiceHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesTaxInvoiceHeader_ReturnSalesHeader_ReturnSalesHeaderId",
                        column: x => x.ReturnSalesHeaderId,
                        principalTable: "ReturnSalesHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesTaxInvoiceHeader_SalesInvoiceHeader_SalesInvoiceHeaderId",
                        column: x => x.SalesInvoiceHeaderId,
                        principalTable: "SalesInvoiceHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesTaxInvoiceHeader_TaxableType_TaxableTypeId",
                        column: x => x.TaxableTypeId,
                        principalTable: "TaxableType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RntReceiptsData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PaidValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    RemainingValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ReciptNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiptHeaderNavigationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RntReceiptsData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RntReceiptsData_RntReceiptsHeader_ReceiptHeaderNavigationId",
                        column: x => x.ReceiptHeaderNavigationId,
                        principalTable: "RntReceiptsHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConContractorExtractDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractorMasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ImplementationRate = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConContractorExtractDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConContractorExtractDetail_ConContractorExtractMaster_ContractorMasterId",
                        column: x => x.ContractorMasterId,
                        principalTable: "ConContractorExtractMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConContractorExtractDetail_ConProjectItem_ProjectItemsId",
                        column: x => x.ProjectItemsId,
                        principalTable: "ConProjectItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConContractorExtractDetail_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestReceiptHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestReceiptNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RequestReciptDateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    RequestReciptDateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    RequestReciptDateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalValue = table.Column<double>(type: "float", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestReceiptHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestReceiptHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestReceiptHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestReceiptHeader_InventoryOrderHeader_PurchaseOrderHeaderId",
                        column: x => x.PurchaseOrderHeaderId,
                        principalTable: "InventoryOrderHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestReceiptHeader_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PRequestReceiptHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestReceiptNo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PpurchaseOrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRequestReceiptHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRequestReceiptHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRequestReceiptHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRequestReceiptHeader_PInventoryOrderHeader_PpurchaseOrderHeaderId",
                        column: x => x.PpurchaseOrderHeaderId,
                        principalTable: "PInventoryOrderHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PRequestReceiptHeader_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InventoryOrderFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryOrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    OrderDetails_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    OrderDetails_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryOrderFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryOrderFooter_InventoryOrderHeader_InventoryOrderHeaderId",
                        column: x => x.InventoryOrderHeaderId,
                        principalTable: "InventoryOrderHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InventoryOrderFooter_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InventoryOrderFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsBalanceFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemsBalanceHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemBalanceCodes_InternationalBarCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemBalanceCodes_SupplierBarCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemBalanceCodes_InternalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemBalancePurchaseInfo_ItemQuantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ItemBalancePurchaseInfo_ItemQuantityDamaged = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ItemBalancePurchaseInfo_ItemQuantityBroken = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ItemBalancePurchaseInfo_ItemPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ItemBalancePurchaseInfo_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsBalanceFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsBalanceFooter_ItemsBalanceHeader_ItemsBalanceHeaderId",
                        column: x => x.ItemsBalanceHeaderId,
                        principalTable: "ItemsBalanceHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsBalanceFooter_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsBalanceFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsColor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SizeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ColorTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsColor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsColor_ColorType_ColorTypeId",
                        column: x => x.ColorTypeId,
                        principalTable: "ColorType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsColor_ItemsHeader_ItemHeaderId",
                        column: x => x.ItemHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsColor_SizeType_SizeTypeId",
                        column: x => x.SizeTypeId,
                        principalTable: "SizeType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemSize",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SizeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SizeValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemSize_ItemsHeader_ItemHeaderId",
                        column: x => x.ItemHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemSize_SizeType_SizeTypeId",
                        column: x => x.SizeTypeId,
                        principalTable: "SizeType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsPricePurchase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DatePurchases = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemsPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsPricePurchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsPricePurchase_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsPricePurchase_SupplierData_SupplierDataId",
                        column: x => x.SupplierDataId,
                        principalTable: "SupplierData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsPriceSale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateSales = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PriceValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsPriceSale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsPriceSale_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsPriceSale_PriceType_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsPriceSale_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsProduction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductionDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ExpiryDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsProduction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsProduction_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PosSalesDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PosSalesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosSalesDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosSalesDetail_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosSalesDetail_PosSale_PosSalesId",
                        column: x => x.PosSalesId,
                        principalTable: "PosSale",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PSettlementDiscount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSettlementDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSettlementDiscount_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PSettlementDiscount_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PSettlementDiscount_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PSettlementDiscount_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestReservationFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestReservationHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestReservationFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestReservationFooter_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestReservationFooter_RequestReservationHeader_RequestReservationHeaderId",
                        column: x => x.RequestReservationHeaderId,
                        principalTable: "RequestReservationHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestReservationFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReturnSalesFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnSalesHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnSalesFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnSalesFooter_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnSalesFooter_ReturnSalesHeader_ReturnSalesHeaderId",
                        column: x => x.ReturnSalesHeaderId,
                        principalTable: "ReturnSalesHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnSalesFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    SalesInvoiceHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceFooter_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoiceFooter_SalesInvoiceHeader_SalesInvoiceHeaderId",
                        column: x => x.SalesInvoiceHeaderId,
                        principalTable: "SalesInvoiceHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SettlementDiscount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SettlementNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettlementDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SettlementDiscount_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SettlementDiscount_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SettlementDiscount_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SettlementDiscount_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TransformationsDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransformationsMasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransformationsDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransformationsDetail_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransformationsDetail_TransformationsMaster_TransformationsMasterId",
                        column: x => x.TransformationsMasterId,
                        principalTable: "TransformationsMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransformationsDetail_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PAdditionAdjustment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAdditionAdjustment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PAdditionAdjustment_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PAdditionAdjustment_PItemsHeader_PItemsHeaderId",
                        column: x => x.PItemsHeaderId,
                        principalTable: "PItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PAdditionAdjustment_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PAdditionAdjustment_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PInventoryOrderFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PInventoryHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PPurchaseOrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    TransactionInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PInventoryOrderFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PInventoryOrderFooter_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PInventoryOrderFooter_PInventoryOrderHeader_PInventoryHeaderId",
                        column: x => x.PInventoryHeaderId,
                        principalTable: "PInventoryOrderHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PInventoryOrderFooter_PItemsHeader_PItemsHeaderId",
                        column: x => x.PItemsHeaderId,
                        principalTable: "PItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PInventoryOrderFooter_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PInventoryOrderFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PItemsBalanceFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PItemsBalanceHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PItemsBalanceFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PItemsBalanceFooter_PItemsBalanceHeader_PItemsBalanceHeaderId",
                        column: x => x.PItemsBalanceHeaderId,
                        principalTable: "PItemsBalanceHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsBalanceFooter_PItemsHeader_PItemsHeaderId",
                        column: x => x.PItemsHeaderId,
                        principalTable: "PItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsBalanceFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PRequestReservationFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrequestReservationHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRequestReservationFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRequestReservationFooter_PItemsHeader_PItemsHeaderId",
                        column: x => x.PItemsHeaderId,
                        principalTable: "PItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PRequestReservationFooter_PRequestReservationHeader_PrequestReservationHeaderId",
                        column: x => x.PrequestReservationHeaderId,
                        principalTable: "PRequestReservationHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PRequestReservationFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PReturnReservationFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PreturnReservationHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PitemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PReturnReservationFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PReturnReservationFooter_PItemsHeader_PitemsHeaderId",
                        column: x => x.PitemsHeaderId,
                        principalTable: "PItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PReturnReservationFooter_PReturnReservationHeader_PreturnReservationHeaderId",
                        column: x => x.PreturnReservationHeaderId,
                        principalTable: "PReturnReservationHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PReturnReservationFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchasesOrderFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseOrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasesOrderFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasesOrderFooter_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesOrderFooter_PurchasesOrderHeader_PurchaseOrderHeaderId",
                        column: x => x.PurchaseOrderHeaderId,
                        principalTable: "PurchasesOrderHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesOrderFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchasesInvoiceHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestReceiptHeaderid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BarcodeInvoice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    SuppliersDataid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentsModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasesInvoiceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceHeader_DocumentsMode_DocumentsModesId",
                        column: x => x.DocumentsModesId,
                        principalTable: "DocumentsMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceHeader_PaymentMode_PaymentModesId",
                        column: x => x.PaymentModesId,
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceHeader_RequestReceiptHeader_RequestReceiptHeaderid",
                        column: x => x.RequestReceiptHeaderid,
                        principalTable: "RequestReceiptHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceHeader_SupplierData_SuppliersDataid",
                        column: x => x.SuppliersDataid,
                        principalTable: "SupplierData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestReceiptFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestReceiptHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RequestPurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    RequestPurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    RequestPurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestReceiptFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestReceiptFooter_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestReceiptFooter_RequestReceiptHeader_RequestReceiptHeaderId",
                        column: x => x.RequestReceiptHeaderId,
                        principalTable: "RequestReceiptHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestReceiptFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PPurchasesInvoiceHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrequestReceiptHeaderid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BarcodeInvoice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    SuppliersDataid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentsModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PPurchasesInvoiceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PPurchasesInvoiceHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PPurchasesInvoiceHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PPurchasesInvoiceHeader_PRequestReceiptHeader_PrequestReceiptHeaderid",
                        column: x => x.PrequestReceiptHeaderid,
                        principalTable: "PRequestReceiptHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PPurchasesInvoiceHeader_SupplierData_SuppliersDataid",
                        column: x => x.SuppliersDataid,
                        principalTable: "SupplierData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PRequestReceiptFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PRequestReceiptHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseInfo_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Price = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchaseInfo_Value = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRequestReceiptFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRequestReceiptFooter_PItemsHeader_PItemsHeaderId",
                        column: x => x.PItemsHeaderId,
                        principalTable: "PItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PRequestReceiptFooter_PRequestReceiptHeader_PRequestReceiptHeaderId",
                        column: x => x.PRequestReceiptHeaderId,
                        principalTable: "PRequestReceiptHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PRequestReceiptFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PosSalesDiscount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PossalesDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PosreturnSalesFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiscountTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiscountRate = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DiscountAmount = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosSalesDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosSalesDiscount_PosSalesDetail_PossalesDetailsId",
                        column: x => x.PossalesDetailsId,
                        principalTable: "PosSalesDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceDiscount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesInvoiceFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnSalesFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiscountTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiscountRate = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DiscountAmount = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceDiscount_DiscountType_DiscountTypeId",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoiceDiscount_ReturnSalesFooter_ReturnSalesFooterId",
                        column: x => x.ReturnSalesFooterId,
                        principalTable: "ReturnSalesFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoiceDiscount_SalesInvoiceFooter_SalesInvoiceFooterId",
                        column: x => x.SalesInvoiceFooterId,
                        principalTable: "SalesInvoiceFooter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesTaxInvoiceFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesInvoiceFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnSalesFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaxableTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaxAmount = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTaxInvoiceFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesTaxInvoiceFooter_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesTaxInvoiceFooter_ReturnSalesFooter_ReturnSalesFooterId",
                        column: x => x.ReturnSalesFooterId,
                        principalTable: "ReturnSalesFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesTaxInvoiceFooter_SalesInvoiceFooter_SalesInvoiceFooterId",
                        column: x => x.SalesInvoiceFooterId,
                        principalTable: "SalesInvoiceFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesTaxInvoiceFooter_TaxableType_TaxableTypeId",
                        column: x => x.TaxableTypeId,
                        principalTable: "TaxableType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchasesInvoiceFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchasesInvoiceHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasesInvoiceFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceFooter_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceFooter_PurchasesInvoiceHeader_PurchasesInvoiceHeaderId",
                        column: x => x.PurchasesInvoiceHeaderId,
                        principalTable: "PurchasesInvoiceHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReturnPurchasesHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchasesInvoiceHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BarcodeInvoice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SuppliersDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentsModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchasePricing_TotalValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchasePricing_TotalDiscounts = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchasePricing_TotalTaxs = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PurchasePricing_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnPurchasesHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnPurchasesHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnPurchasesHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnPurchasesHeader_DocumentsMode_DocumentsModesId",
                        column: x => x.DocumentsModesId,
                        principalTable: "DocumentsMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnPurchasesHeader_PaymentMode_PaymentModesId",
                        column: x => x.PaymentModesId,
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnPurchasesHeader_PurchasesInvoiceHeader_PurchasesInvoiceHeaderId",
                        column: x => x.PurchasesInvoiceHeaderId,
                        principalTable: "PurchasesInvoiceHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnPurchasesHeader_SupplierData_SuppliersDataId",
                        column: x => x.SuppliersDataId,
                        principalTable: "SupplierData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PPurchasesInvoiceFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PPurchasesInvoiceHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    ItemNetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PPurchasesInvoiceFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PPurchasesInvoiceFooter_PItemsHeader_PItemsHeaderId",
                        column: x => x.PItemsHeaderId,
                        principalTable: "PItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PPurchasesInvoiceFooter_PPurchasesInvoiceHeader_PPurchasesInvoiceHeaderId",
                        column: x => x.PPurchasesInvoiceHeaderId,
                        principalTable: "PPurchasesInvoiceHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PPurchasesInvoiceFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PReturnPurchasesHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnNo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PinvoicePurchasesHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SuppliersDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentsModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentModesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BarcodeInvoice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PReturnPurchasesHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PReturnPurchasesHeader_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PReturnPurchasesHeader_CompanyData_CompanyDataId",
                        column: x => x.CompanyDataId,
                        principalTable: "CompanyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PReturnPurchasesHeader_DocumentsMode_DocumentsModesId",
                        column: x => x.DocumentsModesId,
                        principalTable: "DocumentsMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PReturnPurchasesHeader_PPurchasesInvoiceHeader_PinvoicePurchasesHeaderId",
                        column: x => x.PinvoicePurchasesHeaderId,
                        principalTable: "PPurchasesInvoiceHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PReturnPurchasesHeader_PaymentMode_PaymentModesId",
                        column: x => x.PaymentModesId,
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PReturnPurchasesHeader_SupplierData_SuppliersDataId",
                        column: x => x.SuppliersDataId,
                        principalTable: "SupplierData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReturnPurchasesFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnPurchasesHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnPurchasesFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnPurchasesFooter_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnPurchasesFooter_ReturnPurchasesHeader_ReturnPurchasesHeaderId",
                        column: x => x.ReturnPurchasesHeaderId,
                        principalTable: "ReturnPurchasesHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnPurchasesFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PReturnPurchasesFooter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PreturnPurchasesHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PitemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricingDetails_UnitPrice = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_ItemValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_DiscountValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_TaxValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    PricingDetails_NetValue = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PReturnPurchasesFooter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PReturnPurchasesFooter_PItemsHeader_PitemsHeaderId",
                        column: x => x.PitemsHeaderId,
                        principalTable: "PItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PReturnPurchasesFooter_PReturnPurchasesHeader_PreturnPurchasesHeaderId",
                        column: x => x.PreturnPurchasesHeaderId,
                        principalTable: "PReturnPurchasesHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PReturnPurchasesFooter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsStock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemsBalanceFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RequestReceiptFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnPurchasesFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SalesInvoiceFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnSalesFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SettlementDiscountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdditionAdjustmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransformationsDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsStock_AdditionAdjustment_AdditionAdjustmentId",
                        column: x => x.AdditionAdjustmentId,
                        principalTable: "AdditionAdjustment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsStock_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsStock_ItemsBalanceFooter_ItemsBalanceFooterId",
                        column: x => x.ItemsBalanceFooterId,
                        principalTable: "ItemsBalanceFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsStock_ItemsHeader_ItemsHeaderId",
                        column: x => x.ItemsHeaderId,
                        principalTable: "ItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsStock_RequestReceiptFooter_RequestReceiptFooterId",
                        column: x => x.RequestReceiptFooterId,
                        principalTable: "RequestReceiptFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsStock_ReturnPurchasesFooter_ReturnPurchasesFooterId",
                        column: x => x.ReturnPurchasesFooterId,
                        principalTable: "ReturnPurchasesFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsStock_ReturnSalesFooter_ReturnSalesFooterId",
                        column: x => x.ReturnSalesFooterId,
                        principalTable: "ReturnSalesFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsStock_SalesInvoiceFooter_SalesInvoiceFooterId",
                        column: x => x.SalesInvoiceFooterId,
                        principalTable: "SalesInvoiceFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsStock_SettlementDiscount_SettlementDiscountId",
                        column: x => x.SettlementDiscountId,
                        principalTable: "SettlementDiscount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsStock_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemsStock_TransformationsDetail_TransformationsDetailId",
                        column: x => x.TransformationsDetailId,
                        principalTable: "TransformationsDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchasesInvoiceDiscount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchasesInvoiceFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnPurchasesFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiscountTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiscountRate = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DiscountAmount = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasesInvoiceDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceDiscount_DiscountType_DiscountTypeId",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceDiscount_PurchasesInvoiceFooter_PurchasesInvoiceFooterId",
                        column: x => x.PurchasesInvoiceFooterId,
                        principalTable: "PurchasesInvoiceFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesInvoiceDiscount_ReturnPurchasesFooter_ReturnPurchasesFooterId",
                        column: x => x.ReturnPurchasesFooterId,
                        principalTable: "ReturnPurchasesFooter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchasesTaxInvoice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoicePurchasesFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnPurchasesFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaxableTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaxAmount = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasesTaxInvoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasesTaxInvoice_PurchasesInvoiceFooter_InvoicePurchasesFooterId",
                        column: x => x.InvoicePurchasesFooterId,
                        principalTable: "PurchasesInvoiceFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesTaxInvoice_ReturnPurchasesFooter_ReturnPurchasesFooterId",
                        column: x => x.ReturnPurchasesFooterId,
                        principalTable: "ReturnPurchasesFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasesTaxInvoice_TaxableType_TaxableTypeId",
                        column: x => x.TaxableTypeId,
                        principalTable: "TaxableType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PItemsStock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchesDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PItemsHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PItemsBalanceFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PRequestReceiptFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PReturnPurchasesFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PRequestReservationFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PReturnReservationFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PSettlementDiscountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PAdditionAdjustmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true, defaultValueSql: "0"),
                    DateInfo_Year = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Month = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "0"),
                    DateInfo_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPosted = table.Column<bool>(type: "bit", nullable: true),
                    PInventoryOrderFooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsNotActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PItemsStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PItemsStock_BranchesData_BranchesDataId",
                        column: x => x.BranchesDataId,
                        principalTable: "BranchesData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsStock_PAdditionAdjustment_PAdditionAdjustmentId",
                        column: x => x.PAdditionAdjustmentId,
                        principalTable: "PAdditionAdjustment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsStock_PInventoryOrderFooter_PInventoryOrderFooterId",
                        column: x => x.PInventoryOrderFooterId,
                        principalTable: "PInventoryOrderFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsStock_PItemsBalanceFooter_PItemsBalanceFooterId",
                        column: x => x.PItemsBalanceFooterId,
                        principalTable: "PItemsBalanceFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsStock_PItemsHeader_PItemsHeaderId",
                        column: x => x.PItemsHeaderId,
                        principalTable: "PItemsHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsStock_PRequestReceiptFooter_PRequestReceiptFooterId",
                        column: x => x.PRequestReceiptFooterId,
                        principalTable: "PRequestReceiptFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsStock_PRequestReservationFooter_PRequestReservationFooterId",
                        column: x => x.PRequestReservationFooterId,
                        principalTable: "PRequestReservationFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsStock_PReturnPurchasesFooter_PReturnPurchasesFooterId",
                        column: x => x.PReturnPurchasesFooterId,
                        principalTable: "PReturnPurchasesFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsStock_PReturnReservationFooter_PReturnReservationFooterId",
                        column: x => x.PReturnReservationFooterId,
                        principalTable: "PReturnReservationFooter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsStock_PSettlementDiscount_PSettlementDiscountId",
                        column: x => x.PSettlementDiscountId,
                        principalTable: "PSettlementDiscount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PItemsStock_StoreData_StoreDataId",
                        column: x => x.StoreDataId,
                        principalTable: "StoreData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountFiscalYear_CompanyDataId",
                table: "AccountFiscalYear",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountFixedDetail_AccountFicationId",
                table: "AccountFixedDetail",
                column: "AccountFicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountFixedDetail_AccountNameId",
                table: "AccountFixedDetail",
                column: "AccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountFixedDetail_AccountNameLevel2Id",
                table: "AccountFixedDetail",
                column: "AccountNameLevel2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AccountFixedDetail_CompanyDataId",
                table: "AccountFixedDetail",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountFixedDetail_CostCenterId",
                table: "AccountFixedDetail",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountName_AccountFicationId",
                table: "AccountName",
                column: "AccountFicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountName_AccountMenuId",
                table: "AccountName",
                column: "AccountMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountName_AccountNameId",
                table: "AccountName",
                column: "AccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountName_AccountNatureId",
                table: "AccountName",
                column: "AccountNatureId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountName_AccountTypeId",
                table: "AccountName",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountName_CompanyDataId",
                table: "AccountName",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountName_CurrencyDataId",
                table: "AccountName",
                column: "CurrencyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountName_ParentCode",
                table: "AccountName",
                column: "ParentCode");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsBalanceFooter_AccountFicationId",
                table: "AccountsBalanceFooter",
                column: "AccountFicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsBalanceFooter_AccountNameId",
                table: "AccountsBalanceFooter",
                column: "AccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsBalanceFooter_AccountsBalanceHeaderId",
                table: "AccountsBalanceFooter",
                column: "AccountsBalanceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsBalanceHeader_BalanceNameId",
                table: "AccountsBalanceHeader",
                column: "BalanceNameId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsBalanceHeader_BranchesDataId",
                table: "AccountsBalanceHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsBalanceHeader_CompanyDataId",
                table: "AccountsBalanceHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionAdjustment_BranchesDataId",
                table: "AdditionAdjustment",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionAdjustment_ItemsHeaderId",
                table: "AdditionAdjustment",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionAdjustment_StoreDataId",
                table: "AdditionAdjustment",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionAdjustment_UnitTypeId",
                table: "AdditionAdjustment",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationMenu_BranchesDataId",
                table: "ApplicationMenu",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationMenu_CompanyDataId",
                table: "ApplicationMenu",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationSetting_CompanyDataId",
                table: "ApplicationSetting",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationSetting_CountryCodeId",
                table: "ApplicationSetting",
                column: "CountryCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationSetting_InventoryValuationId",
                table: "ApplicationSetting",
                column: "InventoryValuationId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_BankCodeId",
                table: "AppUser",
                column: "BankCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspPermission_ApplicationMenuId",
                table: "AspPermission",
                column: "ApplicationMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_AspPermission_AspNetUserId",
                table: "AspPermission",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AttatchmentFile_AttachmentFilesTypeId",
                table: "AttatchmentFile",
                column: "AttachmentFilesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAtm_BankCodeId",
                table: "BankAtm",
                column: "BankCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAtm_BranchesDataId",
                table: "BankAtm",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAtm_CityCodeId",
                table: "BankAtm",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAtm_CompanyDataId",
                table: "BankAtm",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAtm_CountryCodeId",
                table: "BankAtm",
                column: "CountryCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAtm_GovernorateCodeId",
                table: "BankAtm",
                column: "GovernorateCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankCode_CityCodeId",
                table: "BankCode",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankCode_CompanyDataId",
                table: "BankCode",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BankCode_CountryCodeId",
                table: "BankCode",
                column: "CountryCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankCode_CurrencyDataId",
                table: "BankCode",
                column: "CurrencyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BankCode_GovernorateCodeId",
                table: "BankCode",
                column: "GovernorateCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankContract_BankCodeId",
                table: "BankContract",
                column: "BankCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchesData_BranchManagerId",
                table: "BranchesData",
                column: "BranchManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchesData_CityCodeId",
                table: "BranchesData",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchesData_CompanyDataId",
                table: "BranchesData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchesList_BranchesDataId",
                table: "BranchesList",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchesList_CompanyDataId",
                table: "BranchesList",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetail_AccountNameFromId",
                table: "CheckDetail",
                column: "AccountNameFromId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetail_AccountNameToId",
                table: "CheckDetail",
                column: "AccountNameToId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetail_BankNameId",
                table: "CheckDetail",
                column: "BankNameId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetail_BranchesDataId",
                table: "CheckDetail",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetail_CheckStatusId",
                table: "CheckDetail",
                column: "CheckStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetail_CheckTypeId",
                table: "CheckDetail",
                column: "CheckTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetail_CompanyDataId",
                table: "CheckDetail",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetail_CostCenterId",
                table: "CheckDetail",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetail_CurrencyDataId",
                table: "CheckDetail",
                column: "CurrencyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CityCode_GovernorateCodeId",
                table: "CityCode",
                column: "GovernorateCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientAccessToken_ClientDataTokenId",
                table: "ClientAccessToken",
                column: "ClientDataTokenId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDataToken_BranchesDataId",
                table: "ClientDataToken",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDataToken_CompanyDataId",
                table: "ClientDataToken",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyData_ActivityCodeId",
                table: "CompanyData",
                column: "ActivityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyData_CityCodeId",
                table: "CompanyData",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorData_AccountsNameId",
                table: "ConContractorData",
                column: "AccountsNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorData_CityCodeId",
                table: "ConContractorData",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorData_CompanyDataId",
                table: "ConContractorData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorData_ContractorGroupsId",
                table: "ConContractorData",
                column: "ContractorGroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorData_ContractorManagerId",
                table: "ConContractorData",
                column: "ContractorManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorData_CountryCodeId",
                table: "ConContractorData",
                column: "CountryCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorData_GovernorateCodeId",
                table: "ConContractorData",
                column: "GovernorateCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorExtractDetail_ContractorMasterId",
                table: "ConContractorExtractDetail",
                column: "ContractorMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorExtractDetail_ProjectItemsId",
                table: "ConContractorExtractDetail",
                column: "ProjectItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorExtractDetail_UnitTypeId",
                table: "ConContractorExtractDetail",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorExtractMaster_CompanyDataId",
                table: "ConContractorExtractMaster",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorExtractMaster_ContractorDataId",
                table: "ConContractorExtractMaster",
                column: "ContractorDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ConContractorExtractMaster_ProjectDataId",
                table: "ConContractorExtractMaster",
                column: "ProjectDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ConProjectItem_CompanyDataId",
                table: "ConProjectItem",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ConProjectsData_AccountsNameId",
                table: "ConProjectsData",
                column: "AccountsNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ConProjectsData_CompanyDataId",
                table: "ConProjectsData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenter_AccountMenuId",
                table: "CostCenter",
                column: "AccountMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenter_AccountNatureId",
                table: "CostCenter",
                column: "AccountNatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenter_AccountTypeId",
                table: "CostCenter",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenter_BranchesDataId",
                table: "CostCenter",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenter_CompanyDataId",
                table: "CostCenter",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenter_ParentCodeId",
                table: "CostCenter",
                column: "ParentCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_CostGeneralAccountFooter_AccountNameId",
                table: "CostGeneralAccountFooter",
                column: "AccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_CostGeneralAccountFooter_JournalHeaderId",
                table: "CostGeneralAccountFooter",
                column: "JournalHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_CostGeneralAccountHeader_BranchesDataId",
                table: "CostGeneralAccountHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CostGeneralAccountHeader_CompanyDataId",
                table: "CostGeneralAccountHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CostGeneralAccountHeader_CurrencyDataId",
                table: "CostGeneralAccountHeader",
                column: "CurrencyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CostJournalFooter_AccountNameId",
                table: "CostJournalFooter",
                column: "AccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_CostJournalFooter_JournalHeaderId",
                table: "CostJournalFooter",
                column: "JournalHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_CostJournalHeader_BranchesDataId",
                table: "CostJournalHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CostJournalHeader_CompanyDataId",
                table: "CostJournalHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CostJournalHeader_CurrencyDataId",
                table: "CostJournalHeader",
                column: "CurrencyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmOpportunity_ContactId",
                table: "CrmOpportunity",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmOpportunity_StatusId",
                table: "CrmOpportunity",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmTask_OpportunityId",
                table: "CrmTask",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmTask_StatusId",
                table: "CrmTask",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmTask_TypeId",
                table: "CrmTask",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerData_AccountsNameSalesId",
                table: "CustomerData",
                column: "AccountsNameSalesId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerData_CityCodeId",
                table: "CustomerData",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerData_CompanyDataId",
                table: "CustomerData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerData_CustomerCategoriesId",
                table: "CustomerData",
                column: "CustomerCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerData_CustomerModesId",
                table: "CustomerData",
                column: "CustomerModesId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerData_RepresentativeDataId",
                table: "CustomerData",
                column: "RepresentativeDataId");

            migrationBuilder.CreateIndex(
                name: "IX_DatabaseDescription_ParentCodeNavigationId",
                table: "DatabaseDescription",
                column: "ParentCodeNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_DelegateData_AccountsNameId",
                table: "DelegateData",
                column: "AccountsNameId");

            migrationBuilder.CreateIndex(
                name: "IX_DelegateData_CityCodeId",
                table: "DelegateData",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_DelegateData_CompanyDataId",
                table: "DelegateData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduAcademyCourse_BranchesDataId",
                table: "EduAcademyCourse",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduAcademyCourse_ParentCourseId",
                table: "EduAcademyCourse",
                column: "ParentCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_EduQuestionDetail_QuestionsMasterId",
                table: "EduQuestionDetail",
                column: "QuestionsMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_EduQuestionsMaster_AcademyCourseId",
                table: "EduQuestionsMaster",
                column: "AcademyCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_EduQuestionsMaster_BranchesDataId",
                table: "EduQuestionsMaster",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduQuestionsMaster_QuestionTypeId",
                table: "EduQuestionsMaster",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentCourse_StudentDataId",
                table: "EduStudentCourse",
                column: "StudentDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentData_BranchesDataId",
                table: "EduStudentData",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentData_CityCodeId",
                table: "EduStudentData",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentData_CompanyDataId",
                table: "EduStudentData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentData_EducationDataId",
                table: "EduStudentData",
                column: "EducationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentData_EducationeStimateId",
                table: "EduStudentData",
                column: "EducationeStimateId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentData_GenderDataId",
                table: "EduStudentData",
                column: "GenderDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentData_RecruitmentDataId",
                table: "EduStudentData",
                column: "RecruitmentDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentData_SocialDataId",
                table: "EduStudentData",
                column: "SocialDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentData_UniversityDataId",
                table: "EduStudentData",
                column: "UniversityDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentPayment_AcademyCourseId",
                table: "EduStudentPayment",
                column: "AcademyCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentPayment_BranchesDataId",
                table: "EduStudentPayment",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentPayment_CompanyDataId",
                table: "EduStudentPayment",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentPayment_StudentDataId",
                table: "EduStudentPayment",
                column: "StudentDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentQuestion_QuestionAnswerId",
                table: "EduStudentQuestion",
                column: "QuestionAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_EduStudentQuestion_StudentDataId",
                table: "EduStudentQuestion",
                column: "StudentDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpAccept_EmpAcceptTypeId",
                table: "EmpAccept",
                column: "EmpAcceptTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpAccept_EmployeesDataId",
                table: "EmpAccept",
                column: "EmployeesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpAttend_AttendTypeId",
                table: "EmpAttend",
                column: "AttendTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpAttend_EmpDayWeekId",
                table: "EmpAttend",
                column: "EmpDayWeekId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpAttend_EmployeesDataId",
                table: "EmpAttend",
                column: "EmployeesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpContractFooter_EmpContractHid",
                table: "EmpContractFooter",
                column: "EmpContractHid");

            migrationBuilder.CreateIndex(
                name: "IX_EmpContractFooter_EmpElementDataId",
                table: "EmpContractFooter",
                column: "EmpElementDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpContractFooter_EmpElementTypeId",
                table: "EmpContractFooter",
                column: "EmpElementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpContractHeader_BranchesDataId",
                table: "EmpContractHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpContractHeader_CompanyDataId",
                table: "EmpContractHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpContractHeader_EmpContractTypeId",
                table: "EmpContractHeader",
                column: "EmpContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpContractHeader_EmployeesDataId",
                table: "EmpContractHeader",
                column: "EmployeesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpElementData_EmpElemntNatureId",
                table: "EmpElementData",
                column: "EmpElemntNatureId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpElementData_EmpElemntTypeId",
                table: "EmpElementData",
                column: "EmpElemntTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpGroupWork_BranchesDataId",
                table: "EmpGroupWork",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpLevel_EmpLevelTypeId",
                table: "EmpLevel",
                column: "EmpLevelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpLevel_EmployeesDataId",
                table: "EmpLevel",
                column: "EmployeesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpLoans_EmpLoansTypeId",
                table: "EmpLoans",
                column: "EmpLoansTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpLoans_EmployeesDataId",
                table: "EmpLoans",
                column: "EmployeesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCourse_EmployeeDataId",
                table: "EmployeeCourse",
                column: "EmployeeDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_BranchesDataId",
                table: "EmployeeData",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_CityCodeId",
                table: "EmployeeData",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_DepartmentId",
                table: "EmployeeData",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_EducationDataId",
                table: "EmployeeData",
                column: "EducationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_EducationStimateId",
                table: "EmployeeData",
                column: "EducationStimateId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_GenderDataId",
                table: "EmployeeData",
                column: "GenderDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_GroupWorkId",
                table: "EmployeeData",
                column: "GroupWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_JobDataId",
                table: "EmployeeData",
                column: "JobDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_PaymentTypeId",
                table: "EmployeeData",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_RecruitmentDataId",
                table: "EmployeeData",
                column: "RecruitmentDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_SocialDataId",
                table: "EmployeeData",
                column: "SocialDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_UniversityDataId",
                table: "EmployeeData",
                column: "UniversityDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJob_EmployeeDataId",
                table: "EmployeeJob",
                column: "EmployeeDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkills_EmployeeDataId",
                table: "EmployeeSkills",
                column: "EmployeeDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalData_BranchesDataId",
                table: "FinalData",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalData_CompanyDataId",
                table: "FinalData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalData_EmployeeDataId",
                table: "FinalData",
                column: "EmployeeDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalDataFixed_BranchesDataId",
                table: "FinalDataFixed",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalDataFixed_CompanyDataId",
                table: "FinalDataFixed",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalDataFixed_EmployeeDataId",
                table: "FinalDataFixed",
                column: "EmployeeDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialCenter_AccountFicationId",
                table: "FinancialCenter",
                column: "AccountFicationId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialCenter_AccountNameId",
                table: "FinancialCenter",
                column: "AccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialCenter_CompanyDataId",
                table: "FinancialCenter",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAccountFooter_AccountNameId",
                table: "GeneralAccountFooter",
                column: "AccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAccountFooter_CostCenterId",
                table: "GeneralAccountFooter",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAccountFooter_GeneralAccountHeaderId",
                table: "GeneralAccountFooter",
                column: "GeneralAccountHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAccountHeader_BranchesDataId",
                table: "GeneralAccountHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAccountHeader_CompanyDataId",
                table: "GeneralAccountHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_GovernorateCode_CountryCodeId",
                table: "GovernorateCode",
                column: "CountryCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelPayment_BranchesDataId",
                table: "HotelPayment",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelPayment_CompanyDataId",
                table: "HotelPayment",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelPayment_CustomerDataId",
                table: "HotelPayment",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelPayment_HotelReservationMasterId",
                table: "HotelPayment",
                column: "HotelReservationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationDetail_ReservationMasterId",
                table: "HotelReservationDetail",
                column: "ReservationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationDetail_ServicesId",
                table: "HotelReservationDetail",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationMaster_BranchesDataId",
                table: "HotelReservationMaster",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationMaster_CompanyDataId",
                table: "HotelReservationMaster",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationMaster_CustomerDataId",
                table: "HotelReservationMaster",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationMaster_RoomId",
                table: "HotelReservationMaster",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoomData_BranchesDataId",
                table: "HotelRoomData",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoomData_CompanyDataId",
                table: "HotelRoomData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoomData_ParentId",
                table: "HotelRoomData",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelService_BranchesDataId",
                table: "HotelService",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelService_CompanyDataId",
                table: "HotelService",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_InstallmentFooter_InstallmentHeaderId",
                table: "InstallmentFooter",
                column: "InstallmentHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_InstallmentHeader_BranchesDataId",
                table: "InstallmentHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_InstallmentHeader_CompanyDataId",
                table: "InstallmentHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_InstallmentHeader_CustomerDataId",
                table: "InstallmentHeader",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryOrderFooter_InventoryOrderHeaderId",
                table: "InventoryOrderFooter",
                column: "InventoryOrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryOrderFooter_ItemsHeaderId",
                table: "InventoryOrderFooter",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryOrderFooter_UnitTypeId",
                table: "InventoryOrderFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryOrderHeader_BranchesDataId",
                table: "InventoryOrderHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryOrderHeader_CompanyDataId",
                table: "InventoryOrderHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryOrderHeader_StoreDataId",
                table: "InventoryOrderHeader",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsBalanceFooter_ItemsBalanceHeaderId",
                table: "ItemsBalanceFooter",
                column: "ItemsBalanceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsBalanceFooter_ItemsHeaderId",
                table: "ItemsBalanceFooter",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsBalanceFooter_UnitTypeId",
                table: "ItemsBalanceFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsBalanceHeader_BalanceNameId",
                table: "ItemsBalanceHeader",
                column: "BalanceNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsBalanceHeader_BranchesDataId",
                table: "ItemsBalanceHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsBalanceHeader_CompanyDataId",
                table: "ItemsBalanceHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsBalanceHeader_StoreDataId",
                table: "ItemsBalanceHeader",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsColor_ColorTypeId",
                table: "ItemsColor",
                column: "ColorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsColor_ItemHeaderId",
                table: "ItemsColor",
                column: "ItemHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsColor_SizeTypeId",
                table: "ItemsColor",
                column: "SizeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsGroup_CompanyDataId",
                table: "ItemsGroup",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsGroup_ParentCodeNavigationId",
                table: "ItemsGroup",
                column: "ParentCodeNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHeader_CompanyDataId",
                table: "ItemsHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHeader_ItemsCodeTypeId",
                table: "ItemsHeader",
                column: "ItemsCodeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHeader_ItemsGroupsId",
                table: "ItemsHeader",
                column: "ItemsGroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHeader_ItemsTypeId",
                table: "ItemsHeader",
                column: "ItemsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHeader_SupplierDataId",
                table: "ItemsHeader",
                column: "SupplierDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHeader_UnitTypeId",
                table: "ItemsHeader",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSize_ItemHeaderId",
                table: "ItemSize",
                column: "ItemHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSize_SizeTypeId",
                table: "ItemSize",
                column: "SizeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPricePurchase_ItemsHeaderId",
                table: "ItemsPricePurchase",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPricePurchase_SupplierDataId",
                table: "ItemsPricePurchase",
                column: "SupplierDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPriceSale_ItemsHeaderId",
                table: "ItemsPriceSale",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPriceSale_PriceTypeId",
                table: "ItemsPriceSale",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPriceSale_UnitTypeId",
                table: "ItemsPriceSale",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsProduction_ItemsHeaderId",
                table: "ItemsProduction",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_AdditionAdjustmentId",
                table: "ItemsStock",
                column: "AdditionAdjustmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_BranchesDataId",
                table: "ItemsStock",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_ItemsBalanceFooterId",
                table: "ItemsStock",
                column: "ItemsBalanceFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_ItemsHeaderId",
                table: "ItemsStock",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_RequestReceiptFooterId",
                table: "ItemsStock",
                column: "RequestReceiptFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_ReturnPurchasesFooterId",
                table: "ItemsStock",
                column: "ReturnPurchasesFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_ReturnSalesFooterId",
                table: "ItemsStock",
                column: "ReturnSalesFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_SalesInvoiceFooterId",
                table: "ItemsStock",
                column: "SalesInvoiceFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_SettlementDiscountId",
                table: "ItemsStock",
                column: "SettlementDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_StoreDataId",
                table: "ItemsStock",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsStock_TransformationsDetailId",
                table: "ItemsStock",
                column: "TransformationsDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalFooter_AccountNameId",
                table: "JournalFooter",
                column: "AccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalFooter_CostCenterId",
                table: "JournalFooter",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalFooter_JournalHeaderId",
                table: "JournalFooter",
                column: "JournalHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalHeader_BranchesDataId",
                table: "JournalHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalHeader_CompanyDataId",
                table: "JournalHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalHeader_CurrencyDataId",
                table: "JournalHeader",
                column: "CurrencyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_LockersData_AccountNameId",
                table: "LockersData",
                column: "AccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LockersData_BranchesDataId",
                table: "LockersData",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_LockersData_CompanyDataId",
                table: "LockersData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MedAnalysisName_BranchesDataId",
                table: "MedAnalysisName",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MedCustomerDetail_AnalysisNameId",
                table: "MedCustomerDetail",
                column: "AnalysisNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MedCustomerDetail_CustomerDataId",
                table: "MedCustomerDetail",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MedCustomerDetail_RaysNameId",
                table: "MedCustomerDetail",
                column: "RaysNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MedCustomerMedicalService_CustomerDataId",
                table: "MedCustomerMedicalService",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MedCustomerMedicalService_MedicalServicesId",
                table: "MedCustomerMedicalService",
                column: "MedicalServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_MedCustomerSurgicalService_CustomerDataId",
                table: "MedCustomerSurgicalService",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MedCustomerSurgicalService_SurgicalServicesId",
                table: "MedCustomerSurgicalService",
                column: "SurgicalServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_MedMedicalService_BranchesDataId",
                table: "MedMedicalService",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MedPartnerData_BranchesDataId",
                table: "MedPartnerData",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MedPartnerData_CityCodeId",
                table: "MedPartnerData",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedPartnerData_JobDataId",
                table: "MedPartnerData",
                column: "JobDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MedRaysName_BranchesDataId",
                table: "MedRaysName",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MedSurgicalService_BranchesDataId",
                table: "MedSurgicalService",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyPayment_BranchesDataId",
                table: "MoneyPayment",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyPayment_CompanyDataId",
                table: "MoneyPayment",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyPayment_CostCenterId",
                table: "MoneyPayment",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyPayment_FromAccountNameId",
                table: "MoneyPayment",
                column: "FromAccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyPayment_FromCashId",
                table: "MoneyPayment",
                column: "FromCashId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyPayment_ToAccountNameId",
                table: "MoneyPayment",
                column: "ToAccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyReceive_BranchesDataId",
                table: "MoneyReceive",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyReceive_CompanyDataId",
                table: "MoneyReceive",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyReceive_CostCenterId",
                table: "MoneyReceive",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyReceive_FromAccountNameId",
                table: "MoneyReceive",
                column: "FromAccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyReceive_FromCashId",
                table: "MoneyReceive",
                column: "FromCashId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyReceive_ToAccountNameId",
                table: "MoneyReceive",
                column: "ToAccountNameId");

            migrationBuilder.CreateIndex(
                name: "IX_PAdditionAdjustment_BranchesDataId",
                table: "PAdditionAdjustment",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PAdditionAdjustment_PItemsHeaderId",
                table: "PAdditionAdjustment",
                column: "PItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PAdditionAdjustment_StoreDataId",
                table: "PAdditionAdjustment",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PAdditionAdjustment_UnitTypeId",
                table: "PAdditionAdjustment",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PInventoryOrderFooter_BranchesDataId",
                table: "PInventoryOrderFooter",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PInventoryOrderFooter_PInventoryHeaderId",
                table: "PInventoryOrderFooter",
                column: "PInventoryHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PInventoryOrderFooter_PItemsHeaderId",
                table: "PInventoryOrderFooter",
                column: "PItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PInventoryOrderFooter_StoreDataId",
                table: "PInventoryOrderFooter",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PInventoryOrderFooter_UnitTypeId",
                table: "PInventoryOrderFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PInventoryOrderHeader_BranchesDataId",
                table: "PInventoryOrderHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PInventoryOrderHeader_CompanyDataId",
                table: "PInventoryOrderHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PInventoryOrderHeader_StoreDataId",
                table: "PInventoryOrderHeader",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsBalanceFooter_PItemsBalanceHeaderId",
                table: "PItemsBalanceFooter",
                column: "PItemsBalanceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsBalanceFooter_PItemsHeaderId",
                table: "PItemsBalanceFooter",
                column: "PItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsBalanceFooter_UnitTypeId",
                table: "PItemsBalanceFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsBalanceHeader_BranchesDataId",
                table: "PItemsBalanceHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsBalanceHeader_CompanyDataId",
                table: "PItemsBalanceHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsBalanceHeader_StoreDataId",
                table: "PItemsBalanceHeader",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsGroup_CompanyDataId",
                table: "PItemsGroup",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsGroup_ParentCodeNavigationId",
                table: "PItemsGroup",
                column: "ParentCodeNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsHeader_AccountNameSalesId",
                table: "PItemsHeader",
                column: "AccountNameSalesId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsHeader_AccountsNamePurchasId",
                table: "PItemsHeader",
                column: "AccountsNamePurchasId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsHeader_BranchesDataId",
                table: "PItemsHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsHeader_CompanyDataId",
                table: "PItemsHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsHeader_ItemsTypeId",
                table: "PItemsHeader",
                column: "ItemsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsHeader_PitemsGroupsId",
                table: "PItemsHeader",
                column: "PitemsGroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsHeader_SupplierDataId",
                table: "PItemsHeader",
                column: "SupplierDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_BranchesDataId",
                table: "PItemsStock",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_PAdditionAdjustmentId",
                table: "PItemsStock",
                column: "PAdditionAdjustmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_PInventoryOrderFooterId",
                table: "PItemsStock",
                column: "PInventoryOrderFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_PItemsBalanceFooterId",
                table: "PItemsStock",
                column: "PItemsBalanceFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_PItemsHeaderId",
                table: "PItemsStock",
                column: "PItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_PRequestReceiptFooterId",
                table: "PItemsStock",
                column: "PRequestReceiptFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_PRequestReservationFooterId",
                table: "PItemsStock",
                column: "PRequestReservationFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_PReturnPurchasesFooterId",
                table: "PItemsStock",
                column: "PReturnPurchasesFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_PReturnReservationFooterId",
                table: "PItemsStock",
                column: "PReturnReservationFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_PSettlementDiscountId",
                table: "PItemsStock",
                column: "PSettlementDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_PItemsStock_StoreDataId",
                table: "PItemsStock",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PosMachine_BranchesDataId",
                table: "PosMachine",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PosPaymentDaily_PaymentModesId",
                table: "PosPaymentDaily",
                column: "PaymentModesId");

            migrationBuilder.CreateIndex(
                name: "IX_PosPaymentDaily_PossalesId",
                table: "PosPaymentDaily",
                column: "PossalesId");

            migrationBuilder.CreateIndex(
                name: "IX_PosSale_BranchesDataId",
                table: "PosSale",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PosSale_CustomerDataId",
                table: "PosSale",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PosSale_PriceTypeId",
                table: "PosSale",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PosSalesDetail_ItemsHeaderId",
                table: "PosSalesDetail",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PosSalesDetail_PosSalesId",
                table: "PosSalesDetail",
                column: "PosSalesId");

            migrationBuilder.CreateIndex(
                name: "IX_PosSalesDiscount_PossalesDetailsId",
                table: "PosSalesDiscount",
                column: "PossalesDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_PosSession_BranchesDataId",
                table: "PosSession",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PosSession_EmployeesDataId",
                table: "PosSession",
                column: "EmployeesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PPurchasesInvoiceFooter_PItemsHeaderId",
                table: "PPurchasesInvoiceFooter",
                column: "PItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PPurchasesInvoiceFooter_PPurchasesInvoiceHeaderId",
                table: "PPurchasesInvoiceFooter",
                column: "PPurchasesInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PPurchasesInvoiceFooter_UnitTypeId",
                table: "PPurchasesInvoiceFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PPurchasesInvoiceHeader_BranchesDataId",
                table: "PPurchasesInvoiceHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PPurchasesInvoiceHeader_CompanyDataId",
                table: "PPurchasesInvoiceHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PPurchasesInvoiceHeader_PrequestReceiptHeaderid",
                table: "PPurchasesInvoiceHeader",
                column: "PrequestReceiptHeaderid");

            migrationBuilder.CreateIndex(
                name: "IX_PPurchasesInvoiceHeader_SuppliersDataid",
                table: "PPurchasesInvoiceHeader",
                column: "SuppliersDataid");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReceiptFooter_PItemsHeaderId",
                table: "PRequestReceiptFooter",
                column: "PItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReceiptFooter_PRequestReceiptHeaderId",
                table: "PRequestReceiptFooter",
                column: "PRequestReceiptHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReceiptFooter_UnitTypeId",
                table: "PRequestReceiptFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReceiptHeader_BranchesDataId",
                table: "PRequestReceiptHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReceiptHeader_CompanyDataId",
                table: "PRequestReceiptHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReceiptHeader_PpurchaseOrderHeaderId",
                table: "PRequestReceiptHeader",
                column: "PpurchaseOrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReceiptHeader_StoreDataId",
                table: "PRequestReceiptHeader",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReservationFooter_PItemsHeaderId",
                table: "PRequestReservationFooter",
                column: "PItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReservationFooter_PrequestReservationHeaderId",
                table: "PRequestReservationFooter",
                column: "PrequestReservationHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReservationFooter_UnitTypeId",
                table: "PRequestReservationFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReservationHeader_BranchesDataId",
                table: "PRequestReservationHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PRequestReservationHeader_CompanyDataId",
                table: "PRequestReservationHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnPurchasesFooter_PitemsHeaderId",
                table: "PReturnPurchasesFooter",
                column: "PitemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnPurchasesFooter_PreturnPurchasesHeaderId",
                table: "PReturnPurchasesFooter",
                column: "PreturnPurchasesHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnPurchasesFooter_UnitTypeId",
                table: "PReturnPurchasesFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnPurchasesHeader_BranchesDataId",
                table: "PReturnPurchasesHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnPurchasesHeader_CompanyDataId",
                table: "PReturnPurchasesHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnPurchasesHeader_DocumentsModesId",
                table: "PReturnPurchasesHeader",
                column: "DocumentsModesId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnPurchasesHeader_PaymentModesId",
                table: "PReturnPurchasesHeader",
                column: "PaymentModesId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnPurchasesHeader_PinvoicePurchasesHeaderId",
                table: "PReturnPurchasesHeader",
                column: "PinvoicePurchasesHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnPurchasesHeader_SuppliersDataId",
                table: "PReturnPurchasesHeader",
                column: "SuppliersDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnReservationFooter_PitemsHeaderId",
                table: "PReturnReservationFooter",
                column: "PitemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnReservationFooter_PreturnReservationHeaderId",
                table: "PReturnReservationFooter",
                column: "PreturnReservationHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnReservationFooter_UnitTypeId",
                table: "PReturnReservationFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnReservationHeader_BranchesDataId",
                table: "PReturnReservationHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PReturnReservationHeader_CompanyDataId",
                table: "PReturnReservationHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramOption_ApplicationMenuId",
                table: "ProgramOption",
                column: "ApplicationMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_PSettlementDiscount_BranchesDataId",
                table: "PSettlementDiscount",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PSettlementDiscount_ItemsHeaderId",
                table: "PSettlementDiscount",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PSettlementDiscount_StoreDataId",
                table: "PSettlementDiscount",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PSettlementDiscount_UnitTypeId",
                table: "PSettlementDiscount",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceDiscount_DiscountTypeId",
                table: "PurchasesInvoiceDiscount",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceDiscount_PurchasesInvoiceFooterId",
                table: "PurchasesInvoiceDiscount",
                column: "PurchasesInvoiceFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceDiscount_ReturnPurchasesFooterId",
                table: "PurchasesInvoiceDiscount",
                column: "ReturnPurchasesFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceFooter_ItemsHeaderId",
                table: "PurchasesInvoiceFooter",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceFooter_PurchasesInvoiceHeaderId",
                table: "PurchasesInvoiceFooter",
                column: "PurchasesInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceFooter_UnitTypeId",
                table: "PurchasesInvoiceFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceHeader_BranchesDataId",
                table: "PurchasesInvoiceHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceHeader_CompanyDataId",
                table: "PurchasesInvoiceHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceHeader_DocumentsModesId",
                table: "PurchasesInvoiceHeader",
                column: "DocumentsModesId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceHeader_PaymentModesId",
                table: "PurchasesInvoiceHeader",
                column: "PaymentModesId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceHeader_RequestReceiptHeaderid",
                table: "PurchasesInvoiceHeader",
                column: "RequestReceiptHeaderid");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesInvoiceHeader_SuppliersDataid",
                table: "PurchasesInvoiceHeader",
                column: "SuppliersDataid");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesOrderFooter_ItemsHeaderId",
                table: "PurchasesOrderFooter",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesOrderFooter_PurchaseOrderHeaderId",
                table: "PurchasesOrderFooter",
                column: "PurchaseOrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesOrderFooter_UnitTypeId",
                table: "PurchasesOrderFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesOrderHeader_BranchesDataId",
                table: "PurchasesOrderHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesOrderHeader_CompanyDataId",
                table: "PurchasesOrderHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesOrderHeader_SupplierDataId",
                table: "PurchasesOrderHeader",
                column: "SupplierDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesTaxInvoice_InvoicePurchasesFooterId",
                table: "PurchasesTaxInvoice",
                column: "InvoicePurchasesFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesTaxInvoice_ReturnPurchasesFooterId",
                table: "PurchasesTaxInvoice",
                column: "ReturnPurchasesFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesTaxInvoice_TaxableTypeId",
                table: "PurchasesTaxInvoice",
                column: "TaxableTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportsName_ApplicationMenuId",
                table: "ReportsName",
                column: "ApplicationMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReceiptFooter_ItemsHeaderId",
                table: "RequestReceiptFooter",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReceiptFooter_RequestReceiptHeaderId",
                table: "RequestReceiptFooter",
                column: "RequestReceiptHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReceiptFooter_UnitTypeId",
                table: "RequestReceiptFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReceiptHeader_BranchesDataId",
                table: "RequestReceiptHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReceiptHeader_CompanyDataId",
                table: "RequestReceiptHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReceiptHeader_PurchaseOrderHeaderId",
                table: "RequestReceiptHeader",
                column: "PurchaseOrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReceiptHeader_StoreDataId",
                table: "RequestReceiptHeader",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReservationFooter_ItemsHeaderId",
                table: "RequestReservationFooter",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReservationFooter_RequestReservationHeaderId",
                table: "RequestReservationFooter",
                column: "RequestReservationHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReservationFooter_UnitTypeId",
                table: "RequestReservationFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReservationHeader_BranchesDataId",
                table: "RequestReservationHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReservationHeader_CompanyDataId",
                table: "RequestReservationHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDebit_BranchesDataId",
                table: "ReservationDebit",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDebit_CompanyDataId",
                table: "ReservationDebit",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDebit_CostCenterId",
                table: "ReservationDebit",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDebit_ReservationFromId",
                table: "ReservationDebit",
                column: "ReservationFromId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDebit_ReservationStatusId",
                table: "ReservationDebit",
                column: "ReservationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDebit_ReservationToId",
                table: "ReservationDebit",
                column: "ReservationToId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnPurchasesFooter_ItemsHeaderId",
                table: "ReturnPurchasesFooter",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnPurchasesFooter_ReturnPurchasesHeaderId",
                table: "ReturnPurchasesFooter",
                column: "ReturnPurchasesHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnPurchasesFooter_UnitTypeId",
                table: "ReturnPurchasesFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnPurchasesHeader_BranchesDataId",
                table: "ReturnPurchasesHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnPurchasesHeader_CompanyDataId",
                table: "ReturnPurchasesHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnPurchasesHeader_DocumentsModesId",
                table: "ReturnPurchasesHeader",
                column: "DocumentsModesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnPurchasesHeader_PaymentModesId",
                table: "ReturnPurchasesHeader",
                column: "PaymentModesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnPurchasesHeader_PurchasesInvoiceHeaderId",
                table: "ReturnPurchasesHeader",
                column: "PurchasesInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnPurchasesHeader_SuppliersDataId",
                table: "ReturnPurchasesHeader",
                column: "SuppliersDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSalesFooter_ItemsHeaderId",
                table: "ReturnSalesFooter",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSalesFooter_ReturnSalesHeaderId",
                table: "ReturnSalesFooter",
                column: "ReturnSalesHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSalesFooter_UnitTypeId",
                table: "ReturnSalesFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSalesHeader_BranchesDataId",
                table: "ReturnSalesHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSalesHeader_CompanyDataId",
                table: "ReturnSalesHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSalesHeader_CustomerDataId",
                table: "ReturnSalesHeader",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSalesHeader_DocumentsModesId",
                table: "ReturnSalesHeader",
                column: "DocumentsModesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSalesHeader_InvoiceSalesHeaderId",
                table: "ReturnSalesHeader",
                column: "InvoiceSalesHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSalesHeader_PaymentModesId",
                table: "ReturnSalesHeader",
                column: "PaymentModesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSalesHeader_PriceTypeId",
                table: "ReturnSalesHeader",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RntActivity_BranchesDataId",
                table: "RntActivity",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntContractsData_ContractsHeaderId",
                table: "RntContractsData",
                column: "ContractsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_RntContractsData_FloorsId",
                table: "RntContractsData",
                column: "FloorsId");

            migrationBuilder.CreateIndex(
                name: "IX_RntContractsData_UnitTypeId",
                table: "RntContractsData",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RntContractsHeader_ActivitiesId1",
                table: "RntContractsHeader",
                column: "ActivitiesId1");

            migrationBuilder.CreateIndex(
                name: "IX_RntContractsHeader_BranchesDataId",
                table: "RntContractsHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntContractsHeader_CompanyDataId",
                table: "RntContractsHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntContractsHeader_CustomerDataId",
                table: "RntContractsHeader",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntCustomerPercentData_CustomerPercentId",
                table: "RntCustomerPercentData",
                column: "CustomerPercentId");

            migrationBuilder.CreateIndex(
                name: "IX_RntCustomerPercentHeader_BranchesDataId",
                table: "RntCustomerPercentHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntCustomerPercentHeader_CompanyDataId",
                table: "RntCustomerPercentHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntCustomerPercentHeader_CustomerDataId",
                table: "RntCustomerPercentHeader",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntExpense_BranchesDataId",
                table: "RntExpense",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntExpense_ExpenseTypeId",
                table: "RntExpense",
                column: "ExpenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RntExpenseType_BranchesDataId",
                table: "RntExpenseType",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntFloor_BranchesDataId",
                table: "RntFloor",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntFloor_ParentCodeNavigationId",
                table: "RntFloor",
                column: "ParentCodeNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_RntReceiptsData_ReceiptHeaderNavigationId",
                table: "RntReceiptsData",
                column: "ReceiptHeaderNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_RntReceiptsHeader_BranchesDataId",
                table: "RntReceiptsHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntReceiptsHeader_CompanyDataId",
                table: "RntReceiptsHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RntReceiptsHeader_ContractsId",
                table: "RntReceiptsHeader",
                column: "ContractsId");

            migrationBuilder.CreateIndex(
                name: "IX_RntReceiptsHeader_CurrencyDataId",
                table: "RntReceiptsHeader",
                column: "CurrencyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceDelivery_DeliveryModesId",
                table: "SalesInvoiceDelivery",
                column: "DeliveryModesId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceDelivery_InvoiceSalesHeaderId",
                table: "SalesInvoiceDelivery",
                column: "InvoiceSalesHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceDiscount_DiscountTypeId",
                table: "SalesInvoiceDiscount",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceDiscount_ReturnSalesFooterId",
                table: "SalesInvoiceDiscount",
                column: "ReturnSalesFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceDiscount_SalesInvoiceFooterId",
                table: "SalesInvoiceDiscount",
                column: "SalesInvoiceFooterId",
                unique: true,
                filter: "[SalesInvoiceFooterId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceFooter_ItemsHeaderId",
                table: "SalesInvoiceFooter",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceFooter_SalesInvoiceHeaderId",
                table: "SalesInvoiceFooter",
                column: "SalesInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceFooter_UnitTypeId",
                table: "SalesInvoiceFooter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_BranchesDataId",
                table: "SalesInvoiceHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_CompanyDataId",
                table: "SalesInvoiceHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_CustomerDataId",
                table: "SalesInvoiceHeader",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_DocumentsModesId",
                table: "SalesInvoiceHeader",
                column: "DocumentsModesId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_PaymentModesId",
                table: "SalesInvoiceHeader",
                column: "PaymentModesId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_PriceTypeId",
                table: "SalesInvoiceHeader",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_RequestReservationHeaderId",
                table: "SalesInvoiceHeader",
                column: "RequestReservationHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoicePayment_BankCodeId",
                table: "SalesInvoicePayment",
                column: "BankCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoicePayment_PaymentModesId",
                table: "SalesInvoicePayment",
                column: "PaymentModesId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoicePayment_SalesInvoiceHeaderId",
                table: "SalesInvoicePayment",
                column: "SalesInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTaxInvoiceFooter_ItemsHeaderId",
                table: "SalesTaxInvoiceFooter",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTaxInvoiceFooter_ReturnSalesFooterId",
                table: "SalesTaxInvoiceFooter",
                column: "ReturnSalesFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTaxInvoiceFooter_SalesInvoiceFooterId",
                table: "SalesTaxInvoiceFooter",
                column: "SalesInvoiceFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTaxInvoiceFooter_TaxableTypeId",
                table: "SalesTaxInvoiceFooter",
                column: "TaxableTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTaxInvoiceHeader_BranchesDataId",
                table: "SalesTaxInvoiceHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTaxInvoiceHeader_CompanyDataId",
                table: "SalesTaxInvoiceHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTaxInvoiceHeader_ReturnSalesHeaderId",
                table: "SalesTaxInvoiceHeader",
                column: "ReturnSalesHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTaxInvoiceHeader_SalesInvoiceHeaderId",
                table: "SalesTaxInvoiceHeader",
                column: "SalesInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTaxInvoiceHeader_TaxableTypeId",
                table: "SalesTaxInvoiceHeader",
                column: "TaxableTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SettlementDiscount_BranchesDataId",
                table: "SettlementDiscount",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SettlementDiscount_ItemsHeaderId",
                table: "SettlementDiscount",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SettlementDiscount_StoreDataId",
                table: "SettlementDiscount",
                column: "StoreDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SettlementDiscount_UnitTypeId",
                table: "SettlementDiscount",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreData_AccountsNameId",
                table: "StoreData",
                column: "AccountsNameId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreData_BranchesDataId",
                table: "StoreData",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreData_CityCodeId",
                table: "StoreData",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreData_StoreManagerNavigationId",
                table: "StoreData",
                column: "StoreManagerNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierData_AccountsNameId",
                table: "SupplierData",
                column: "AccountsNameId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierData_CityCodeId",
                table: "SupplierData",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierData_CompanyDataId",
                table: "SupplierData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierData_SupplierGroupsId",
                table: "SupplierData",
                column: "SupplierGroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierData_SupplierManagerNavigationId",
                table: "SupplierData",
                column: "SupplierManagerNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxableType_ParentCodeId",
                table: "TaxableType",
                column: "ParentCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantUser_TenantId",
                table: "TenantUser",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TransformationsDetail_ItemsHeaderId",
                table: "TransformationsDetail",
                column: "ItemsHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_TransformationsDetail_TransformationsMasterId",
                table: "TransformationsDetail",
                column: "TransformationsMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_TransformationsDetail_UnitTypeId",
                table: "TransformationsDetail",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransformationsMaster_CompanyDataId",
                table: "TransformationsMaster",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_TransformationsMaster_FromId",
                table: "TransformationsMaster",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_TransformationsMaster_ToId",
                table: "TransformationsMaster",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_UsePermissions_ApplicationMenuId",
                table: "UsePermissions",
                column: "ApplicationMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_UsePermissions_AppUserId",
                table: "UsePermissions",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatsAppMessageData_BranchesDataId",
                table: "WhatsAppMessageData",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatsAppMessageData_CompanyDataId",
                table: "WhatsAppMessageData",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatsAppResult_CustomerDataId",
                table: "WhatsAppResult",
                column: "CustomerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatsAppResult_MessageDataId",
                table: "WhatsAppResult",
                column: "MessageDataId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanComment_WorkPlanFooterId",
                table: "WorkPlanComment",
                column: "WorkPlanFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanDetail_WorkPlanFooterId",
                table: "WorkPlanDetail",
                column: "WorkPlanFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanFooter_AppUserId",
                table: "WorkPlanFooter",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanFooter_BankAtmid",
                table: "WorkPlanFooter",
                column: "BankAtmid");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanFooter_OrderStatusId",
                table: "WorkPlanFooter",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanFooter_WorkPlanHeaderId",
                table: "WorkPlanFooter",
                column: "WorkPlanHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanHeader_BankCodeId",
                table: "WorkPlanHeader",
                column: "BankCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanHeader_BranchesDataId",
                table: "WorkPlanHeader",
                column: "BranchesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanHeader_CityCodeId",
                table: "WorkPlanHeader",
                column: "CityCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanHeader_CompanyDataId",
                table: "WorkPlanHeader",
                column: "CompanyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanHeader_CountryCodeId",
                table: "WorkPlanHeader",
                column: "CountryCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlanHeader_GovernorateCodeId",
                table: "WorkPlanHeader",
                column: "GovernorateCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountFixedDetail_CostCenter_CostCenterId",
                table: "AccountFixedDetail",
                column: "CostCenterId",
                principalTable: "CostCenter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountsBalanceFooter_AccountsBalanceHeader_AccountsBalanceHeaderId",
                table: "AccountsBalanceFooter",
                column: "AccountsBalanceHeaderId",
                principalTable: "AccountsBalanceHeader",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountsBalanceHeader_BranchesData_BranchesDataId",
                table: "AccountsBalanceHeader",
                column: "BranchesDataId",
                principalTable: "BranchesData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionAdjustment_BranchesData_BranchesDataId",
                table: "AdditionAdjustment",
                column: "BranchesDataId",
                principalTable: "BranchesData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionAdjustment_ItemsHeader_ItemsHeaderId",
                table: "AdditionAdjustment",
                column: "ItemsHeaderId",
                principalTable: "ItemsHeader",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionAdjustment_StoreData_StoreDataId",
                table: "AdditionAdjustment",
                column: "StoreDataId",
                principalTable: "StoreData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationMenu_BranchesData_BranchesDataId",
                table: "ApplicationMenu",
                column: "BranchesDataId",
                principalTable: "BranchesData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BankAtm_BranchesData_BranchesDataId",
                table: "BankAtm",
                column: "BranchesDataId",
                principalTable: "BranchesData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchesData_EmployeeData_BranchManagerId",
                table: "BranchesData",
                column: "BranchManagerId",
                principalTable: "EmployeeData",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchesData_CompanyData_CompanyDataId",
                table: "BranchesData");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpGroupWork_BranchesData_BranchesDataId",
                table: "EmpGroupWork");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_BranchesData_BranchesDataId",
                table: "EmployeeData");

            migrationBuilder.DropTable(
                name: "AccountFiscalYear");

            migrationBuilder.DropTable(
                name: "AccountFixedDetail");

            migrationBuilder.DropTable(
                name: "AccountsBalanceFooter");

            migrationBuilder.DropTable(
                name: "ActivityLogs");

            migrationBuilder.DropTable(
                name: "APIURLTaxServer");

            migrationBuilder.DropTable(
                name: "ApplicationMessage");

            migrationBuilder.DropTable(
                name: "ApplicationSetting");

            migrationBuilder.DropTable(
                name: "AspPermission");

            migrationBuilder.DropTable(
                name: "AttatchmentFile");

            migrationBuilder.DropTable(
                name: "BankContract");

            migrationBuilder.DropTable(
                name: "BranchesList");

            migrationBuilder.DropTable(
                name: "CheckDetail");

            migrationBuilder.DropTable(
                name: "ClientAccessToken");

            migrationBuilder.DropTable(
                name: "ConContractorExtractDetail");

            migrationBuilder.DropTable(
                name: "CostGeneralAccountFooter");

            migrationBuilder.DropTable(
                name: "CostJournalFooter");

            migrationBuilder.DropTable(
                name: "CrmTask");

            migrationBuilder.DropTable(
                name: "DatabaseDescription");

            migrationBuilder.DropTable(
                name: "EduStudentCourse");

            migrationBuilder.DropTable(
                name: "EduStudentPayment");

            migrationBuilder.DropTable(
                name: "EduStudentQuestion");

            migrationBuilder.DropTable(
                name: "EmpAccept");

            migrationBuilder.DropTable(
                name: "EmpAttend");

            migrationBuilder.DropTable(
                name: "EmpContractFooter");

            migrationBuilder.DropTable(
                name: "EmpLevel");

            migrationBuilder.DropTable(
                name: "EmpLoans");

            migrationBuilder.DropTable(
                name: "EmployeeCourse");

            migrationBuilder.DropTable(
                name: "EmployeeJob");

            migrationBuilder.DropTable(
                name: "EmployeeSkills");

            migrationBuilder.DropTable(
                name: "FinalData");

            migrationBuilder.DropTable(
                name: "FinalDataFixed");

            migrationBuilder.DropTable(
                name: "FinancialCenter");

            migrationBuilder.DropTable(
                name: "GeneralAccountFooter");

            migrationBuilder.DropTable(
                name: "GeneralAccountType");

            migrationBuilder.DropTable(
                name: "HomePage");

            migrationBuilder.DropTable(
                name: "HotelPayment");

            migrationBuilder.DropTable(
                name: "HotelReservationDetail");

            migrationBuilder.DropTable(
                name: "InstallmentFooter");

            migrationBuilder.DropTable(
                name: "InventoryOrderFooter");

            migrationBuilder.DropTable(
                name: "InvoicingResult");

            migrationBuilder.DropTable(
                name: "ItemsColor");

            migrationBuilder.DropTable(
                name: "ItemSize");

            migrationBuilder.DropTable(
                name: "ItemsPricePurchase");

            migrationBuilder.DropTable(
                name: "ItemsPriceSale");

            migrationBuilder.DropTable(
                name: "ItemsProduction");

            migrationBuilder.DropTable(
                name: "ItemsStock");

            migrationBuilder.DropTable(
                name: "JournalEntriesTypes");

            migrationBuilder.DropTable(
                name: "JournalFooter");

            migrationBuilder.DropTable(
                name: "LockersData");

            migrationBuilder.DropTable(
                name: "MedCustomerDetail");

            migrationBuilder.DropTable(
                name: "MedCustomerMedicalService");

            migrationBuilder.DropTable(
                name: "MedCustomerSurgicalService");

            migrationBuilder.DropTable(
                name: "MedPartnerData");

            migrationBuilder.DropTable(
                name: "MoneyPayment");

            migrationBuilder.DropTable(
                name: "MoneyReceive");

            migrationBuilder.DropTable(
                name: "Month");

            migrationBuilder.DropTable(
                name: "PItemsStock");

            migrationBuilder.DropTable(
                name: "PosMachine");

            migrationBuilder.DropTable(
                name: "PosPaymentDaily");

            migrationBuilder.DropTable(
                name: "PosSalesDiscount");

            migrationBuilder.DropTable(
                name: "PosSession");

            migrationBuilder.DropTable(
                name: "PPurchasesInvoiceFooter");

            migrationBuilder.DropTable(
                name: "ProgramOption");

            migrationBuilder.DropTable(
                name: "PurchasesInvoiceDiscount");

            migrationBuilder.DropTable(
                name: "PurchasesOrderFooter");

            migrationBuilder.DropTable(
                name: "PurchasesTaxInvoice");

            migrationBuilder.DropTable(
                name: "ReportsName");

            migrationBuilder.DropTable(
                name: "RequestReservationFooter");

            migrationBuilder.DropTable(
                name: "ReservationDebit");

            migrationBuilder.DropTable(
                name: "RntContractsData");

            migrationBuilder.DropTable(
                name: "RntCustomerPercentData");

            migrationBuilder.DropTable(
                name: "RntExpense");

            migrationBuilder.DropTable(
                name: "RntReceiptsData");

            migrationBuilder.DropTable(
                name: "SalesInvoiceDelivery");

            migrationBuilder.DropTable(
                name: "SalesInvoiceDiscount");

            migrationBuilder.DropTable(
                name: "SalesInvoicePayment");

            migrationBuilder.DropTable(
                name: "SalesTaxInvoiceFooter");

            migrationBuilder.DropTable(
                name: "SalesTaxInvoiceHeader");

            migrationBuilder.DropTable(
                name: "ServerType");

            migrationBuilder.DropTable(
                name: "StatusData");

            migrationBuilder.DropTable(
                name: "TenantUser");

            migrationBuilder.DropTable(
                name: "UsePermissions");

            migrationBuilder.DropTable(
                name: "WhatsAppCompanyData");

            migrationBuilder.DropTable(
                name: "WhatsAppResult");

            migrationBuilder.DropTable(
                name: "WhatsAppUrl");

            migrationBuilder.DropTable(
                name: "WorkPlanComment");

            migrationBuilder.DropTable(
                name: "WorkPlanDetail");

            migrationBuilder.DropTable(
                name: "AccountsBalanceHeader");

            migrationBuilder.DropTable(
                name: "InventoryValuation");

            migrationBuilder.DropTable(
                name: "AttachmentFilesType");

            migrationBuilder.DropTable(
                name: "CheckStatus");

            migrationBuilder.DropTable(
                name: "CheckType");

            migrationBuilder.DropTable(
                name: "ClientDataToken");

            migrationBuilder.DropTable(
                name: "ConContractorExtractMaster");

            migrationBuilder.DropTable(
                name: "ConProjectItem");

            migrationBuilder.DropTable(
                name: "CostGeneralAccountHeader");

            migrationBuilder.DropTable(
                name: "CostJournalHeader");

            migrationBuilder.DropTable(
                name: "CrmOpportunity");

            migrationBuilder.DropTable(
                name: "CrmTaskType");

            migrationBuilder.DropTable(
                name: "CrmTaskstatus");

            migrationBuilder.DropTable(
                name: "EduQuestionDetail");

            migrationBuilder.DropTable(
                name: "EduStudentData");

            migrationBuilder.DropTable(
                name: "EmpAcceptType");

            migrationBuilder.DropTable(
                name: "EmpAttendType");

            migrationBuilder.DropTable(
                name: "EmpDayWeek");

            migrationBuilder.DropTable(
                name: "EmpContractHeader");

            migrationBuilder.DropTable(
                name: "EmpElementData");

            migrationBuilder.DropTable(
                name: "EmpLevelType");

            migrationBuilder.DropTable(
                name: "EmpLoansType");

            migrationBuilder.DropTable(
                name: "GeneralAccountHeader");

            migrationBuilder.DropTable(
                name: "HotelReservationMaster");

            migrationBuilder.DropTable(
                name: "HotelService");

            migrationBuilder.DropTable(
                name: "InstallmentHeader");

            migrationBuilder.DropTable(
                name: "ColorType");

            migrationBuilder.DropTable(
                name: "SizeType");

            migrationBuilder.DropTable(
                name: "AdditionAdjustment");

            migrationBuilder.DropTable(
                name: "ItemsBalanceFooter");

            migrationBuilder.DropTable(
                name: "RequestReceiptFooter");

            migrationBuilder.DropTable(
                name: "SettlementDiscount");

            migrationBuilder.DropTable(
                name: "TransformationsDetail");

            migrationBuilder.DropTable(
                name: "JournalHeader");

            migrationBuilder.DropTable(
                name: "MedAnalysisName");

            migrationBuilder.DropTable(
                name: "MedRaysName");

            migrationBuilder.DropTable(
                name: "MedMedicalService");

            migrationBuilder.DropTable(
                name: "MedSurgicalService");

            migrationBuilder.DropTable(
                name: "PAdditionAdjustment");

            migrationBuilder.DropTable(
                name: "PInventoryOrderFooter");

            migrationBuilder.DropTable(
                name: "PItemsBalanceFooter");

            migrationBuilder.DropTable(
                name: "PRequestReceiptFooter");

            migrationBuilder.DropTable(
                name: "PRequestReservationFooter");

            migrationBuilder.DropTable(
                name: "PReturnPurchasesFooter");

            migrationBuilder.DropTable(
                name: "PReturnReservationFooter");

            migrationBuilder.DropTable(
                name: "PSettlementDiscount");

            migrationBuilder.DropTable(
                name: "PosSalesDetail");

            migrationBuilder.DropTable(
                name: "PurchasesOrderHeader");

            migrationBuilder.DropTable(
                name: "PurchasesInvoiceFooter");

            migrationBuilder.DropTable(
                name: "ReturnPurchasesFooter");

            migrationBuilder.DropTable(
                name: "CostCenter");

            migrationBuilder.DropTable(
                name: "ReservationStatus");

            migrationBuilder.DropTable(
                name: "RntFloor");

            migrationBuilder.DropTable(
                name: "RntCustomerPercentHeader");

            migrationBuilder.DropTable(
                name: "RntExpenseType");

            migrationBuilder.DropTable(
                name: "RntReceiptsHeader");

            migrationBuilder.DropTable(
                name: "DeliveryModes");

            migrationBuilder.DropTable(
                name: "DiscountType");

            migrationBuilder.DropTable(
                name: "ReturnSalesFooter");

            migrationBuilder.DropTable(
                name: "SalesInvoiceFooter");

            migrationBuilder.DropTable(
                name: "TaxableType");

            migrationBuilder.DropTable(
                name: "Tenant");

            migrationBuilder.DropTable(
                name: "ApplicationMenu");

            migrationBuilder.DropTable(
                name: "WhatsAppMessageData");

            migrationBuilder.DropTable(
                name: "WorkPlanFooter");

            migrationBuilder.DropTable(
                name: "ConContractorData");

            migrationBuilder.DropTable(
                name: "ConProjectsData");

            migrationBuilder.DropTable(
                name: "CrmContact");

            migrationBuilder.DropTable(
                name: "CrmOpportunityStatus");

            migrationBuilder.DropTable(
                name: "EduQuestionsMaster");

            migrationBuilder.DropTable(
                name: "EmpContractType");

            migrationBuilder.DropTable(
                name: "EmpElementNature");

            migrationBuilder.DropTable(
                name: "EmpElementType");

            migrationBuilder.DropTable(
                name: "HotelRoomData");

            migrationBuilder.DropTable(
                name: "ItemsBalanceHeader");

            migrationBuilder.DropTable(
                name: "TransformationsMaster");

            migrationBuilder.DropTable(
                name: "PItemsBalanceHeader");

            migrationBuilder.DropTable(
                name: "PRequestReservationHeader");

            migrationBuilder.DropTable(
                name: "PReturnPurchasesHeader");

            migrationBuilder.DropTable(
                name: "PItemsHeader");

            migrationBuilder.DropTable(
                name: "PReturnReservationHeader");

            migrationBuilder.DropTable(
                name: "PosSale");

            migrationBuilder.DropTable(
                name: "ReturnPurchasesHeader");

            migrationBuilder.DropTable(
                name: "RntContractsHeader");

            migrationBuilder.DropTable(
                name: "ReturnSalesHeader");

            migrationBuilder.DropTable(
                name: "ItemsHeader");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "BankAtm");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "WorkPlanHeader");

            migrationBuilder.DropTable(
                name: "EduAcademyCourse");

            migrationBuilder.DropTable(
                name: "EduQuestionType");

            migrationBuilder.DropTable(
                name: "BalanceName");

            migrationBuilder.DropTable(
                name: "PPurchasesInvoiceHeader");

            migrationBuilder.DropTable(
                name: "PItemsGroup");

            migrationBuilder.DropTable(
                name: "PurchasesInvoiceHeader");

            migrationBuilder.DropTable(
                name: "RntActivity");

            migrationBuilder.DropTable(
                name: "SalesInvoiceHeader");

            migrationBuilder.DropTable(
                name: "ItemsCodeType");

            migrationBuilder.DropTable(
                name: "ItemsGroup");

            migrationBuilder.DropTable(
                name: "ItemsType");

            migrationBuilder.DropTable(
                name: "UnitType");

            migrationBuilder.DropTable(
                name: "BankCode");

            migrationBuilder.DropTable(
                name: "PRequestReceiptHeader");

            migrationBuilder.DropTable(
                name: "RequestReceiptHeader");

            migrationBuilder.DropTable(
                name: "SupplierData");

            migrationBuilder.DropTable(
                name: "CustomerData");

            migrationBuilder.DropTable(
                name: "DocumentsMode");

            migrationBuilder.DropTable(
                name: "PriceType");

            migrationBuilder.DropTable(
                name: "RequestReservationHeader");

            migrationBuilder.DropTable(
                name: "PInventoryOrderHeader");

            migrationBuilder.DropTable(
                name: "InventoryOrderHeader");

            migrationBuilder.DropTable(
                name: "SupplierGroup");

            migrationBuilder.DropTable(
                name: "CustomerCategories");

            migrationBuilder.DropTable(
                name: "CustomerModes");

            migrationBuilder.DropTable(
                name: "DelegateData");

            migrationBuilder.DropTable(
                name: "StoreData");

            migrationBuilder.DropTable(
                name: "AccountName");

            migrationBuilder.DropTable(
                name: "AccountFication");

            migrationBuilder.DropTable(
                name: "AccountMenu");

            migrationBuilder.DropTable(
                name: "AccountNature");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "CurrencyData");

            migrationBuilder.DropTable(
                name: "CompanyData");

            migrationBuilder.DropTable(
                name: "ActivityCode");

            migrationBuilder.DropTable(
                name: "BranchesData");

            migrationBuilder.DropTable(
                name: "EmployeeData");

            migrationBuilder.DropTable(
                name: "CityCode");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "EducationData");

            migrationBuilder.DropTable(
                name: "EducationStimate");

            migrationBuilder.DropTable(
                name: "EmpGroupWork");

            migrationBuilder.DropTable(
                name: "GenderData");

            migrationBuilder.DropTable(
                name: "JobData");

            migrationBuilder.DropTable(
                name: "PaymentMode");

            migrationBuilder.DropTable(
                name: "RecruitmentData");

            migrationBuilder.DropTable(
                name: "SocialData");

            migrationBuilder.DropTable(
                name: "UniversityData");

            migrationBuilder.DropTable(
                name: "GovernorateCode");

            migrationBuilder.DropTable(
                name: "CountryCode");
        }
    }
}
