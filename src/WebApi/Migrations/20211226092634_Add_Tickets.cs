using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class Add_Tickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UpdatedById",
                table: "Projects");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Projects",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                type: "date",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProjectId = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "date", nullable: true),
                    ReceivedOn = table.Column<DateTimeOffset>(type: "datetimeoffset(3)", nullable: true),
                    ReceivedOnUtc = table.Column<DateTime>(type: "datetime2(3)", nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset(3)", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2(3)", nullable: true),
                    UpdatedById = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Code", "CreatedDate", "EndDate", "IsActive", "StartDate", "UpdatedById", "UpdatedOn", "UpdatedOnUtc" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), "PRJ001", new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2021, 12, 26, 11, 26, 34, 249, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2021, 12, 26, 9, 26, 34, 249, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProjectId",
                table: "Tickets",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UpdatedById",
                table: "Tickets",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UpdatedById",
                table: "Projects",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UpdatedById",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Projects");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UpdatedById",
                table: "Projects",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
