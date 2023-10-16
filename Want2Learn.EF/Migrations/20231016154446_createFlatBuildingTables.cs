using Microsoft.EntityFrameworkCore.Migrations;

namespace Want2Learn.EF.Migrations
{
    public partial class createFlatBuildingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Street_Cities_CityId",
                table: "Street");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Street",
                table: "Street");

            migrationBuilder.RenameTable(
                name: "Street",
                newName: "Streets");

            migrationBuilder.RenameIndex(
                name: "IX_Street_CityId",
                table: "Streets",
                newName: "IX_Streets_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Streets",
                table: "Streets",
                column: "StreetId");

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    AdditionalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingId);
                    table.ForeignKey(
                        name: "FK_Buildings_Streets_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Streets",
                        principalColumn: "StreetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flats",
                columns: table => new
                {
                    FlatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    AdditionalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flats", x => x.FlatId);
                    table.ForeignKey(
                        name: "FK_Flats_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_StreetId",
                table: "Buildings",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_BuildingId",
                table: "Flats",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Streets_Cities_CityId",
                table: "Streets",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Streets_Cities_CityId",
                table: "Streets");

            migrationBuilder.DropTable(
                name: "Flats");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Streets",
                table: "Streets");

            migrationBuilder.RenameTable(
                name: "Streets",
                newName: "Street");

            migrationBuilder.RenameIndex(
                name: "IX_Streets_CityId",
                table: "Street",
                newName: "IX_Street_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Street",
                table: "Street",
                column: "StreetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Street_Cities_CityId",
                table: "Street",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
