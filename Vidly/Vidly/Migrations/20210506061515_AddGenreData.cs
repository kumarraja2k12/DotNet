using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class AddGenreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Action');");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Thriller');");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Drama');");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Comedy');");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Crime');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Genre;");
        }
    }
}
