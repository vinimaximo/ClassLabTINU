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
            Usuario usuario = new Usuario(txtNome.Text, txtSenha.Text, txtEmail.Text);
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                txtId.Text = usuario.Id.ToString();
                MessageBox.Show("Usuario gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir usuario");
            }

        }




        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnlLisar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();
            List<Usuario> ListaDeUsuarios = Usuario.Listar();
            int cont = 0;
            foreach (Usuario usuario in ListaDeUsuarios)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id.ToString();
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome.ToString();
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Senha.ToString();
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Email.ToString();
                cont++;

            }
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
