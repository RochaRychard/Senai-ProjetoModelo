﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.Show();
        }

        private void nacionalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.Show();
        }
    }
}
