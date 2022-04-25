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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            var lista = Cliente.Listar();
            comboBox1.DataSource = lista.ToArray();
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Id";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
