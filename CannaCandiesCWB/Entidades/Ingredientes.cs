using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannaCandiesCWB.Entidades
{
    public class Ingredientes
    {
        public int IdIngrediente {  get; set; }
        public string NomeIngrediente {  get; set; }
        public double QuantidadeEstoque { get; set; }
        public string UnidadeEstoque { get; set; }
        public double ValorUnidade { get; set; }
        public double QuantidadeCompra { get; set; }
        public string UnidadeCompra { get; set; }
        public double ValorCompra { get; set;}
    }
}
