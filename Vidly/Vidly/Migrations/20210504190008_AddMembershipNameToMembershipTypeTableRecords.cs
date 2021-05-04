using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class AddMembershipNameToMembershipTypeTableRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MembershipType",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.Sql("UPDATE MembershipType SET Name = 'None' WHERE Id = 1;");
            migrationBuilder.Sql("UPDATE MembershipType SET Name = 'Monthly' WHERE Id = 2;") ;
            migrationBuilder.Sql("UPDATE MembershipType SET Name = 'Quarterly' WHERE Id = 3;");
            migrationBuilder.Sql("UPDATE MembershipType SET Name = 'Yearly' WHERE Id = 4;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MembershipType");
        }
    }
}
