using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validator;
using AppModelo.view.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            txtEnderecoUf.Text = endereco.Uf;
        }
        //VALIDAÇÃO DE ERRO NO CAMPO DE NOME
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //VERIFICA SE A QUANTIDADE DE LETRAS ESTÁ CORRETA
            if(txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo!");
                return;
            }
            
            //VERIFICA SE DIGITOU ALGUM NÚMERO NO LUGAR DE LETRAS
            foreach (var letra in txtNome.Text)
            {
                if(char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Seu nome parece errado!");
                    return;
                }
            }
            errorProvider.Clear();
        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);
            if(cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido!");
                return;
            }
            errorProvider.Clear();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text;
            var emailEhValido = Validadores.ValidarCPF(email);
            if(emailEhValido is false)
            {
                errorProvider.SetError(txtEmail, "Email Inválido!");
                return;
            }
            errorProvider.Clear();
        }

       //PEGA A DATA DE HOJE E ACRESCENTA 1 DIA
        DateTime.Now.AddDays(1);
    }
}
