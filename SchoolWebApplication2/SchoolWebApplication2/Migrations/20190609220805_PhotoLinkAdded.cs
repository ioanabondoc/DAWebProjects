using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolWebApplication2.Migrations
{
    public partial class PhotoLinkAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoLink",
                table: "Animal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoLink",
                table: "Animal");
        }
    }
}
