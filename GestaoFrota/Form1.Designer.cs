namespace GestaoFrota
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            ((System.ComponentModel.ISupportInitialize)dgvFrota).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoVeiculo
            // 
            cmbTipoVeiculo.FormattingEnabled = true;
            cmbTipoVeiculo.Location = new Point(191, 47);
            cmbTipoVeiculo.Margin = new Padding(4);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(249, 27);
            cmbTipoVeiculo.TabIndex = 0;
            cmbTipoVeiculo.SelectedIndexChanged += cmbTipoVeiculo_SelectedIndexChanged;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(626, 47);
            txtPlaca.Margin = new Padding(4);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(250, 27);
            txtPlaca.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(191, 82);
            txtModelo.Margin = new Padding(4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(249, 27);
            txtModelo.TabIndex = 2;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(625, 82);
            txtAno.Margin = new Padding(4);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(249, 27);
            txtAno.TabIndex = 3;
            // 
            // txtDiaria
            // 
            txtDiaria.Location = new Point(191, 117);
            txtDiaria.Margin = new Padding(4);
            txtDiaria.Name = "txtDiaria";
            txtDiaria.Size = new Size(249, 27);
            txtDiaria.TabIndex = 4;
            // 
            // txtEspecifico
            // 
            txtEspecifico.Location = new Point(626, 117);
            txtEspecifico.Margin = new Padding(4);
            txtEspecifico.Name = "txtEspecifico";
            txtEspecifico.Size = new Size(249, 27);
            txtEspecifico.TabIndex = 5;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Calibri", 10F);
            lblPlaca.Location = new Point(448, 53);
            lblPlaca.Margin = new Padding(4, 0, 4, 0);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(42, 17);
            lblPlaca.TabIndex = 6;
            lblPlaca.Text = "Placa:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Calibri", 10F);
            lblModelo.Location = new Point(13, 88);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(55, 17);
            lblModelo.TabIndex = 7;
            lblModelo.Text = "Modelo:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Calibri", 10F);
            lblAno.Location = new Point(447, 88);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(34, 17);
            lblAno.TabIndex = 8;
            lblAno.Text = "Ano:";
            // 
            // lblValorDiaria
            // 
            lblValorDiaria.AutoSize = true;
            lblValorDiaria.Font = new Font("Calibri", 10F);
            lblValorDiaria.Location = new Point(13, 123);
            lblValorDiaria.Name = "lblValorDiaria";
            lblValorDiaria.Size = new Size(95, 17);
            lblValorDiaria.TabIndex = 9;
            lblValorDiaria.Text = "Valor da Diaria:";
            // 
            // lblEspecifico
            // 
            lblEspecifico.Font = new Font("Calibri", 10F);
            lblEspecifico.Location = new Point(448, 123);
            lblEspecifico.Name = "lblEspecifico";
            lblEspecifico.Size = new Size(170, 21);
            lblEspecifico.TabIndex = 10;
            lblEspecifico.Text = "Especifico:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.MintCream;
            btnAdicionar.Font = new Font("Calibri", 10F);
            btnAdicionar.Location = new Point(316, 151);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(125, 30);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar Veículo";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Snow;
            btnRemover.Font = new Font("Calibri", 10F);
            btnRemover.Location = new Point(448, 151);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(125, 30);
            btnRemover.TabIndex = 12;
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
            dgvFrota.Location = new Point(14, 187);
            dgvFrota.Name = "dgvFrota";
            dgvFrota.ReadOnly = true;
            dgvFrota.RowHeadersWidth = 62;
            dgvFrota.Size = new Size(863, 308);
            dgvFrota.TabIndex = 13;
            // 
            // lblTipoVeiculo
            // 
            lblTipoVeiculo.AutoSize = true;
            lblTipoVeiculo.Font = new Font("Calibri", 10F);
            lblTipoVeiculo.Location = new Point(12, 53);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(96, 17);
            lblTipoVeiculo.TabIndex = 14;
            lblTipoVeiculo.Text = "Tipo de Veículo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 507);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
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
    }
}
