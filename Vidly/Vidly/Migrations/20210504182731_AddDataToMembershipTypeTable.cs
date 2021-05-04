using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class AddDataToMembershipTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MembershipType (SubscriptionAmount, SubscriptionInMonths, Discount) VALUES ( 0, 0, 0);");
            migrationBuilder.Sql("INSERT INTO MembershipType (SubscriptionAmount, SubscriptionInMonths, Discount) VALUES (199, 1, 10);");
            migrationBuilder.Sql("INSERT INTO MembershipType (SubscriptionAmount, SubscriptionInMonths, Discount) VALUES (399, 3, 20);");
            migrationBuilder.Sql("INSERT INTO MembershipType (SubscriptionAmount, SubscriptionInMonths, Discount) VALUES (999, 12, 30);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("MembershipType", "Id", 4);
            migrationBuilder.DeleteData("MembershipType", "Id", 3);
            migrationBuilder.DeleteData("MembershipType", "Id", 2);
            migrationBuilder.DeleteData("MembershipType", "Id", 1);
        }
    }
}
