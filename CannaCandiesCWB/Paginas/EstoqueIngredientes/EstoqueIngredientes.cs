

using CannaCandiesCWB.Entidades;
using CannaCandiesCWB.Paginas.EstoqueIngredientes.EditarEstoque;
using CannaCandiesCWB.Services;

namespace CannaCandiesCWB.Paginas.EstoqueIngredientes
{
    public partial class EstoqueIngredientes : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public List<Ingredientes> Ingredientes;
        public Ingredientes IngredienteSelecionado;
        public Form FormEntrada;

        public ConexaoDB DbConn = new ConexaoDB();
        public bool conectado;
        public EstoqueIngredientes(/*IServiceProvider serviceProvider,*/ Form formEntrada)
        {
            InitializeComponent();
            FormEntrada = formEntrada;
            //_serviceProvider = serviceProvider;
        }

        private void EstoqueLoad(object sender, EventArgs e)
        {
            conectado = DbConn.ConnectToDatabase();
        }

        private void FechandoEstoque(object sender, FormClosingEventArgs e)
        {
            DbConn.Disconnect();
            conectado = false;
        }

        public void Adicionar()
        {
            var form = new AdicionarIngrediente();
        }

        public void Remover()
        {
            //DbConn
        }

        public void Editar()
        {
            var form = new EditarIngrediente(IngredienteSelecionado);
        }

        private void ShowForm(object? sender, FormClosedEventArgs e)
        {
            Show();
            FormEntrada.Show();
        }
    }
}
