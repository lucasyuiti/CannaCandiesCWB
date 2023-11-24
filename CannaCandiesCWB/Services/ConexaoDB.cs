using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannaCandiesCWB.Services
{
    public class ConexaoDB
    {
        private SqlCeConnection conn;
        public DBConnection()
        {
            //constructor
        }
        ~DBConnection()
        {
            //destructor
            conn = null;
        }

        public void Disconnect()
        {
            conn.Close();
        }
        public string ConnectToDatabase()
        {
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\BancoDeDados.mdf");
                conn.Open();
                return "Connected";
            }
            catch (SqlCeException e)
            {
                conn = null;
                return e.Message;
            }
        }
    }
}
