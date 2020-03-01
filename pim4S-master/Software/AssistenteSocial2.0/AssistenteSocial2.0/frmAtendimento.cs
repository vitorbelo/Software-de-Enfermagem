using ClasseControle.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistenteSocial2._0
{
    public partial class frmAtendimento : Form
    {
        public frmAtendimento()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEscolha frm = new frmEscolha();
            this.Hide();
            frm.ShowDialog();
        }

        private void frmAtendimento_Load(object sender, EventArgs e)
        {

        //    Listar();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Purple,
                                                                       Color.BlueViolet,
                                                                       30F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        public void Listar()
        {

            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = default(SqlDataAdapter);
                try
                {
                    ClasseControle.DAO.Conexao.obterConexao();
                    da = new SqlDataAdapter("SELECT * FROM Crianca", ClasseControle.DAO.Conexao.connString);
                    da.Fill(dt);
                    dgvMostar.DataSource = dt;


                }
                catch (Exception)
                {
                    MessageBox.Show("Erro.");
                    ClasseControle.DAO.Conexao.FecharConexao();
                }

            }
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(txtPesquisar.Text);
            //List<UsuarioDAO> jujuba = ClasseControle.Controle.Controle.getinstancia().ListarPorId(id);
            //dgvMostar.ItemsSource = jujuba;
            ClasseControle.DAO.Conexao.obterConexao();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            dgvMostar.DataSource = usuarioDAO.Localizar(txtPesquisar.Text);

        }

        private void dgvMostar_DoubleClick(object sender, EventArgs e)
        {
            txbID.Text = dgvMostar.CurrentRow.Cells[0].Value.ToString(); ;
            txbNome.Text = dgvMostar.CurrentRow.Cells[1].Value.ToString(); ;
            txbEscola.Text = dgvMostar.CurrentRow.Cells[4].Value.ToString(); ;
            txbDtNascimento.Text = dgvMostar.CurrentRow.Cells[3].Value.ToString(); ;
            txbMAe.Text = dgvMostar.CurrentRow.Cells[6].Value.ToString(); ;
            txbPai.Text = dgvMostar.CurrentRow.Cells[7].Value.ToString(); ;
            txbResponsavel.Text = dgvMostar.CurrentRow.Cells[8].Value.ToString(); ;
            txbEndereco.Text = dgvMostar.CurrentRow.Cells[2].Value.ToString(); ;
            txbTelefone.Text = dgvMostar.CurrentRow.Cells[5].Value.ToString(); ;
            txbCPropria.Text = dgvMostar.CurrentRow.Cells[9].Value.ToString(); ;
            txbBFamilia.Text = dgvMostar.CurrentRow.Cells[11].Value.ToString(); ;
            txbRFamilia.Text = dgvMostar.CurrentRow.Cells[10].Value.ToString(); ;
            txbGMensal.Text = dgvMostar.CurrentRow.Cells[12].Value.ToString(); ;
            txbEncaminhado.Text = dgvMostar.CurrentRow.Cells[13].Value.ToString(); ;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClasseModel.DTO.UsuarioDTO usuario = new ClasseModel.DTO.UsuarioDTO();
            usuario.Id = Convert.ToInt32(txbID.Text);
            usuario.Nome = txbNome.Text;
            usuario.Mae = txbMAe.Text;
            usuario.Pai = txbPai.Text;
            usuario.RendaFamilia = txbRFamilia.Text;
            usuario.Responsavel = txbResponsavel.Text;
            usuario.Telefone = txbTelefone.Text;
            usuario.GastoMensal = txbGMensal.Text;
            usuario.Escola = txbEscola.Text;
            usuario.Endereco = txbEndereco.Text;
            usuario.Encaminhado = txbEncaminhado.Text;
            usuario.CasaPropria = txbCPropria.Text;
            usuario.BolsaFamilia = txbBFamilia.Text;
            usuario.DataNascimento = txbDtNascimento.Text;
            usuario.Atendimento1 = txbAtendimento.Text;
            usuario.NumeroCasa1 = txbNumeroCasa.Text;

            try
            {
                UsuarioDAO.getinstancia().AlterarCrianca(usuario);
                MessageBox.Show("Sucesso");
            }
            catch (Exception z)
            {

                MessageBox.Show(z.Message);
            }
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
    }
    
}
