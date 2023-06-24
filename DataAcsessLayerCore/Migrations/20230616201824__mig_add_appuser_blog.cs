using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcsessLayerCore.Migrations
{
    public partial class _mig_add_appuser_blog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverID",
                table: "MessageTwos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "MessageTwos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MessageTwos_ReceiverID",
                table: "MessageTwos",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_MessageTwos_SenderId",
                table: "MessageTwos",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AppUserId",
                table: "Blogs",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_AppUserId",
                table: "Blogs",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageTwos_AspNetUsers_ReceiverID",
                table: "MessageTwos",
                column: "ReceiverID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageTwos_AspNetUsers_SenderId",
                table: "MessageTwos",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_AppUserId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageTwos_AspNetUsers_ReceiverID",
                table: "MessageTwos");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageTwos_AspNetUsers_SenderId",
                table: "MessageTwos");

            migrationBuilder.DropIndex(
                name: "IX_MessageTwos_ReceiverID",
                table: "MessageTwos");

            migrationBuilder.DropIndex(
                name: "IX_MessageTwos_SenderId",
                table: "MessageTwos");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AppUserId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "ReceiverID",
                table: "MessageTwos");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "MessageTwos");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Blogs");
        }
    }
}
