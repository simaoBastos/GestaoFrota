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
            cmbTipoVeiculo.Location = new Point(228, 47);
            cmbTipoVeiculo.Margin = new Padding(4);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(249, 37);
            cmbTipoVeiculo.TabIndex = 0;
            cmbTipoVeiculo.SelectedIndexChanged += cmbTipoVeiculo_SelectedIndexChanged;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(227, 92);
            txtPlaca.Margin = new Padding(4);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(250, 37);
            txtPlaca.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(228, 138);
            txtModelo.Margin = new Padding(4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(249, 37);
            txtModelo.TabIndex = 2;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(228, 183);
            txtAno.Margin = new Padding(4);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(249, 37);
            txtAno.TabIndex = 3;
            // 
            // txtDiaria
            // 
            txtDiaria.Location = new Point(228, 228);
            txtDiaria.Margin = new Padding(4);
            txtDiaria.Name = "txtDiaria";
            txtDiaria.Size = new Size(249, 37);
            txtDiaria.TabIndex = 4;
            // 
            // txtEspecifico
            // 
            txtEspecifico.Location = new Point(228, 273);
            txtEspecifico.Margin = new Padding(4);
            txtEspecifico.Name = "txtEspecifico";
            txtEspecifico.Size = new Size(249, 37);
            txtEspecifico.TabIndex = 5;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(50, 95);
            lblPlaca.Margin = new Padding(4, 0, 4, 0);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(71, 29);
            lblPlaca.TabIndex = 6;
            lblPlaca.Text = "Placa:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(50, 141);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(97, 29);
            lblModelo.TabIndex = 7;
            lblModelo.Text = "Modelo:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(50, 186);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(59, 29);
            lblAno.TabIndex = 8;
            lblAno.Text = "Ano:";
            // 
            // lblValorDiaria
            // 
            lblValorDiaria.AutoSize = true;
            lblValorDiaria.Location = new Point(50, 231);
            lblValorDiaria.Name = "lblValorDiaria";
            lblValorDiaria.Size = new Size(165, 29);
            lblValorDiaria.TabIndex = 9;
            lblValorDiaria.Text = "Valor da Diaria:";
            // 
            // lblEspecifico
            // 
            lblEspecifico.Location = new Point(50, 276);
            lblEspecifico.Name = "lblEspecifico";
            lblEspecifico.Size = new Size(170, 83);
            lblEspecifico.TabIndex = 10;
            lblEspecifico.Text = "Especifico:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.MintCream;
            btnAdicionar.Location = new Point(228, 325);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(125, 75);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar Veículo";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Snow;
            btnRemover.Location = new Point(353, 325);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(125, 75);
            btnRemover.TabIndex = 12;
            btnRemover.Text = "Remover Veículo";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvFrota
            // 
            dgvFrota.AllowUserToAddRows = false;
            dgvFrota.AllowUserToDeleteRows = false;
            dgvFrota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFrota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFrota.Location = new Point(484, 47);
            dgvFrota.Name = "dgvFrota";
            dgvFrota.ReadOnly = true;
            dgvFrota.RowHeadersWidth = 62;
            dgvFrota.Size = new Size(705, 353);
            dgvFrota.TabIndex = 13;
            // 
            // lblTipoVeiculo
            // 
            lblTipoVeiculo.AutoSize = true;
            lblTipoVeiculo.Location = new Point(50, 50);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(171, 29);
            lblTipoVeiculo.TabIndex = 14;
            lblTipoVeiculo.Text = "Tipo de Veículo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 544);
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
