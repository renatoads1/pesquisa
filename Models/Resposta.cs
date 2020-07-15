using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pesquisa.Models
{
    public class Resposta
    {

        [Key]
        public int Id { get; set; }
        public string RespostaSimpl { get; set; }
        public string RespostaCompleta { get; set; }
        public int PerguntaId { get; set; }
        public Resposta()
        {

        }

        public Resposta(int id,  string respostaSimpl, string respostaCompleta, int perguntaId)
        {
            Id = id;
            RespostaSimpl = respostaSimpl;
            RespostaCompleta = respostaCompleta;
            PerguntaId = perguntaId;
        }
    }
}
