using ClasseModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using ClasseControle.BL;
using System.Data;

namespace ClasseControle.DAO
{
    public class UsuarioDAO
    {
        private static UsuarioDAO instancia = null;
        public UsuarioDAO() { }
        public static UsuarioDAO getinstancia()
        {
            if (instancia == null)
                instancia = new UsuarioDAO();
            return instancia;
        }

        public UsuarioDTO Login(string senha)
        {
            string cn = ConfigurationManager.ConnectionStrings["Pim"].ConnectionString;
            SqlConnection conn = new SqlConnection(cn);
            string txt = string.Format("SELECT * FROM Usuarios WHERE Senha = '{0}' ", senha);
            SqlCommand cmd = new SqlCommand(txt, conn);
            UsuarioDTO retorno = null;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    retorno = new UsuarioDTO();
                    retorno.Id = Convert.ToInt32(dr["id"]);
                    retorno.Senha = Convert.ToString(dr["Senha"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw ex;
            }
            return retorno;
        }

        public void Alterar(UsuarioDTO usuario)
        {
            string cs = ConfigurationManager.ConnectionStrings["Pim"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SP_ALTERARUSUARIO", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", usuario.Id);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw;
            }
        }

        public void Save(UsuarioDTO usuario)
        {
            string cs = ConfigurationManager.ConnectionStrings["Pim"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SP_INSERECRIANCA", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@Endereço", usuario.Endereco);
            cmd.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
            cmd.Parameters.AddWithValue("@Escola", usuario.Escola);
            cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            cmd.Parameters.AddWithValue("@Mae", usuario.Mae);
            cmd.Parameters.AddWithValue("@Pai", usuario.Pai);
            cmd.Parameters.AddWithValue("@Responsavel", usuario.Responsavel);
            cmd.Parameters.AddWithValue("@CasaPropria", usuario.CasaPropria);
            cmd.Parameters.AddWithValue("@RendaFamilia", usuario.RendaFamilia);
            cmd.Parameters.AddWithValue("@BolsaFamilia", usuario.BolsaFamilia);
            cmd.Parameters.AddWithValue("@GastoMensal", usuario.GastoMensal);
            cmd.Parameters.AddWithValue("@Encaminhado", usuario.Encaminhado);
            cmd.Parameters.AddWithValue("@Atendimento", usuario.Atendimento1);
            cmd.Parameters.AddWithValue("@NumeroCasa", usuario.NumeroCasa1);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw;
            }
        }


        //METODO LOCALIZAR por nome
        public DataTable Localizar(String valor)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("SELECT * FROM Crianca where Nome like '%" + valor + "%' order by nome", Conexao.conn);
            da.Fill(dt);
            return dt;
        }

        public void AlterarCrianca(UsuarioDTO usuario)
        {
            string cs = ConfigurationManager.ConnectionStrings["Pim"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SP_ALTERARCRIANCA", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", usuario.Id);
            cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@Endereço", usuario.Endereco);
            cmd.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
            cmd.Parameters.AddWithValue("@Escola", usuario.Escola);
            cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            cmd.Parameters.AddWithValue("@Mae", usuario.Mae);
            cmd.Parameters.AddWithValue("@Pai", usuario.Pai);
            cmd.Parameters.AddWithValue("@Responsavel", usuario.Responsavel);
            cmd.Parameters.AddWithValue("@CasaPropria", usuario.CasaPropria);
            cmd.Parameters.AddWithValue("@RendaFamilia", usuario.RendaFamilia);
            cmd.Parameters.AddWithValue("@BolsaFamilia", usuario.BolsaFamilia);
            cmd.Parameters.AddWithValue("@GastoMensal", usuario.GastoMensal);
            cmd.Parameters.AddWithValue("@Encaminhado", usuario.Encaminhado);
            cmd.Parameters.AddWithValue("@Atendimento", usuario.Atendimento1);
            cmd.Parameters.AddWithValue("@NumeroCasa", usuario.NumeroCasa1);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw;
            }
        }
    }
}
