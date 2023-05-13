using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Telefone : Contato
    {
       public int TipoTelefoneId { get; set; }
       public TipoTelefone? TipoTelefone { get; set; }
        public int? DDDId { get; set; }
        public DDD? DDD { get; set; }

        public int? OperadoraTelefoneId { get; set; }
        public OperadoraTelefone? OperadoraTelefone { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataUltimaAtualizacao { get; set; }
        public string? Numero { get; set; }
    }
}
