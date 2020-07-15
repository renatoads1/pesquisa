using Microsoft.EntityFrameworkCore.Migrations;

namespace pesquisa.Migrations
{
    public partial class relacionamento2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PerguntaId",
                table: "Resposta",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PerguntaId",
                table: "Resposta");

            migrationBuilder.AddColumn<int>(
                name: "RespostaId",
                table: "Pergunta",
                type: "int",
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
    }
}
