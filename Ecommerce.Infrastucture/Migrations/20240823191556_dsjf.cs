using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class dsjf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiscountImageUrl",
                table: "Discount",
                newName: "DiscountImageName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiscountImageName",
                table: "Discount",
                newName: "DiscountImageUrl");
        }
    }
}
