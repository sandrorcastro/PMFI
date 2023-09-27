using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pessoa
    {
        public long IdPessoa { get; set; }
        public string Descricao { get; set; }
        public Collection<EntidadeEndereco>? Enderecos { get; set; }
        public Collection<Documento>? Documentos { get; set; }
    }
}
