using CannaCandiesCWB.Entidades;
using CannaCandiesCWB.Services;
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

        public Form FormEntrada;

        public ConexaoDB DbConn;
        public bool conectado;
        public ListaReceitas(/*IServiceProvider serviceProvider,*/Form formEntrada, ConexaoDB dbConn)
        {
            InitializeComponent();
            FormEntrada = formEntrada;
            DbConn = dbConn;
            //_ServiceProvider = serviceProvider;
        }
    }
}
