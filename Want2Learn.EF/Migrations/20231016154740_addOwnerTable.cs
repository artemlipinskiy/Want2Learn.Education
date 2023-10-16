using Microsoft.EntityFrameworkCore.Migrations;

namespace Want2Learn.EF.Migrations
{
    public partial class addOwnerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerId);
                });

            migrationBuilder.CreateTable(
                name: "FlatOwner",
                columns: table => new
                {
                    FlatsFlatId = table.Column<int>(type: "int", nullable: false),
                    OwnersOwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatOwner", x => new { x.FlatsFlatId, x.OwnersOwnerId });
                    table.ForeignKey(
                        name: "FK_FlatOwner_Flats_FlatsFlatId",
                        column: x => x.FlatsFlatId,
                        principalTable: "Flats",
                        principalColumn: "FlatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlatOwner_Owners_OwnersOwnerId",
                        column: x => x.OwnersOwnerId,
                        principalTable: "Owners",
                        principalColumn: "OwnerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlatOwner_OwnersOwnerId",
                table: "FlatOwner",
                column: "OwnersOwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlatOwner");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
