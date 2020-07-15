using Microsoft.EntityFrameworkCore.Migrations;

namespace pesquisa.Migrations
{
    public partial class relacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdResposta",
                table: "Pergunta");

            migrationBuilder.AddColumn<int>(
                name: "RespostaId",
                table: "Pergunta",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pergunta_RespostaId",
                table: "Pergunta",
                column: "RespostaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pergunta_Resposta_RespostaId",
                table: "Pergunta",
                column: "RespostaId",
                principalTable: "Resposta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pergunta_Resposta_RespostaId",
                table: "Pergunta");

            migrationBuilder.DropIndex(
                name: "IX_Pergunta_RespostaId",
                table: "Pergunta");

            migrationBuilder.DropColumn(
                name: "RespostaId",
                table: "Pergunta");

            migrationBuilder.AddColumn<int>(
                name: "IdResposta",
                table: "Pergunta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
