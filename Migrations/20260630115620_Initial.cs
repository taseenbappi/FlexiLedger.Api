using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexiLedger.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FlexiNumberId",
                table: "FlexiRecharges",
                newName: "PhoneNumberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumberId",
                table: "FlexiRecharges",
                newName: "FlexiNumberId");
        }
    }
}
