using CannaCandiesCWB.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CannaCandiesCWB.Paginas.EstoqueIngredientes
{
    public partial class EstoqueIngredientes : Form
    {
        public ConexaoDB DbConn = new ConexaoDB();
        public EstoqueIngredientes()
        {
            InitializeComponent();
        }

        private void EstoqueLoad(object sender, EventArgs e)
        {
            DbStatus.Items[0].Text = DbConn.ConnectToDatabase();
        }

        private void FechandoEstoque(object sender, FormClosingEventArgs e)
        {
            DbConn.Disconnect();
        }
    }
}
