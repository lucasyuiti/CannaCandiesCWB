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

namespace CannaCandiesCWB.Paginas.Receitas
{
    public partial class ListaReceitas : Form
    {
        public readonly IServiceProvider _ServiceProvider;
        public ListaReceitas(/*IServiceProvider serviceProvider*/)
        {
            InitializeComponent();
            //_ServiceProvider = serviceProvider;
        }
    }
}
