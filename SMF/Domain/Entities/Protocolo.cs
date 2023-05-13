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
        
        public long SequenciaNumerica { get; set; }
        public DateTime Ano  {get;set; }
        public int DigitoVerificador { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
