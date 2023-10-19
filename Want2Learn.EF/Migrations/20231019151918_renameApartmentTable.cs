using Microsoft.EntityFrameworkCore.Migrations;

namespace Want2Learn.EF.Migrations
{
    public partial class renameApartmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "Apartments");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_BuildingId",
                table: "Apartments",
                newName: "IX_Apartments_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartments",
                table: "Apartments",
                column: "FlatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Buildings_BuildingId",
                table: "Apartments",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlatOwner_Apartments_FlatsFlatId",
                table: "FlatOwner",
                column: "FlatsFlatId",
                principalTable: "Apartments",
                principalColumn: "FlatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Buildings_BuildingId",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_FlatOwner_Apartments_FlatsFlatId",
                table: "FlatOwner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartments",
                table: "Apartments");

            migrationBuilder.RenameTable(
                name: "Apartments",
                newName: "Apartment");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_BuildingId",
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
    }
}
