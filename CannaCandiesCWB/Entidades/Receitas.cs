using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannaCandiesCWB.Entidades
{
    public class Receitas
    {
        public string NomeReceita {  get; set; }
        public List<Ingredientes> Ingredientes { get; set; }
        public double ValorReceita { get; set; }
    }
}
