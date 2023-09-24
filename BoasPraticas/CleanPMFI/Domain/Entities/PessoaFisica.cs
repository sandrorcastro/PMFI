using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PessoaFisica : Pessoa
    {
        PessoaFisica(string nome, string nomeMeio, string sobreNome, string? idade, string sexo, string orientacaoSexual, string nomeSocial)
        {
            Nome = nome;
            NomeMeio = nomeMeio;
            SobreNome = sobreNome;
            Idade = idade;
            Sexo = sexo;
            OrientacaoSexual = orientacaoSexual;
            NomeSocial = nomeSocial;
            Descricao = nome+" "+nomeMeio+" "+sobreNome;
        }

        public string? Nome { get; set; }
        public string? NomeMeio { get; set; }
        public string? SobreNome { get; set; }
        public string? Idade { get; set; }
        public string? Sexo { get; set; }
        public string? OrientacaoSexual { get; set; }
        public string? NomeSocial { get; set; }

    }
}
