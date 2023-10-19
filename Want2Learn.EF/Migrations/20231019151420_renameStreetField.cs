using Microsoft.EntityFrameworkCore.Migrations;

namespace Want2Learn.EF.Migrations
{
    public partial class renameStreetField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetId",
                table: "Streets",
                newName: "StreetNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetNumber",
                table: "Streets",
                newName: "StreetId");
        }
    }
}
