using ClasseControle.DAO;
using ClasseModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseControle.BL
{
    public class UsuarioBL
    {
        private static UsuarioBL instancia = null;
        private UsuarioBL() { }
        public static UsuarioBL getinstancia()
        {
            if (instancia == null)
                instancia = new UsuarioBL();
            return instancia;
        }

        public UsuarioDTO Login(string senha)
        {
            if (string.IsNullOrEmpty(senha))
            {
                throw new Exception("Nome do usuário ou senha inválida");
            }

            UsuarioDTO retorno = UsuarioDAO.getinstancia().Login(senha);

            if (retorno == null)
                throw new Exception("Usuário ou senha inválidos");

            return retorno;
        }


    }
}
