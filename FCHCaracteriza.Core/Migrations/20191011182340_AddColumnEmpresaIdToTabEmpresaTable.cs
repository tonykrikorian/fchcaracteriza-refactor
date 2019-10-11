using Microsoft.EntityFrameworkCore.Migrations;

namespace FCHCaracteriza.Core.Migrations
{
    public partial class AddColumnEmpresaIdToTabEmpresaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "TAB_EMPRESA",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "TAB_EMPRESA");
        }
    }
}
