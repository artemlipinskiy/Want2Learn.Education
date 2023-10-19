using Microsoft.EntityFrameworkCore.Migrations;

namespace Want2Learn.EF.Migrations
{
    public partial class renameFlatTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlatOwner_Flats_FlatsFlatId",
                table: "FlatOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_Buildings_BuildingId",
                table: "Flats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flats",
                table: "Flats");

            migrationBuilder.RenameTable(
                name: "Flats",
                newName: "Apartment");

            migrationBuilder.RenameIndex(
                name: "IX_Flats_BuildingId",
                table: "Apartment",
                newName: "IX_Apartment_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment",
                column: "FlatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Buildings_BuildingId",
                table: "Apartment",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlatOwner_Apartment_FlatsFlatId",
                table: "FlatOwner",
                column: "FlatsFlatId",
                principalTable: "Apartment",
                principalColumn: "FlatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Buildings_BuildingId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_FlatOwner_Apartment_FlatsFlatId",
                table: "FlatOwner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment");

            migrationBuilder.RenameTable(
                name: "Apartment",
                newName: "Flats");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_BuildingId",
                table: "Flats",
                newName: "IX_Flats_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flats",
                table: "Flats",
                column: "FlatId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlatOwner_Flats_FlatsFlatId",
                table: "FlatOwner",
                column: "FlatsFlatId",
                principalTable: "Flats",
                principalColumn: "FlatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_Buildings_BuildingId",
                table: "Flats",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
