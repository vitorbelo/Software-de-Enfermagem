using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistenteSocial2._0
{
    public partial class frmEscolha : Form
    {
        public frmEscolha()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            frmAtendimento frm = new frmAtendimento();
            this.Hide();
            frm.ShowDialog();
        }

        private void FrmEscolha_Load(object sender, EventArgs e)
        {

        }


        private void BtnFechar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes)
            {
                this.Hide();
                this.Close();
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
