using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQLSample.DataAccess.Migrations
{
    public partial class Changed_Authors_age_to_int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Authors",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Age",
                table: "Authors",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
