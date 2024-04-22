using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribAlvTipoCalculo
    {
        public TribAlvTipoCalculo()
        {
            TribAlvFormulas = new HashSet<TribAlvFormula>();
        }

        public short IdTipoCalculo { get; set; }
        public string? DsTipoCalculo { get; set; }
        public int? TipoTribId { get; set; }

        public virtual TribTipoTributo? TipoTrib { get; set; }
        public virtual ICollection<TribAlvFormula> TribAlvFormulas { get; set; }
    }
}
