using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCareConnect.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjusteEndereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ENDERECO_PRESTADOR_TB_PRESTADOR_PrestadorId",
                table: "TB_ENDERECO_PRESTADOR");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ENDERECO_PRESTADOR_TB_PRESTADOR_PrestadorId",
                table: "TB_ENDERECO_PRESTADOR",
                column: "PrestadorId",
                principalTable: "TB_PRESTADOR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ENDERECO_PRESTADOR_TB_PRESTADOR_PrestadorId",
                table: "TB_ENDERECO_PRESTADOR");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ENDERECO_PRESTADOR_TB_PRESTADOR_PrestadorId",
                table: "TB_ENDERECO_PRESTADOR",
                column: "PrestadorId",
                principalTable: "TB_PRESTADOR",
                principalColumn: "Id");
        }
    }
}
