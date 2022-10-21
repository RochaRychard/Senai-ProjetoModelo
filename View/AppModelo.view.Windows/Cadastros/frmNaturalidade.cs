using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.view.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {

        private NaturalidadeController _naturalidadeController = new NaturalidadeController();

        public frmNaturalidade()
        {
            InitializeComponent();
            var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidades();
            dgNaturalidade.DataSource = listaDeNaturalidade;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var salvou = _naturalidadeController.Cadastrar(txtDescricaoNaturalidade.Text);
            if (salvou)
            {
                MessageBox.Show("Naturalidade incluída com sucesso!");
                txtDescricaoNaturalidade.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados!");
            }
        }
    }
}

