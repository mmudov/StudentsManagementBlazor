using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsManagementBlazor.Migrations
{
    /// <inheritdoc />
    public partial class BookIssuance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookIssuanceHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookIssuanceHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookIssuanceHistory_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookIssuanceHistory_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookIssuanceHistory_SystemCodeDetails_ClassId",
                        column: x => x.ClassId,
                        principalTable: "SystemCodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookIssuanceHistory_SystemCodeDetails_StatusId",
                        column: x => x.StatusId,
                        principalTable: "SystemCodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookIssuanceHistory_BookId",
                table: "BookIssuanceHistory",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookIssuanceHistory_ClassId",
                table: "BookIssuanceHistory",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BookIssuanceHistory_StatusId",
                table: "BookIssuanceHistory",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BookIssuanceHistory_StudentId",
                table: "BookIssuanceHistory",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookIssuanceHistory");
        }
    }
}
