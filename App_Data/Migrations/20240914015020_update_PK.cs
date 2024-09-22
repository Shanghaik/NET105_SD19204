using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App_Data.Migrations
{
    public partial class update_PK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HDCTS",
                table: "HDCTS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HDCTS",
                table: "HDCTS",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HDCTS_IDSP",
                table: "HDCTS",
                column: "IDSP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HDCTS",
                table: "HDCTS");

            migrationBuilder.DropIndex(
                name: "IX_HDCTS_IDSP",
                table: "HDCTS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HDCTS",
                table: "HDCTS",
                columns: new[] { "IDSP", "IDHD" });
        }
    }
}
