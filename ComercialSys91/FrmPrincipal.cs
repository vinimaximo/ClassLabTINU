﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario(this);
            frmUsuario.Show();
            
        }
    }
}