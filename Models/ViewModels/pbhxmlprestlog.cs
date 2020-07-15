using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pesquisa.Models.ViewModels
{
    public class pbhxmlprestlog
    {
        public int id { get; set; }
        public string empresa { get; set; }
        public string cnpj { get; set; }
        public string mes_de_vigencia { get; set; }
        public string sucesso { get; set; }
        public string descricao { get; set; }
        public string quantidade_de_nfs_baixadas { get; set; }
        public string quantidade_de_nfs_processadas { get; set; }
        public string tempo_execucao { get; set; }

        public pbhxmlprestlog()
        {
        }

        public pbhxmlprestlog(int id, string empresa, string cnpj, string mes_de_vigencia, string sucesso, string descricao, string quantidade_de_nfs_baixadas, string quantidade_de_nfs_processadas, string tempo_execucao)
        {
            this.id = id;
            this.empresa = empresa;
            this.cnpj = cnpj;
            this.mes_de_vigencia = mes_de_vigencia;
            this.sucesso = sucesso;
            this.descricao = descricao;
            this.quantidade_de_nfs_baixadas = quantidade_de_nfs_baixadas;
            this.quantidade_de_nfs_processadas = quantidade_de_nfs_processadas;
            this.tempo_execucao = tempo_execucao;
        }
    }
}


      
      
      
      
      
      
      
