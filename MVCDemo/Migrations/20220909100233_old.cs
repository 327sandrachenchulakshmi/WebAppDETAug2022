using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDemo.Migrations
{
    public partial class old : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FriendId",
                table: "Friend",
                newName: "FriendID");

            migrationBuilder.RenameColumn(
                name: "Friendplace",
                table: "Friend",
                newName: "Place");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FriendID",
                table: "Friend",
                newName: "FriendId");

            migrationBuilder.RenameColumn(
                name: "Place",
                table: "Friend",
                newName: "Friendplace");
        }
    }
}
