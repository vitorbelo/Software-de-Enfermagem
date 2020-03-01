using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseControle.BL;
using ClasseControle.DAO;
using ClasseModel.DTO;

namespace ClasseControle.Controle
{
    public class Controle
    {
        private static Controle instancia = null;
        private Controle() { }
        public static Controle getinstancia()
        {
            if (instancia == null)
                instancia = new Controle();
            return instancia;
        }

        public UsuarioDTO RealizaLogin(string senha)
        {
            UsuarioDTO retorno = UsuarioBL.getinstancia().Login(senha);
            return retorno;
        }

    }
}
