using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Unidade
    {
        public int UnidadeId { get; set; }
        public string? Descricao { get; set; }

        public int? OrgaoId { get; set; }
        public Orgao? Orgao { get; set; }

        public ICollection<Servidor> Servidores { get; set; }

    }
}
