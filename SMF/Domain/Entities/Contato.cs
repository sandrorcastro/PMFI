using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contato
    {
        public int ContatoId { get; set; }
        public int? TipoContatoId { get; set; }
        public TipoContato? TipoContato { get; set; }
        public ICollection<Contato_Pessoa>? Pessoas { get; set; }
        public bool Ativo { get; set; }
        public bool Principal { get; set; }
    }
}
