using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexiLedger.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumberId",
                table: "FlexiRecharges",
                newName: "FlexiNumberId");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "FlexiNumbers",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_FlexiRecharges_FlexiNumberId",
                table: "FlexiRecharges",
                column: "FlexiNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlexiRecharges_FlexiNumbers_FlexiNumberId",
                table: "FlexiRecharges",
                column: "FlexiNumberId",
                principalTable: "FlexiNumbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlexiRecharges_FlexiNumbers_FlexiNumberId",
                table: "FlexiRecharges");

            migrationBuilder.DropIndex(
                name: "IX_FlexiRecharges_FlexiNumberId",
                table: "FlexiRecharges");

            migrationBuilder.RenameColumn(
                name: "FlexiNumberId",
                table: "FlexiRecharges",
                newName: "PhoneNumberId");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "FlexiNumbers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
