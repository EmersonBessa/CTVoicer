using Microsoft.EntityFrameworkCore.Migrations;

namespace CTVoicer.Veiculos.Data.Migrations
{
    public partial class CorrecaoCampoChassi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Chassi",
                table: "Veiculo",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Chassi",
                table: "Veiculo",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");
        }
    }
}
