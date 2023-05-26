using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FluxoProcesso
    {
        public int FluxoProcessoId { get; set; }
        //public int Sequencia { get; set; }
        public int TipoProcessoId { get; set; }
        public TipoProcesso? TipoProcesso { get; set; }
        public string? Descricao { get; set; }
        //public int TipoEtapaId { get; set; }
        //public TipoEtapa? TipoEtapa { get; set; }  
        public int? TempoTramitacao { get; set; }   
        //public ICollection<Etapa> Etapas { get; set; }

    }
}
