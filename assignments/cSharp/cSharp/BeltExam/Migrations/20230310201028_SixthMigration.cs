using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeltExam.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostId1",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostId1",
                table: "Posts",
                column: "PostId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Posts_PostId1",
                table: "Posts",
                column: "PostId1",
                principalTable: "Posts",
                principalColumn: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Posts_PostId1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostId1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostId1",
                table: "Posts");
        }
    }
}
