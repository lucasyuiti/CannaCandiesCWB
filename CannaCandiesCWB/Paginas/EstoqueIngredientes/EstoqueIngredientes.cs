

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

        public ConexaoDB DbConn;
        public bool conectado;
        public EstoqueIngredientes(/*IServiceProvider serviceProvider,*/ Form formEntrada, ConexaoDB dbConn)
        {
            InitializeComponent();
            FormEntrada = formEntrada;
            DbConn = dbConn;
            //_serviceProvider = serviceProvider;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            CheckarDBConection();
        }

        public void CheckarDBConection()
        {
            conectado = DbConn.CheckDBConnection();

            if (conectado)
            {
                lbConectado.Text = "Conectado ao estoque";
                lbConectado.ForeColor = Color.Green;
            }

            else
            {
                lbConectado.Text = "Tentando conectar ao estoque...";
                lbConectado.ForeColor = Color.Red;

                DbConn.ConnectToDatabase();
                CheckarDBConection();
            }


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
