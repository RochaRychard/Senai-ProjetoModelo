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
        }

        private void lblEsqueciMinhaSenha_Click(object sender, System.EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
        }
    }
}
