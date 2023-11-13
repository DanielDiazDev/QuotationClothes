using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuotationClothes.Data.Migrations
{
    /// <inheritdoc />
    public partial class iquotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantityUnitsQuoted",
                table: "Quotations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Quotations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityUnitsQuoted",
                table: "Quotations");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Quotations");
        }
    }
}
