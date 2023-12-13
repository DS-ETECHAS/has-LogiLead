using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogiLead.api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSaltMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "UserDatas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "UserDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
