using AppModelo.Model.Domain.Validator;
using System.Windows.Forms;

namespace AppModelo.view.Windows
{
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnRecuperarAcesso_Click(object sender, System.EventArgs e)
        {
            
            var email = txtRecuperarSenha.Text;
            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtRecuperarSenha, "Email Inválido!");
                txtRecuperarSenha.Focus();
                return;
            }
            errorProvider1.Clear();
            
        }
    }
}

