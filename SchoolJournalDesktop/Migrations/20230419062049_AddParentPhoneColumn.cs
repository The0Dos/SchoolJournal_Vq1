using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolJournalDesktop.Migrations
{
    /// <inheritdoc />
    public partial class AddParentPhoneColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParentTelephone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentTelephone",
                table: "Students");
        }
    }
}
