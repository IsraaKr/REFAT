using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REFAT.Data.Migrations
{
    public partial class Add_all : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    JobTittle = table.Column<string>(nullable: true),
                    EmpSate = table.Column<string>(nullable: true),
                    LastPromotionDate = table.Column<DateTime>(nullable: false),
                    CurrentDegree = table.Column<int>(nullable: false),
                    CurrentStage = table.Column<int>(nullable: false),
                    CurrentSalary = table.Column<float>(nullable: false),
                    CurrentDate = table.Column<DateTime>(nullable: false),
                    NextDegree = table.Column<int>(nullable: false),
                    NextStage = table.Column<int>(nullable: false),
                    NextSalary = table.Column<float>(nullable: false),
                    NextDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaryRate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<int>(nullable: false),
                    Salary = table.Column<float>(nullable: false),
                    BonusYearRate = table.Column<float>(nullable: false),
                    PromotionYear = table.Column<int>(nullable: false),
                    UsersId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryRate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    DeviceName = table.Column<string>(nullable: true),
                    MachinId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Desiccation = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UsersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    IsSecondaryUser = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<bool>(nullable: false),
                    UsersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UsersId",
                table: "Roles",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SalaryRate");

            migrationBuilder.DropTable(
                name: "SystemRecords");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
