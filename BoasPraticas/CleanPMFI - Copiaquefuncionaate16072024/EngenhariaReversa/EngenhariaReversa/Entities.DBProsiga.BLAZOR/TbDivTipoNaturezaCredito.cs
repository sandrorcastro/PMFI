using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbDivTipoNaturezaCredito
    {
        public TbDivTipoNaturezaCredito()
        {
            TbDivTipoCreditos = new HashSet<TbDivTipoCredito>();
        }

        public short IdTipoNaturezaCredito { get; set; }
        public string? DsTipoNaturezaCredito { get; set; }

        public virtual ICollection<TbDivTipoCredito> TbDivTipoCreditos { get; set; }
    }
}
