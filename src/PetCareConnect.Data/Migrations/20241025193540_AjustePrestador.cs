using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCareConnect.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjustePrestador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CATEGORIAPRODUTO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CATEGORIAPRODUTO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPRADOR",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Documento = table.Column<string>(type: "varchar(14)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_COMPRADOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRESTADOR",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoPrestador = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Documento = table.Column<string>(type: "varchar(14)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRESTADOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUTO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(1000)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(100)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_SERVICO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(1000)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_SERVICO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_ENDERECO_COMPRADOR",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompradorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Cep = table.Column<string>(type: "varchar(100)", nullable: true),
                    Estado = table.Column<string>(type: "varchar(100)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ENDERECO_COMPRADOR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_ENDERECO_COMPRADOR_TB_COMPRADOR_CompradorId",
                        column: x => x.CompradorId,
                        principalTable: "TB_COMPRADOR",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TB_PET",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Raca = table.Column<string>(type: "varchar(100)", nullable: false),
                    Porte = table.Column<string>(type: "varchar(10)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(100)", nullable: false),
                    CompradorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PET", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_PET_TB_COMPRADOR_CompradorId",
                        column: x => x.CompradorId,
                        principalTable: "TB_COMPRADOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ENDERECO_PRESTADOR",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrestadorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Cep = table.Column<string>(type: "varchar(100)", nullable: true),
                    Estado = table.Column<string>(type: "varchar(100)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ENDERECO_PRESTADOR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_ENDERECO_PRESTADOR_TB_PRESTADOR_PrestadorId",
                        column: x => x.PrestadorId,
                        principalTable: "TB_PRESTADOR",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ENDERECO_COMPRADOR_CompradorId",
                table: "TB_ENDERECO_COMPRADOR",
                column: "CompradorId",
                unique: true,
                filter: "[CompradorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ENDERECO_PRESTADOR_PrestadorId",
                table: "TB_ENDERECO_PRESTADOR",
                column: "PrestadorId",
                unique: true,
                filter: "[PrestadorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PET_CompradorId",
                table: "TB_PET",
                column: "CompradorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CATEGORIAPRODUTO");

            migrationBuilder.DropTable(
                name: "TB_ENDERECO_COMPRADOR");

            migrationBuilder.DropTable(
                name: "TB_ENDERECO_PRESTADOR");

            migrationBuilder.DropTable(
                name: "TB_PET");

            migrationBuilder.DropTable(
                name: "TB_PRODUTO");

            migrationBuilder.DropTable(
                name: "TB_SERVICO");

            migrationBuilder.DropTable(
                name: "TB_PRESTADOR");

            migrationBuilder.DropTable(
                name: "TB_COMPRADOR");
        }
    }
}
