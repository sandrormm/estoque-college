using CSA_SISTEMAS_DAO.CONTROLLERS;
using System;
using System.Windows.Forms;

namespace CSA_SISTEMAS.TELAS
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            usuario.Nome = txtNomeLogin.Text;
            usuario.Senha = txtPassword.Text;
        }
    }
}
