using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class AlmTipoSaidum
    {
        public AlmTipoSaidum()
        {
            AlmSaida = new HashSet<AlmSaida>();
        }

        public int TipoSaidaId { get; set; }
        public string? Tsnome { get; set; }
        public string? Tsfuncao { get; set; }
        public string? Tsobservacao { get; set; }

        public virtual ICollection<AlmSaida> AlmSaida { get; set; }
    }
}
