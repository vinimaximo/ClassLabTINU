using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLabTINU;


namespace ComercialSys91
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario( Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            
        }
      

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(
               Convert.ToInt32 (txtId.Text),
                 txtNome.Text,
                 txtEmail.Text,
                 txtSenha.Text
                 );
               u.inserir();

            
        }




        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnlLisar_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (usuario. alterar(int.Parse(txtId.Text), txtNome.Text, txtSenha.Text, txtEmail.Text))
            {
                MessageBox.Show("Usuario alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na alteração do Usuario!");
            }
        }
    }
}
