using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessEntity.Migrations
{
    /// <inheritdoc />
    public partial class six_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CaseStudyDetails",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isActive",
                table: "AssessmentUserMappingData",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CaseStudyDetails");

            migrationBuilder.AlterColumn<int>(
                name: "isActive",
                table: "AssessmentUserMappingData",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
