namespace GestaoFrota
{
    partial class FrmGestao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestao));
            cmbTipoVeiculo = new ComboBox();
            txtPlaca = new TextBox();
            txtModelo = new TextBox();
            txtAno = new TextBox();
            txtDiaria = new TextBox();
            txtEspecifico = new TextBox();
            lblPlaca = new Label();
            lblModelo = new Label();
            lblAno = new Label();
            lblValorDiaria = new Label();
            lblEspecifico = new Label();
            btnAdicionar = new Button();
            btnRemover = new Button();
            dgvFrota = new DataGridView();
            lblTipoVeiculo = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFrota).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoVeiculo
            // 
            cmbTipoVeiculo.FormattingEnabled = true;
            cmbTipoVeiculo.Location = new Point(191, 47);
            cmbTipoVeiculo.Margin = new Padding(4);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(257, 27);
            cmbTipoVeiculo.TabIndex = 0;
            cmbTipoVeiculo.SelectedIndexChanged += cmbTipoVeiculo_SelectedIndexChanged;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(623, 50);
            txtPlaca.Margin = new Padding(4);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(250, 27);
            txtPlaca.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(191, 87);
            txtModelo.Margin = new Padding(4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(257, 27);
            txtModelo.TabIndex = 2;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(624, 90);
            txtAno.Margin = new Padding(4);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(249, 27);
            txtAno.TabIndex = 3;
            // 
            // txtDiaria
            // 
            txtDiaria.Location = new Point(191, 130);
            txtDiaria.Margin = new Padding(4);
            txtDiaria.Name = "txtDiaria";
            txtDiaria.Size = new Size(257, 27);
            txtDiaria.TabIndex = 4;
            // 
            // txtEspecifico
            // 
            txtEspecifico.Location = new Point(624, 130);
            txtEspecifico.Margin = new Padding(4);
            txtEspecifico.Name = "txtEspecifico";
            txtEspecifico.Size = new Size(249, 27);
            txtEspecifico.TabIndex = 5;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblPlaca.ForeColor = Color.White;
            lblPlaca.Location = new Point(455, 50);
            lblPlaca.Margin = new Padding(4, 0, 4, 0);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(49, 19);
            lblPlaca.TabIndex = 6;
            lblPlaca.Text = "Placa:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblModelo.ForeColor = Color.White;
            lblModelo.Location = new Point(15, 90);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(66, 19);
            lblModelo.TabIndex = 7;
            lblModelo.Text = "Modelo:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblAno.ForeColor = Color.White;
            lblAno.Location = new Point(455, 90);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(41, 19);
            lblAno.TabIndex = 8;
            lblAno.Text = "Ano:";
            // 
            // lblValorDiaria
            // 
            lblValorDiaria.AutoSize = true;
            lblValorDiaria.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblValorDiaria.ForeColor = Color.White;
            lblValorDiaria.Location = new Point(13, 130);
            lblValorDiaria.Name = "lblValorDiaria";
            lblValorDiaria.Size = new Size(113, 19);
            lblValorDiaria.TabIndex = 9;
            lblValorDiaria.Text = "Valor da Diaria:";
            // 
            // lblEspecifico
            // 
            lblEspecifico.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblEspecifico.ForeColor = Color.White;
            lblEspecifico.Location = new Point(455, 130);
            lblEspecifico.Name = "lblEspecifico";
            lblEspecifico.Size = new Size(162, 21);
            lblEspecifico.TabIndex = 10;
            lblEspecifico.Text = "Especifico:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.CadetBlue;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(304, 160);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(140, 30);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar Veículo";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.LightCoral;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(460, 160);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(140, 30);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover Veículo";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvFrota
            // 
            dgvFrota.AllowUserToAddRows = false;
            dgvFrota.AllowUserToDeleteRows = false;
            dgvFrota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFrota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFrota.Location = new Point(10, 195);
            dgvFrota.Name = "dgvFrota";
            dgvFrota.ReadOnly = true;
            dgvFrota.RowHeadersWidth = 62;
            dgvFrota.Size = new Size(867, 300);
            dgvFrota.TabIndex = 13;
            // 
            // lblTipoVeiculo
            // 
            lblTipoVeiculo.AutoSize = true;
            lblTipoVeiculo.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblTipoVeiculo.ForeColor = Color.White;
            lblTipoVeiculo.Location = new Point(15, 50);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(117, 19);
            lblTipoVeiculo.TabIndex = 14;
            lblTipoVeiculo.Text = "Tipo de Veículo:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(356, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 33);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Gestão de Frota";
            // 
            // FrmGestao
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(889, 507);
            Controls.Add(lblTitulo);
            Controls.Add(lblTipoVeiculo);
            Controls.Add(dgvFrota);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(lblEspecifico);
            Controls.Add(lblValorDiaria);
            Controls.Add(lblAno);
            Controls.Add(lblModelo);
            Controls.Add(lblPlaca);
            Controls.Add(txtEspecifico);
            Controls.Add(txtDiaria);
            Controls.Add(txtAno);
            Controls.Add(txtModelo);
            Controls.Add(txtPlaca);
            Controls.Add(cmbTipoVeiculo);
            Font = new Font("Calibri", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmGestao";
            Text = "Gestão de Frota";
            Load += FrmGestao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFrota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoVeiculo;
        private TextBox txtPlaca;
        private TextBox txtModelo;
        private TextBox txtAno;
        private TextBox txtDiaria;
        private TextBox txtEspecifico;
        private Label lblPlaca;
        private Label lblModelo;
        private Label lblAno;
        private Label lblValorDiaria;
        private Label lblEspecifico;
        private Button btnAdicionar;
        private Button btnRemover;
        private DataGridView dgvFrota;
        private Label lblTipoVeiculo;
        private Label lblTitulo;
    }
}
