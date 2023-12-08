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

namespace CannaCandiesCWB.Paginas.ListaReceitas
{
    public partial class ListaReceitas : Form
    {
        public Form FormEntrada;
        public ConexaoDB DbConn;
        public bool conectado;

        public List<Receitas> ListaReceitasDb;

        public ListaReceitas(/*IServiceProvider serviceProvider,*/ Form formEntrada, ConexaoDB dbConn)
        {
            InitializeComponent();
            DbConn = dbConn;
            FormEntrada = formEntrada;
        }
        private void OnLoad(object sender, EventArgs e)
        {
            PegarEstoqueDb();
        }

        public void PegarEstoqueDb()
        {
            ListaReceitasDb = DbConn.GetListaReceitas();
        }

        private void PesquisarReceita(object sender, EventArgs e)
        {

        }

        private void SalvarReceita(object sender, EventArgs e)
        {

        }

        private void AdicionarReceita(object sender, EventArgs e)
        {

        }

        private void DeletarReceita(object sender, EventArgs e)
        {
            
        }
    }
}
