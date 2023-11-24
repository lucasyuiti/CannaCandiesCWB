using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannaCandiesCWB.Entidades
{
    public class ReceitaIngredientes
    {
        public int Id { get; set; }
        public int[] IdIngredientes { get; set; }
        public int IdReceita { get; set; }
    }
}
