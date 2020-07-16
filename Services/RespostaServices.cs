using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pesquisa.Data;
using pesquisa.Models;

namespace pesquisa.Services
{
    public class RespostaServices
    {
        public readonly pesquisaContext _context;

        public RespostaServices(pesquisaContext context)
        {
            _context = context;
        }
        public List<Resposta> FindAll()
        {
            return _context.Resposta.ToList();
        }

        public void Insere(Resposta obj)
        {
//            obj.Pergunta = _context.Pergunta.First();
            _context.Add(obj);
            _context.SaveChanges();

        }
    }
}
