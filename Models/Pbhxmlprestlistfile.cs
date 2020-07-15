using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pesquisa.Models
{
    public class Pbhxmlprestlistfile
    {
        public int id { get; set; }
        public string caminho { get; set; }
        public string cnpj { get; set; }
        public string status { get; set; }
        public DateTime datain { get; set; }
        public string  idFilial { get; set; }
        public string idEmpresa { get; set; }

        public Pbhxmlprestlistfile()
        {
        }

        public Pbhxmlprestlistfile(int id, string caminho, string cnpj, string status, DateTime datain, string idFilial, string idEmpresa)
        {
            this.id = id;
            this.caminho = caminho;
            this.cnpj = cnpj;
            this.status = status;
            this.datain = datain;
            this.idFilial = idFilial;
            this.idEmpresa = idEmpresa;
        }
    }
}
