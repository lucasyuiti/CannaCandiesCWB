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
        public int IdIngredienteAlterado { get; set; }
        public string NomeIngredienteAlterado {  get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Mudanca {  get; set; }
        public string IngredienteAtual { get; set; }
        public string IngredienteAntes { get; set; }
    }
}
