using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class dsj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LogoUrl",
                table: "AppSettings",
                newName: "Address");

            migrationBuilder.AddColumn<string>(
                name: "SocialMediaAccountsId",
                table: "AppSettings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SocialMediaAccounts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiktok = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaAccounts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppSettings_SocialMediaAccountsId",
                table: "AppSettings",
                column: "SocialMediaAccountsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSettings_SocialMediaAccounts_SocialMediaAccountsId",
                table: "AppSettings",
                column: "SocialMediaAccountsId",
                principalTable: "SocialMediaAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSettings_SocialMediaAccounts_SocialMediaAccountsId",
                table: "AppSettings");

            migrationBuilder.DropTable(
                name: "SocialMediaAccounts");

            migrationBuilder.DropIndex(
                name: "IX_AppSettings_SocialMediaAccountsId",
                table: "AppSettings");

            migrationBuilder.DropColumn(
                name: "SocialMediaAccountsId",
                table: "AppSettings");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AppSettings",
                newName: "LogoUrl");
        }
    }
}
