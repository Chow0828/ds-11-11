using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licaods
{
    public partial class menuStrip1 : Form
    {
        public menuStrip1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmusuario fu = new frmusuario();
            fu.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcliente fu = new frmcliente();
            fu.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfornecedor fu = new frmfornecedor();
            fu.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproduto fu = new frmproduto();
            fu.ShowDialog();
        }
    }
}
