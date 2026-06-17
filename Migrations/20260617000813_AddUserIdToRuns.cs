using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace running_data_app.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToRuns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Runs",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Runs");
        }
    }
}
