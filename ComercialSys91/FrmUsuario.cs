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

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario c = new Usuario(txtNome.Text, txtEmail.Text, txtPassword.Text);
            c.inserir(); 
            if (c.Id > 0)
            {
                txtId.Text = c.Id.ToString();
                MessageBox.Show("Usuario gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Usuario não foi gravado no sistema.");
            }
        }

        private void lstusuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstusuarios.Items.Clear();
            List<Usuario> Listadeusuario = Usuario.Listar();
            foreach (Usuario usuario in Listadeusuario)
            {
                lstusuarios.Items.Add(usuario.Id + "-" + usuario.Nome);
            }
        }

       
    }
}
