using AppModelo.Model.Domain.Validator;
using AppModelo.view.Windows.Cadastros;
using System.Windows.Forms;

namespace AppModelo.view.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, System.EventArgs e)
        {
            var form = new frmPrincipal();
            form.Show();
            form.Hide();

            var email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Email Inválido!");
                return;
            }
            errorProvider1.Clear();
        }

        private void lblEsqueciMinhaSenha_Click(object sender, System.EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
        }
    }
}
