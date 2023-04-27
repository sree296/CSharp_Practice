using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessEntity.Migrations
{
    /// <inheritdoc />
    public partial class seven_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentContentMappingData",
                columns: table => new
                {
                    AssmtCaseStudyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssmtId = table.Column<int>(type: "int", nullable: false),
                    CaseStudyId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentContentMappingData", x => x.AssmtCaseStudyId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssessmentContentMappingData");
        }
    }
}
