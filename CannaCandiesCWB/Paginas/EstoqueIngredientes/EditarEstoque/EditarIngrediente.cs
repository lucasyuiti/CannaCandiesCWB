using CannaCandiesCWB.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CannaCandiesCWB.Paginas.EstoqueIngredientes.EditarEstoque
{
    public partial class EditarIngrediente : Form
    {
        Ingredientes Ingrediente;
        public EditarIngrediente(Ingredientes ingrediente)
        {
            InitializeComponent();
            Ingrediente = ingrediente;
        }


    }
}
