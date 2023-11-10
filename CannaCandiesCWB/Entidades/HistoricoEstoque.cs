using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannaCandiesCWB.Entidades
{
    public class HistoricoEstoque
    {
        public int IdHistorico { get; set; }
        public Ingredientes ingrediente {  get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Status {  get; set; }
        public double Quantidade { get; set; }
    }
}
