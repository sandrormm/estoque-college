using CSA_SISTEMAS.TELAS;
using System;
using System.Windows.Forms;

namespace CSA_SISTEMA.TELAS
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();

        }

        private void frm_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void cli_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        Frm_Cliente frmc = new Frm_Cliente();
        frmc.Show(); 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private void toolStripButton1_Click(object sender, EventArgs e)
            {
            FrmUsuario frmu = new FrmUsuario();
            frmu.Show();
            }
    }
}
