using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseModel.DTO
{
    public class UsuarioDTO
    {
        private int id;
        private String senha;
        private String nome;
        private String endereço;
        private String dataNascimento;
        private String endereco;
        private String escola;
        private String telefone;
        private String mae;
        private String pai;
        private String responsavel;
        private String casaPropria;
        private String rendaFamilia;
        private String bolsaFamilia;
        private String gastoMensal;
        private String encaminhado;
        private String Atendimento;
        private String NumeroCasa;

        public int Id { get => id; set => id = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereço { get => endereço; set => endereço = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Escola { get => escola; set => escola = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Mae { get => mae; set => mae = value; }
        public string Pai { get => pai; set => pai = value; }
        public string Responsavel { get => responsavel; set => responsavel = value; }
        public string CasaPropria { get => casaPropria; set => casaPropria = value; }
        public string RendaFamilia { get => rendaFamilia; set => rendaFamilia = value; }
        public string BolsaFamilia { get => bolsaFamilia; set => bolsaFamilia = value; }
        public string GastoMensal { get => gastoMensal; set => gastoMensal = value; }
        public string Encaminhado { get => encaminhado; set => encaminhado = value; }
        public string Atendimento1 { get => Atendimento; set => Atendimento = value; }
        public string NumeroCasa1 { get => NumeroCasa; set => NumeroCasa = value; }
    }
}
