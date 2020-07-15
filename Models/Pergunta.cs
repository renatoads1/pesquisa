using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pesquisa.Models
{
    public class Pergunta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string PerguntaSimpl { get; set; }
        public string PerguntaCompleta { get; set; }

        public Pergunta()
        {
        }
        public Pergunta(int id, string perguntaSimpl, string perguntaCompleta)
        {
            Id = id;
            PerguntaSimpl = perguntaSimpl;
            PerguntaCompleta = perguntaCompleta;
        }
    }
}
