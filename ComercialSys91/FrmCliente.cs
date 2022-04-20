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
             txtID.Text = c.ID.ToString();
             MessageBox.Show("Cliente gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Cliente não foi gravado no sistema.");
            }
           

        }

        

        private void btnlListar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            List <Cliente> ListaDeClientes = Cliente.Listar();
            int cont = 0;
            foreach (Cliente cliente in ListaDeClientes)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[cont].Cells[0].Value = cliente.ID.ToString();
                dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome.ToString();
                dgvClientes.Rows[cont].Cells[2].Value = cliente.Cpf.ToString();
                dgvClientes.Rows[cont].Cells[3].Value = cliente.Email.ToString();
                dgvClientes.Rows[cont].Cells[4].Value = cliente.Ativo;
                cont++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpDataCad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(btnBuscar.Text == "...")
            {
             txtID.ReadOnly = false;
             txtID.Focus();
             btnBuscar.Text = "Buscar";
            }
            else
            {
                Cliente cliente = Cliente.consultarPorID(int.Parse(txtID.Text));
                if(cliente.ID > 0)
                {
                    txtNome.Text = cliente.Nome.ToString();
                    txtCpf.Text = cliente.Cpf.ToString();
                    txtEmail.Text = cliente.Email.ToString();
                    dtpDataCad.Value = cliente.DataCad.Date;
                    chkAtivo.Checked = cliente.Ativo;

                    btnBuscar.Text = "...";
                    txtID.ReadOnly=true;
                    btnAlterar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Esse código de cliente não existe!");
                }
            }
           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (cliente.alterar(int.Parse(txtID.Text), txtNome.Text, txtEmail.Text))
            {
                MessageBox.Show("Cliente alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na alteração do Cliente!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

