using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessEntity.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserDetailData");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserDetailData");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "UserDetailData",
                newName: "RoleID");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserDetailData",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserDetailData",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "UserDetailData",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "UserDetailData",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "UserDetailData");

            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "UserDetailData");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "UserDetailData",
                newName: "Mobile");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserDetailData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserDetailData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserDetailData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserDetailData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
