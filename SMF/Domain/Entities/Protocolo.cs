using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Protocolo
    {
        public int OrgaoId { get; set; }
        public Orgao? Orgao { get; set; }

        public int? UnidadeId { get; set; }
        public Unidade? Unidade { get; set; }

        public int? DivisaoId { get; set; }
        public Divisao? Divisao { get; set; }
        
        public DateTime Data { get; set; }
    }
}
