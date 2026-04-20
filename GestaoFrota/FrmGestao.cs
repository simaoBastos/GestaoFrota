using GestaoFrota.Models;

namespace GestaoFrota
{
    public partial class FrmGestao : Form
    {
        private FrotaRepository _repositorio;
        private BindingSource _bindingSouce;
        public FrmGestao()
        {
            InitializeComponent();
            _repositorio = new FrotaRepository();
            _bindingSouce = new BindingSource();

            ConfigurarFormulario();
            CarregarDados();
        }

        private void FrmGestao_Load(object sender, EventArgs e)
        {
            AjustarColunas();
        }

        public void AjustarColunas()
        {
            dgvFrota.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn col in dgvFrota.Columns)
            {
                if (col.Name != "Id")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Gestão de Frota";

            //Expressoes de coleção para inicializar arrays rapidamente
            cmbTipoVeiculo.Items.AddRange(new string[] { "Carro", "Caminhão" });
            cmbTipoVeiculo.SelectedIndex = 0;

            dgvFrota.DataSource = _bindingSouce;
            dgvFrota.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFrota.ReadOnly = true;
        }

        private void cmbTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEspecifico.Text = cmbTipoVeiculo.SelectedItem.ToString() == "Carro" ? "Qtd. Portas:"
                                                                            : "Capacidade de Carga (kg):";
        }

        private void CarregarDados()
        {
            var veiculos = _repositorio.ObterTodos();
            _bindingSouce.DataSource = veiculos.ToList();
            _bindingSouce.ResetBindings(false);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string placa = txtPlaca.Text.Trim();
                string modelo = txtModelo.Text.Trim();
                int ano = int.Parse(txtAno.Text.Trim());
                decimal diaria = decimal.Parse(txtDiaria.Text.Trim());

                Veiculo novoVeiculo;

                if (cmbTipoVeiculo.SelectedItem.ToString() == "Carro")
                {
                    int portas = int.Parse(txtEspecifico.Text);
                    novoVeiculo = new Carro(placa, modelo, ano, diaria, portas);
                }
                else
                {
                    double carga = double.Parse(txtEspecifico.Text);
                    novoVeiculo = new Caminhao(placa, modelo, ano, diaria, carga);
                }

                _repositorio.Adicionar(novoVeiculo);
                CarregarDados();
                MessageBox.Show($"Veículo adicionado! Custo p/ 5 dias: {novoVeiculo.CalcularCustoAluguel(5):C}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar veículo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvFrota.CurrentRow.DataBoundItem is Veiculo veiculoSelecionado)
            {
                _repositorio.Remover(veiculoSelecionado.Id);
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Selecione um veículo para remover.");
            }
        }

        private void LimparCampos()
        {
            txtPlaca.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtDiaria.Clear();
            txtEspecifico.Clear();
            txtPlaca.Focus();
        }

       
    }

}
