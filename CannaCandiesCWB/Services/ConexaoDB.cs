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

namespace CannaCandiesCWB.Services
{
    public class ConexaoDB
    {
        private SqlConnection conn;
        public SqlCommand cmd;

        public void Disconnect()
        {
            conn.Close();
        }
        public bool ConnectToDatabase()
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\\SQLEXPRESS; AttachDbFilename =BancoDeDados.mdf; Integrated Security=True; Connect Timeout=50; User Instance=False";
                conn.Open();
                MessageBox.Show("Conectado ao banco de dados");
                conn.Close();
                MessageBox.Show("Desconectado do banco de dados");
                return true;
            }
            catch (SqlCeException e)
            {
                conn.Close();
                conn = null;
                MessageBox.Show("Erro ao conectar ao Banco de dados \n\r " + e);
                return false;
            }
        }

        public bool AdicionarIngrediente(Ingredientes ingrediente)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Estoque (NomeIngrediente, QuantidadeEstoque, UnidadeEstoque, ValorUnidade, QuantidadeCompra, UnidadeCompra, ValorCompra)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

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
                    cmd.Parameters.AddWithValue("@ValorCompra", ingrediente.ValorCompra);
                }
                else { throw new Exception("Quantidade, Unidade e Valor de compra não podem ser vazio"); }


                cmd.Parameters.AddWithValue("@ValorUnidade", ingrediente.ValorUnidade);
                cmd.Parameters.AddWithValue("@QuantidadeEstoque", ingrediente.QuantidadeEstoque);

                return true;
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Erro adicionar o ingrediente ao estoque");
                return false;
            }
        }

        public bool RemoverIngredienteEstoque(int id)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM Estoque Where Id = id");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@id", id);

                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool ModificarHistoricoEstoque(HistoricoEstoque historico)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
