using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGrades.Migrations
{
    public partial class PostNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "File Name",
                table: "Posts",
                newName: "Filename");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Posts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Filename",
                table: "Posts",
                newName: "File Name");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
