using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannaCandiesCWB.Entidades
{
    public class Receitas
    {
        public int IdReceitas {  get; set; }
        public string NomeReceita {  get; set; }
        public decimal ValorReceita { get; set; }
        public string IngredientesId { get; set; }
    }
}
