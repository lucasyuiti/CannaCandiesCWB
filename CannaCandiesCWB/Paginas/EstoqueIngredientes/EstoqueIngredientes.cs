

using CannaCandiesCWB.Entidades;
using CannaCandiesCWB.Paginas.EstoqueIngredientes.EditarEstoque;
using CannaCandiesCWB.Services;

namespace CannaCandiesCWB.Paginas.EstoqueIngredientes
{
    public partial class EstoqueIngredientes : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public List<Ingredientes> Ingredientes;
        public List<Ingredientes> IngredientesFiltrados;
        public Ingredientes IngredienteSelecionado = new Ingredientes();
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
            PegarEstoqueDb();
            filtrarIngredientes();
            PreencherListaEstoque();
        }

        public void PegarEstoqueDb()
        {
            Ingredientes = DbConn.PuxarIngredientesEstoque();
        }

        public void filtrarIngredientes()
        {
            IngredientesFiltrados = Ingredientes.Where(x => x.NomeIngrediente.ToUpper().Contains(txtBoxFiltroNome.Text.ToUpper())).ToList();
        }

        public void PreencherListaEstoque()
        {
            lvEstoque.Items.Clear();
            foreach (var ingrediente in IngredientesFiltrados)
            {
                var listItem = new ListViewItem(ingrediente.IdIngrediente.ToString());
                listItem.SubItems.Add(ingrediente.NomeIngrediente);
                listItem.SubItems.Add(ingrediente.QuantidadeEstoque.ToString());
                listItem.SubItems.Add(ingrediente.UnidadeEstoque);
                listItem.SubItems.Add(ingrediente.ValorUnidade.ToString());
                listItem.SubItems.Add(ingrediente.QuantidadeCompra.ToString());
                listItem.SubItems.Add(ingrediente.UnidadeCompra);
                listItem.SubItems.Add(ingrediente.ValorCompra.ToString());

                lvEstoque.Items.Add(listItem);
            }
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

        private void ShowForm(object? sender, FormClosedEventArgs e)
        {
            Show();
            FormEntrada.Show();
        }

        private void CarregarIngredienteSelecionado(object sender, EventArgs e)
        {
            if (lvEstoque.SelectedItems.Count > 0)
            {
                var ingredienteSelecionado = lvEstoque.SelectedItems[0];

                if (ingredienteSelecionado != null)
                {
                    var ingrediente = Ingredientes.FirstOrDefault(x => x.IdIngrediente.ToString().ToUpper() == ingredienteSelecionado.Text);

                    if (ingrediente != null)
                    {
                        IngredienteSelecionado.IdIngrediente = ingrediente.IdIngrediente;
                        IngredienteSelecionado.NomeIngrediente = ingrediente.NomeIngrediente;
                        IngredienteSelecionado.QuantidadeEstoque = ingrediente.QuantidadeEstoque;
                        IngredienteSelecionado.UnidadeEstoque = ingrediente.UnidadeEstoque;
                        IngredienteSelecionado.ValorUnidade = ingrediente.ValorUnidade;
                        IngredienteSelecionado.QuantidadeCompra = ingrediente.QuantidadeCompra;
                        IngredienteSelecionado.UnidadeCompra = ingrediente.UnidadeCompra;
                        IngredienteSelecionado.ValorCompra = ingrediente.ValorCompra;

                        PreencherIngredienteSelecionado();
                    }
                }
            }
        }

        private void PreencherIngredienteSelecionado()
        {
            txtBoxIngredienteSelecionadoNome.Text = IngredienteSelecionado.NomeIngrediente;
            txtBoxIngredienteSelecionadoQuantidadeCompra.Text = IngredienteSelecionado.QuantidadeCompra.ToString();
            txtBoxIngredienteSelecionadoQuantidadeEstoque.Text = IngredienteSelecionado.QuantidadeEstoque.ToString();
            txtBoxIngredienteSelecionadoUnidadeCompra.Text = IngredienteSelecionado.UnidadeCompra;
            txtBoxIngredienteSelecionadoUnidadeEstoque.Text = IngredienteSelecionado.UnidadeEstoque;
            txtBoxIngredienteSelecionadoValorCompra.Text = IngredienteSelecionado.ValorCompra.ToString();
            txtBoxIngredienteSelecionadoValorUnidade.Text = IngredienteSelecionado.ValorUnidade.ToString();
        }


        private void DeletarIngrediente(object sender, EventArgs e)
        {
            DbConn.RemoverIngredienteEstoque(IngredienteSelecionado.IdIngrediente);
            PegarEstoqueDb();
            filtrarIngredientes();
            PreencherListaEstoque();
        }

        private void PesquisarIngrediente(object sender, EventArgs e)
        {
            filtrarIngredientes();
            PreencherListaEstoque();
        }

        private void AdicionarIngrediente(object sender, EventArgs e)
        {
            IngredienteSelecionado.IdIngrediente = Ingredientes.Count + 1;
            SalvarValorIngrediente();
            DbConn.AdicionarIngrediente(IngredienteSelecionado);

            PegarEstoqueDb();
            filtrarIngredientes();
            PreencherListaEstoque();
        }

        private void AtualizarIngrediente(object sender, EventArgs e)
        {
            SalvarValorIngrediente();
            DbConn.AtualizarIngrediente(IngredienteSelecionado);

            PegarEstoqueDb();
            filtrarIngredientes();
            PreencherListaEstoque();
        }

        private void SalvarValorIngrediente()
        {
            IngredienteSelecionado.NomeIngrediente = txtBoxIngredienteSelecionadoNome.Text;
            IngredienteSelecionado.ValorCompra = decimal.Parse(txtBoxIngredienteSelecionadoValorCompra.Text);
            IngredienteSelecionado.ValorUnidade = decimal.Parse(txtBoxIngredienteSelecionadoValorUnidade.Text);
            IngredienteSelecionado.UnidadeCompra = txtBoxIngredienteSelecionadoUnidadeCompra.Text;
            IngredienteSelecionado.UnidadeEstoque = txtBoxIngredienteSelecionadoUnidadeEstoque.Text;
            IngredienteSelecionado.QuantidadeCompra = decimal.Parse(txtBoxIngredienteSelecionadoQuantidadeCompra.Text);
            IngredienteSelecionado.QuantidadeEstoque = decimal.Parse(txtBoxIngredienteSelecionadoQuantidadeEstoque.Text);
        }

        private void CalcularValorUnidade()
        {
            txtBoxIngredienteSelecionadoValorUnidade.Text = (decimal.Parse(txtBoxIngredienteSelecionadoValorCompra.Text) / decimal.Parse(txtBoxIngredienteSelecionadoQuantidadeCompra.Text)).ToString();
        }

        private void PreencherValorCompra(object sender, EventArgs e)
        {
            CalcularValorUnidade();
        }
    }
}
