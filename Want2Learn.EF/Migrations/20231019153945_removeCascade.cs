using Microsoft.EntityFrameworkCore.Migrations;

namespace Want2Learn.EF.Migrations
{
    public partial class removeCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Streets_Cities_CityId",
                table: "Streets");

            migrationBuilder.AddForeignKey(
                name: "FK_Streets_Cities_CityId",
                table: "Streets",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Streets_Cities_CityId",
                table: "Streets");

            migrationBuilder.AddForeignKey(
                name: "FK_Streets_Cities_CityId",
                table: "Streets",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
