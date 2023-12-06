using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CannaCandiesCWB.Entidades;
using System.Reflection.Metadata.Ecma335;

namespace CannaCandiesCWB.Services
{
    public class ConexaoDB
    {
        private SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public void Disconnect()
        {
            conn.Close();
            //MessageBox.Show("Desconectado do banco de dados");
        }

        public void ConnectToDatabase()
        {
            try
            {
                var pathDB = "F:\\projetos\\OffBind\\CannaCandiesCWB\\CannaCandiesCWB\\CannaCandiesCWB\\Db\\BancoDeDados.mdf";
                var connectionString = @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={pathDB};Integrated Security=True";
                conn = new SqlConnection(connectionString);
                conn.Open();
                //MessageBox.Show("Conectado ao banco de dados");

            }
            catch (SqlCeException e)
            {
                conn.Close();
                conn = null;
                MessageBox.Show("Erro ao conectar ao Banco de dados \n\r " + e);

            }
        }

        public List<Ingredientes> GetIngredientesEstoque()
        {
            var listaIngredientes = new List<Ingredientes>();

            cmd = new SqlCommand("Select * from Estoque", conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaIngredientes.Add(new Ingredientes()
                    {
                        IdIngrediente = (int)reader["Id"],
                        NomeIngrediente = reader["NomeIngrediente"].ToString(),
                        QuantidadeEstoque = decimal.Parse(reader["QuantidadeEstoque"].ToString()),
                        UnidadeEstoque = reader["UnidadeEstoque"].ToString(),
                        ValorUnidade = reader["ValorUnidade"] == DBNull.Value ? 0 : decimal.Parse(reader["ValorUnidade"].ToString()),
                        QuantidadeCompra = reader["QuantidadeCompra"] == DBNull.Value ? 0 : decimal.Parse(reader["QuantidadeCompra"].ToString()),
                        UnidadeCompra = reader["UnidadeCompra"] == DBNull.Value ? "Não Informado" : reader["UnidadeCompra"].ToString(),
                        ValorCompra = reader["ValorCompra"] == DBNull.Value ? 0 : decimal.Parse(reader["ValorCompra"].ToString())
                    });
                }
            }



            return listaIngredientes;
        }

        public void AtualizarIngrediente(Ingredientes ingrediente)
        {
            string query = "UPDATE Estoque SET" +
                " NomeIngrediente = @NomeIngrediente," +
                " QuantidadeEstoque = @QuantidadeEstoque," +
                "  UnidadeEstoque = @UnidadeEstoque," +
                " ValorUnidade = @ValorUnidade," +
                " QuantidadeCompra = @QuantidadeCompra," +
                " UnidadeCompra = @UnidadeCompra," +
                " ValorCompra = @ValorCompra" +
                " Where Id = @id";

            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Id", ingrediente.IdIngrediente);

            if (ingrediente.NomeIngrediente != null)
                cmd.Parameters.AddWithValue("@NomeIngrediente", ingrediente.NomeIngrediente);
            else { throw new Exception("É preciso informar o nome do ingrediente"); }


            if (ingrediente.UnidadeEstoque != null)
                cmd.Parameters.AddWithValue("@UnidadeEstoque", ingrediente.UnidadeEstoque);
            else { throw new Exception("A unidade usada nas receitas deve ser informada"); }


            if (ingrediente.QuantidadeCompra != null && ingrediente.UnidadeCompra != null && ingrediente.ValorCompra != null)
            {
                cmd.Parameters.AddWithValue("@QuantidadeCompra", ingrediente.QuantidadeCompra);
                cmd.Parameters.AddWithValue("@UnidadeCompra", ingrediente.UnidadeCompra);
                cmd.Parameters.AddWithValue("@ValorCompra", ingrediente.ValorCompra.ToString());
            }
            else { throw new Exception("Quantidade, Unidade e Valor de compra não podem ser vazio"); }


            cmd.Parameters.AddWithValue("@ValorUnidade", ingrediente.ValorUnidade.ToString());
            cmd.Parameters.AddWithValue("@QuantidadeEstoque", ingrediente.QuantidadeEstoque);

            cmd.ExecuteNonQuery();
        }

        public void AdicionarIngredienteEstoque(Ingredientes ingrediente)
        {
            try
            {
                string query = "INSERT INTO Estoque " +
                            "(Id, NomeIngrediente, QuantidadeEstoque, UnidadeEstoque, ValorUnidade, QuantidadeCompra, UnidadeCompra, ValorCompra) " +
                     "VALUES (@Id, @NomeIngrediente, @QuantidadeEstoque, @UnidadeEstoque, @ValorUnidade, @QuantidadeCompra, @UnidadeCompra, @ValorCompra)";

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", ingrediente.IdIngrediente);

                if (ingrediente.NomeIngrediente != null)
                    cmd.Parameters.AddWithValue("@NomeIngrediente", ingrediente.NomeIngrediente);
                else { throw new Exception("É preciso informar o nome do ingrediente"); }


                if (ingrediente.UnidadeEstoque != null)
                    cmd.Parameters.AddWithValue("@UnidadeEstoque", ingrediente.UnidadeEstoque);
                else { throw new Exception("A unidade usada nas receitas deve ser informada"); }


                if (ingrediente.QuantidadeCompra != null && ingrediente.UnidadeCompra != null && ingrediente.ValorCompra != null)
                {
                    cmd.Parameters.AddWithValue("@QuantidadeCompra", ingrediente.QuantidadeCompra);
                    cmd.Parameters.AddWithValue("@UnidadeCompra", ingrediente.UnidadeCompra);
                    cmd.Parameters.AddWithValue("@ValorCompra", ingrediente.ValorCompra.ToString());
                }
                else { throw new Exception("Quantidade, Unidade e Valor de compra não podem ser vazio"); }


                cmd.Parameters.AddWithValue("@ValorUnidade", ingrediente.ValorUnidade.ToString());
                cmd.Parameters.AddWithValue("@QuantidadeEstoque", ingrediente.QuantidadeEstoque);



                cmd.ExecuteNonQuery();
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Erro ao adicionar o ingrediente ao estoque");
            }
        }

        public void RemoverIngredienteEstoque(int id)
        {
            try
            {
                string query = "Delete from Estoque Where Id = @Id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro ao remover o ingrediente");
            }

        }

        public bool CheckDBConnection()
        {
            return conn.State == ConnectionState.Open;
        }

        public List<HistoricoEstoque> GetHistoricosEstoque()
        {
            var listaHistoricosEstoque = new List<HistoricoEstoque>();

            cmd = new SqlCommand("Select * from HistoricoMudancas", conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaHistoricosEstoque.Add(new HistoricoEstoque()
                    {
                        IdHistorico = (int)reader["Id"],
                        IdIngredienteAlterado = (int)reader["IdIngredienteAlterado"],
                        NomeIngredienteAlterado = reader["NomeIngredienteAlterado"].ToString(),
                        DataAlteracao = DateTime.Parse(reader["DataAlteracao"].ToString()),
                        IngredienteAntes = reader["IngredienteAntes"].ToString(),
                        IngredienteAtual = reader["IngredienteDepois"].ToString(),
                    });
                }
            }



            return listaHistoricosEstoque;
        }

        public void AdicionarHistoricoEstoque(HistoricoEstoque historico)
        {
            try
            {
                string query = "INSERT INTO HistoricoMudancas " +
                          "(Id, IdIngredienteAlterado, NomeIngredienteAlterado, DataAlteracao, IngredienteAntes, IngredienteDepois) " +
                   "VALUES (@Id, @IdIngredienteAlterado, @NomeIngredienteAlterado, @DataAlteracao, @IngredienteAntes, @IngredienteDepois)";

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", historico.IdHistorico);
                cmd.Parameters.AddWithValue("@IdIngredienteAlterado", historico.IdIngredienteAlterado);

                if (historico.NomeIngredienteAlterado != null)
                    cmd.Parameters.AddWithValue("@NomeIngredienteAlterado", historico.NomeIngredienteAlterado);
                else { throw new Exception("É preciso informar o nome do ingrediente"); }

                cmd.Parameters.AddWithValue("@DataAlteracao", historico.DataAlteracao);

                cmd.Parameters.AddWithValue("@IngredienteAntes", historico.IngredienteAntes);
                cmd.Parameters.AddWithValue("@IngredienteDepois", historico.IngredienteAtual);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro ao adicionar a mudança ao log de histórico");
            }
        }
    }
}
