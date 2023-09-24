using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EntidadeEndereco
    {
        public EntidadeEndereco() { }
        public long IdEntidadeEndereco { get; set; }
        public long IdEndereco { get; set;}
        public string Numero { get; set;}
        public Collection<Endereco> Enderecos { get; set; }
        }
}
