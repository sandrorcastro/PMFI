using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribTipoTributoOrigem
    {
        public TribTipoTributoOrigem()
        {
            TribTipoTributos = new HashSet<TribTipoTributo>();
        }

        public short TrOrId { get; set; }
        public string? TrOrDescricao { get; set; }

        public virtual ICollection<TribTipoTributo> TribTipoTributos { get; set; }
    }
}
