using Microsoft.EntityFrameworkCore.Migrations;

namespace AydinHotel.DataAccess.Migrations
{
    public partial class mig_add_message_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageCategoryId",
                table: "Contacts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MessageCategories",
                columns: table => new
                {
                    MessageCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageCategories", x => x.MessageCategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MessageCategoryId",
                table: "Contacts",
                column: "MessageCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryId",
                table: "Contacts",
                column: "MessageCategoryId",
                principalTable: "MessageCategories",
                principalColumn: "MessageCategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "MessageCategories");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_MessageCategoryId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "MessageCategoryId",
                table: "Contacts");
        }
    }
}
