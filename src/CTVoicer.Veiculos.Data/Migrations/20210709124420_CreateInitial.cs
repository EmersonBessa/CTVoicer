using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CTVoicer.Veiculos.Data.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoVeiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", nullable: false),
                    QuantidadePassageiros = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVeiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Chassi = table.Column<string>(type: "text", nullable: false),
                    TipoVeiculoId = table.Column<Guid>(nullable: false),
                    CorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_Cor_CorId",
                        column: x => x.CorId,
                        principalTable: "Cor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculo_TipoVeiculo_TipoVeiculoId",
                        column: x => x.TipoVeiculoId,
                        principalTable: "TipoVeiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_CorId",
                table: "Veiculo",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_TipoVeiculoId",
                table: "Veiculo",
                column: "TipoVeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Cor");

            migrationBuilder.DropTable(
                name: "TipoVeiculo");
        }
    }
}
