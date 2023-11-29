using CannaCandiesCWB.Entidades;
using CannaCandiesCWB.Paginas.EstoqueIngredientes;
using CannaCandiesCWB.Paginas.Receitas;
using CannaCandiesCWB.Services;
using System.Net.Http.Headers;

namespace CannaCandiesCWB
{
    public partial class Entrada : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Form FormEntrada;
        public ConexaoDB DBConn = new ConexaoDB();
        public bool BancoConectado;
        public Entrada(/*IServiceProvider serviceProvider*/)
        {
            InitializeComponent();
            FormEntrada = this;
            // _serviceProvider = serviceProvider;

        }

        private void BotaoReceitas_Click(object sender, EventArgs e)
        {
            var form = new ListaReceitas(/*_serviceProvider,*/ this, DBConn);
            form.Show();
            //HideForm();
        }

        private void BotaoEstoque_Click(object sender, EventArgs e)
        {
            var form = new EstoqueIngredientes(/*_serviceProvider,*/ this, DBConn);
            form.FormClosed += ShowForm;
            form.Show();
        }

        private void ShowForm(object? sender, FormClosedEventArgs e)
        {
            Show();
            FormEntrada.Show();
        }

        private void OnLoad(object sender, EventArgs e)
        {
           DBConn.ConnectToDatabase();
        }
    }
}