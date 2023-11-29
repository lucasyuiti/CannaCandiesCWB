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
        public Form FormEntrada { get; set; }
        public ConexaoDB DBConn {  get; set; }
        public Entrada(/*IServiceProvider serviceProvider*/)
        {
            InitializeComponent();
            // _serviceProvider = serviceProvider;

        }

        private void BotaoReceitas_Click(object sender, EventArgs e)
        {
            var form = new ListaReceitas(/*_serviceProvider*/);
            form.Show();
            //HideForm();
        }

        private void BotaoEstoque_Click(object sender, EventArgs e)
        {
            var form = new EstoqueIngredientes(/*_serviceProvider,*/ this);
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
        }
    }
}