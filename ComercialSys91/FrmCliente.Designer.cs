namespace ComercialSys91
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnlListar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtDesativar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCep = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComplemento = new MetroFramework.Controls.MetroTextBox();
            this.txtUf = new MetroFramework.Controls.MetroTextBox();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.txtNumero = new MetroFramework.Controls.MetroTextBox();
            this.txtEstado = new MetroFramework.Controls.MetroTextBox();
            this.txt_bairro = new MetroFramework.Controls.MetroTextBox();
            this.txtLogadouro = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTipo = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 10);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(40, 53);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(112, 20);
            this.txtCpf.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(203, 53);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(40, 11);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(31, 20);
            this.txtID.TabIndex = 3;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 125);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnlListar
            // 
            this.btnlListar.Location = new System.Drawing.Point(203, 125);
            this.btnlListar.Name = "btnlListar";
            this.btnlListar.Size = new System.Drawing.Size(89, 23);
            this.btnlListar.TabIndex = 10;
            this.btnlListar.Text = "&Listar Todos";
            this.btnlListar.UseVisualStyleBackColor = true;
            this.btnlListar.Click += new System.EventHandler(this.btnlListar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(93, 125);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtDesativar
            // 
            this.txtDesativar.Location = new System.Drawing.Point(298, 125);
            this.txtDesativar.Name = "txtDesativar";
            this.txtDesativar.Size = new System.Drawing.Size(75, 23);
            this.txtDesativar.TabIndex = 12;
            this.txtDesativar.Text = "&Desativar";
            this.txtDesativar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(52, 84);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 14;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data de cadastro";
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Enabled = false;
            this.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCad.Location = new System.Drawing.Point(289, 89);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(84, 20);
            this.dtpDataCad.TabIndex = 16;
            this.dtpDataCad.ValueChanged += new System.EventHandler(this.dtpDataCad_ValueChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnCpf,
            this.clnEmail,
            this.clnAtivo});
            this.dgvClientes.Location = new System.Drawing.Point(345, 299);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(455, 150);
            this.dgvClientes.TabIndex = 17;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 50;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 130;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "Cpf";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Width = 90;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 130;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Width = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(77, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCep
            // 
            // 
            // 
            // 
            this.txtCep.CustomButton.Image = null;
            this.txtCep.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCep.CustomButton.Name = "";
            this.txtCep.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCep.CustomButton.TabIndex = 1;
            this.txtCep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCep.CustomButton.UseSelectable = true;
            this.txtCep.CustomButton.Visible = false;
            this.txtCep.Lines = new string[0];
            this.txtCep.Location = new System.Drawing.Point(12, 188);
            this.txtCep.MaxLength = 32767;
            this.txtCep.Name = "txtCep";
            this.txtCep.PasswordChar = '\0';
            this.txtCep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCep.SelectedText = "";
            this.txtCep.SelectionLength = 0;
            this.txtCep.SelectionStart = 0;
            this.txtCep.ShortcutsEnabled = true;
            this.txtCep.Size = new System.Drawing.Size(75, 23);
            this.txtCep.TabIndex = 19;
            this.txtCep.UseSelectable = true;
            this.txtCep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCep.Click += new System.EventHandler(this.txtCep_Click);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tipo";
            // 
            // txtComplemento
            // 
            // 
            // 
            // 
            this.txtComplemento.CustomButton.Image = null;
            this.txtComplemento.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtComplemento.CustomButton.Name = "";
            this.txtComplemento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtComplemento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComplemento.CustomButton.TabIndex = 1;
            this.txtComplemento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComplemento.CustomButton.UseSelectable = true;
            this.txtComplemento.CustomButton.Visible = false;
            this.txtComplemento.Lines = new string[0];
            this.txtComplemento.Location = new System.Drawing.Point(11, 241);
            this.txtComplemento.MaxLength = 32767;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.PasswordChar = '\0';
            this.txtComplemento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComplemento.SelectedText = "";
            this.txtComplemento.SelectionLength = 0;
            this.txtComplemento.SelectionStart = 0;
            this.txtComplemento.ShortcutsEnabled = true;
            this.txtComplemento.Size = new System.Drawing.Size(140, 23);
            this.txtComplemento.TabIndex = 21;
            this.txtComplemento.UseSelectable = true;
            this.txtComplemento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComplemento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUf
            // 
            // 
            // 
            // 
            this.txtUf.CustomButton.Image = null;
            this.txtUf.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtUf.CustomButton.Name = "";
            this.txtUf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUf.CustomButton.TabIndex = 1;
            this.txtUf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUf.CustomButton.UseSelectable = true;
            this.txtUf.CustomButton.Visible = false;
            this.txtUf.Lines = new string[0];
            this.txtUf.Location = new System.Drawing.Point(162, 289);
            this.txtUf.MaxLength = 32767;
            this.txtUf.Name = "txtUf";
            this.txtUf.PasswordChar = '\0';
            this.txtUf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUf.SelectedText = "";
            this.txtUf.SelectionLength = 0;
            this.txtUf.SelectionStart = 0;
            this.txtUf.ShortcutsEnabled = true;
            this.txtUf.Size = new System.Drawing.Size(74, 23);
            this.txtUf.TabIndex = 22;
            this.txtUf.UseSelectable = true;
            this.txtUf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCidade
            // 
            // 
            // 
            // 
            this.txtCidade.CustomButton.Image = null;
            this.txtCidade.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txtCidade.CustomButton.Name = "";
            this.txtCidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCidade.CustomButton.TabIndex = 1;
            this.txtCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCidade.CustomButton.UseSelectable = true;
            this.txtCidade.CustomButton.Visible = false;
            this.txtCidade.Lines = new string[0];
            this.txtCidade.Location = new System.Drawing.Point(343, 241);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(87, 23);
            this.txtCidade.TabIndex = 23;
            this.txtCidade.UseSelectable = true;
            this.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNumero
            // 
            // 
            // 
            // 
            this.txtNumero.CustomButton.Image = null;
            this.txtNumero.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtNumero.CustomButton.Name = "";
            this.txtNumero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumero.CustomButton.TabIndex = 1;
            this.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumero.CustomButton.UseSelectable = true;
            this.txtNumero.CustomButton.Visible = false;
            this.txtNumero.Lines = new string[0];
            this.txtNumero.Location = new System.Drawing.Point(343, 188);
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.ShortcutsEnabled = true;
            this.txtNumero.Size = new System.Drawing.Size(74, 23);
            this.txtNumero.TabIndex = 24;
            this.txtNumero.UseSelectable = true;
            this.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEstado
            // 
            // 
            // 
            // 
            this.txtEstado.CustomButton.Image = null;
            this.txtEstado.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtEstado.CustomButton.Name = "";
            this.txtEstado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEstado.CustomButton.TabIndex = 1;
            this.txtEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEstado.CustomButton.UseSelectable = true;
            this.txtEstado.CustomButton.Visible = false;
            this.txtEstado.Lines = new string[0];
            this.txtEstado.Location = new System.Drawing.Point(12, 289);
            this.txtEstado.MaxLength = 32767;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.ShortcutsEnabled = true;
            this.txtEstado.Size = new System.Drawing.Size(140, 23);
            this.txtEstado.TabIndex = 25;
            this.txtEstado.UseSelectable = true;
            this.txtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_bairro
            // 
            // 
            // 
            // 
            this.txt_bairro.CustomButton.Image = null;
            this.txt_bairro.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txt_bairro.CustomButton.Name = "";
            this.txt_bairro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_bairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bairro.CustomButton.TabIndex = 1;
            this.txt_bairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_bairro.CustomButton.UseSelectable = true;
            this.txt_bairro.CustomButton.Visible = false;
            this.txt_bairro.Lines = new string[0];
            this.txt_bairro.Location = new System.Drawing.Point(157, 241);
            this.txt_bairro.MaxLength = 32767;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.PasswordChar = '\0';
            this.txt_bairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_bairro.SelectedText = "";
            this.txt_bairro.SelectionLength = 0;
            this.txt_bairro.SelectionStart = 0;
            this.txt_bairro.ShortcutsEnabled = true;
            this.txt_bairro.Size = new System.Drawing.Size(180, 23);
            this.txt_bairro.TabIndex = 26;
            this.txt_bairro.UseSelectable = true;
            this.txt_bairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_bairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLogadouro
            // 
            // 
            // 
            // 
            this.txtLogadouro.CustomButton.Image = null;
            this.txtLogadouro.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtLogadouro.CustomButton.Name = "";
            this.txtLogadouro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLogadouro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogadouro.CustomButton.TabIndex = 1;
            this.txtLogadouro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogadouro.CustomButton.UseSelectable = true;
            this.txtLogadouro.CustomButton.Visible = false;
            this.txtLogadouro.Lines = new string[0];
            this.txtLogadouro.Location = new System.Drawing.Point(93, 188);
            this.txtLogadouro.MaxLength = 32767;
            this.txtLogadouro.Name = "txtLogadouro";
            this.txtLogadouro.PasswordChar = '\0';
            this.txtLogadouro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogadouro.SelectedText = "";
            this.txtLogadouro.SelectionLength = 0;
            this.txtLogadouro.SelectionStart = 0;
            this.txtLogadouro.ShortcutsEnabled = true;
            this.txtLogadouro.Size = new System.Drawing.Size(244, 23);
            this.txtLogadouro.TabIndex = 27;
            this.txtLogadouro.UseSelectable = true;
            this.txtLogadouro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogadouro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Logadouro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Bairro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Cep";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Complemento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Estado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(342, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Número";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(159, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "UF";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(340, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Cidade";
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.ItemHeight = 23;
            this.txtTipo.Location = new System.Drawing.Point(436, 241);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(106, 29);
            this.txtTipo.TabIndex = 36;
            this.txtTipo.UseSelectable = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLogadouro);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.dtpDataCad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesativar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnlListar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnlListar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button txtDesativar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.Button btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtCep;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtComplemento;
        private MetroFramework.Controls.MetroTextBox txtUf;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroTextBox txtNumero;
        private MetroFramework.Controls.MetroTextBox txtEstado;
        private MetroFramework.Controls.MetroTextBox txt_bairro;
        private MetroFramework.Controls.MetroTextBox txtLogadouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroComboBox txtTipo;
    }
}

