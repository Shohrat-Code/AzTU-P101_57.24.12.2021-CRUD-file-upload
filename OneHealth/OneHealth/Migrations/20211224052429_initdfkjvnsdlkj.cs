using Microsoft.EntityFrameworkCore.Migrations;

namespace OneHealth.Migrations
{
    public partial class initdfkjvnsdlkj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blogs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Blogs",
                type: "nText",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nText",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blogs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Blogs",
                type: "nText",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nText");
        }
    }
}
