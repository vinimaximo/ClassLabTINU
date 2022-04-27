using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClassLabTINU;

namespace ComercialSys91
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cclientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar instância do formulario Cliente
            FrmCliente frmCliente = new FrmCliente();
            // tornando frmCliente filho do container FrmPrincipal (this)
            frmCliente.MdiParent = this;
            // exibe o formulario de cliente no formprincipal 
            frmCliente.Show();
        }

       
               
        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario(this);
            frmUsuario.Show();
            
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.MdiParent = this;
            frmPedidos.Show();
        }
    }
}
