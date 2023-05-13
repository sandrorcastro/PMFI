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
        public string Descricao { get; set; }
        public int TipoProcessoId { get; set; }
        public TipoProcesso TipoProcesso { get; set; }
        public int TipoEtapaId { get; set; }
        public TipoEtapa TipoEtapa { get; set; }    


    }
}
