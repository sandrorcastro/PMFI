using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAdvertenciaTipoOrigem
    {
        public TribAdvertenciaTipoOrigem()
        {
            TribAdvertencia = new HashSet<TribAdvertencia>();
        }

        public int TipoAdvertId { get; set; }
        public string? TipoAdvertOrigem { get; set; }

        public virtual ICollection<TribAdvertencia> TribAdvertencia { get; set; }
    }
}
