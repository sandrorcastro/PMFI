using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public string NomeFantazia { get; set; }
        public string RazaoSocial { get; set; }

    }
}
