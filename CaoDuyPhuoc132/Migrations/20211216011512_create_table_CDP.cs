using Microsoft.EntityFrameworkCore.Migrations;

namespace CaoDuyPhuoc132.Migrations
{
    public partial class create_table_CDP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UniversityName",
                table: "UniversityCDP132",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CDP0132",
                columns: table => new
                {
                    CDPId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CDPName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CDPGender = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDP0132", x => x.CDPId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CDP0132");

            migrationBuilder.AlterColumn<string>(
                name: "UniversityName",
                table: "UniversityCDP132",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
