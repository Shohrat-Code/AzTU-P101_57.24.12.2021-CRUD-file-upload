using Microsoft.EntityFrameworkCore.Migrations;

namespace OneHealth.Migrations
{
    public partial class settingUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutTitle",
                table: "Settings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutTitle",
                table: "Settings");
        }
    }
}
