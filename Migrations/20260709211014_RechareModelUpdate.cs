using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexiLedger.Api.Migrations
{
    /// <inheritdoc />
    public partial class RechareModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RechargeNumber",
                table: "FlexiRecharges",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RechargeNumber",
                table: "FlexiRecharges",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
