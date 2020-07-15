using System;
using System.Collections.Generic;
using System.Linq;


namespace pesquisa.Models.ViewModels
{
    public class RespostaFormViewModel
    {
        public Resposta resposta { get; set; }
        public ICollection<Pergunta> Perguntas { get; set; }
    }
}
