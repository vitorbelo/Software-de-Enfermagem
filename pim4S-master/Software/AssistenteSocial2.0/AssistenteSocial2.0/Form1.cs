using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseControle.DAO;
using ClasseModel.DTO;
using System.Windows.Forms;
using ClasseControle.BL;
using System.Drawing.Drawing2D;

namespace AssistenteSocial2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            ClasseModel.DTO.UsuarioDTO usuario = new ClasseModel.DTO.UsuarioDTO();
            usuario.Senha = txbSenha.Text;

            try
            {
                UsuarioDTO porra = ClasseControle.Controle.Controle.getinstancia().RealizaLogin(txbSenha.Text);
                frmEscolha frm = new frmEscolha();
                this.Hide();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja realmente sair?" , "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes)
            {
                this.Hide();
                this.Close();
            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
