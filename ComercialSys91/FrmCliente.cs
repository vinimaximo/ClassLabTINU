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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }     
      

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text);
            c.inserir();
            if (c.ID>0)
            {
             txtid.Text = c.ID.ToString();
             MessageBox.Show("Cliente gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Cliente não foi gravado no sistema.");
            }
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnlListar_Click(object sender, EventArgs e)
        {
            lstclientes.Items.Clear();
            List <Cliente> ListaDeClientes = Cliente.Listar();
            foreach (Cliente cliente in ListaDeClientes)
            {
                lstclientes.Items.Add(cliente.ID + "-" + cliente.Nome);
            }
        }

       
    }
}

