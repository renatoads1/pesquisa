using pesquisa.Data;
using pesquisa.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace pesquisa.Services
{
    public class PerguntaServices
    {
        public readonly pesquisaContext _context;

        public PerguntaServices(pesquisaContext context)
        {
            _context = context;
        }
        public List<Pergunta> FindAll()
        {
            return _context.Pergunta.OrderBy(x => x.PerguntaCompleta).ToList();
        }
    }
}
