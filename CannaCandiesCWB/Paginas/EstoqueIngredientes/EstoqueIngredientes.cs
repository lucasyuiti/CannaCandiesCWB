

using CannaCandiesCWB.Entidades;
using CannaCandiesCWB.Paginas.EstoqueIngredientes;
using CannaCandiesCWB.Services;

namespace CannaCandiesCWB.Paginas.EstoqueIngredientes
{
    public partial class EstoqueIngredientes : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public List<Ingredientes> Ingredientes;
        public List<Ingredientes> IngredientesFiltrados;
        public Ingredientes IngredienteSelecionado = new Ingredientes();
        public HistoricoEstoque historicoEstoque = new HistoricoEstoque();
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
            Ingredientes = DbConn.GetIngredientesEstoque();
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

            PrepararHistorico(true, "Adicionando");
            SalvarValorIngrediente();
            PrepararHistorico(false, "Adicionando");

            DbConn.AdicionarIngredienteEstoque(IngredienteSelecionado);
            DbConn.AdicionarHistoricoEstoque(historicoEstoque);

            PegarEstoqueDb();
            filtrarIngredientes();
            PreencherListaEstoque();
        }

        private void AtualizarIngrediente(object sender, EventArgs e)
        {
            PrepararHistorico(true, "Atualizacao");
            SalvarValorIngrediente();
            PrepararHistorico(false, "Atualizacao");

            DbConn.AtualizarIngredienteEstoque(IngredienteSelecionado);
            DbConn.AdicionarHistoricoEstoque(historicoEstoque);

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
            var UnidadeCompra = txtBoxIngredienteSelecionadoUnidadeCompra.Text;
            var UnidadeEstoque = txtBoxIngredienteSelecionadoUnidadeEstoque.Text;
            decimal valorCompra = 0;
            decimal QuantidadeCompra = decimal.Parse(txtBoxIngredienteSelecionadoQuantidadeCompra.Text);

            if (txtBoxIngredienteSelecionadoValorCompra.Text != "")
                valorCompra = decimal.Parse(txtBoxIngredienteSelecionadoValorCompra.Text);




            if ((UnidadeCompra.ToUpper() == "L" && UnidadeEstoque.ToUpper() == "ML") || (UnidadeCompra.ToUpper() == "KG" && UnidadeEstoque.ToUpper() == "G"))
                txtBoxIngredienteSelecionadoValorUnidade.Text = ((valorCompra / QuantidadeCompra) / 1000).ToString();
            else
            {

                if ((UnidadeCompra.ToUpper() == "ML" && UnidadeEstoque.ToUpper() == "L") || (UnidadeCompra.ToUpper() == "G" && UnidadeEstoque.ToUpper() == "KG"))
                    txtBoxIngredienteSelecionadoValorUnidade.Text = ((valorCompra / QuantidadeCompra) * 1000).ToString();
                else
                    txtBoxIngredienteSelecionadoValorUnidade.Text = (valorCompra / QuantidadeCompra).ToString();
            }
        }

        private void PreencherValorCompra(object sender, EventArgs e)
        {
            CalcularValorUnidade();
        }

        private void PrepararHistorico(bool Preencherhistorico, string mudanca)
        {
            if (Preencherhistorico)
            {
                var quantidadeLogs = DbConn.GetHistoricosEstoque().Count() + 1;
                historicoEstoque.IngredienteAntes = ($"{IngredienteSelecionado.IdIngrediente}, {IngredienteSelecionado.NomeIngrediente},  {IngredienteSelecionado.QuantidadeEstoque},  {IngredienteSelecionado.UnidadeEstoque},  {IngredienteSelecionado.ValorUnidade},  {IngredienteSelecionado.QuantidadeCompra},  {IngredienteSelecionado.UnidadeCompra},  {IngredienteSelecionado.ValorCompra}");
                historicoEstoque.IdHistorico = quantidadeLogs;
                historicoEstoque.NomeIngredienteAlterado = IngredienteSelecionado.NomeIngrediente;
                historicoEstoque.DataAlteracao = DateTime.Now;
                historicoEstoque.IdIngredienteAlterado = IngredienteSelecionado.IdIngrediente;
                historicoEstoque.Mudanca = mudanca;
            }
            else
                historicoEstoque.IngredienteAtual = ($"{IngredienteSelecionado.IdIngrediente}, {IngredienteSelecionado.NomeIngrediente},  {IngredienteSelecionado.QuantidadeEstoque},  {IngredienteSelecionado.UnidadeEstoque},  {IngredienteSelecionado.ValorUnidade},  {IngredienteSelecionado.QuantidadeCompra},  {IngredienteSelecionado.UnidadeCompra},  {IngredienteSelecionado.ValorCompra}");

        }
    }
}
