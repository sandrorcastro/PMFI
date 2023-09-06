using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTipoProcesso
    {
        public TribTipoProcesso()
        {
            TribTipoProcessoTributos = new HashSet<TribTipoProcessoTributo>();
        }

        public int TipoProcessoId { get; set; }
        public string? DsTipoProcesso { get; set; }

        public virtual ICollection<TribTipoProcessoTributo> TribTipoProcessoTributos { get; set; }
    }
}
