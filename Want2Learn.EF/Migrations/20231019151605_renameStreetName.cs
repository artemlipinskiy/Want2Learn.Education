using Microsoft.EntityFrameworkCore.Migrations;

namespace Want2Learn.EF.Migrations
{
    public partial class renameStreetName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Streets",
                newName: "StreetName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetName",
                table: "Streets",
                newName: "Name");
        }
    }
}
