using AppModelo.Controller.External;
using AppModelo.view.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.view.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
             
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //CRIA A INSTÂNCIA DO CONTROLADOR
            var CepController = new ViaCepController();

            //RECEBE OS DADOS DO MÉTODO PARA OBTER O ENDEREÇO
            var endereco = CepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
        }
    }
}
