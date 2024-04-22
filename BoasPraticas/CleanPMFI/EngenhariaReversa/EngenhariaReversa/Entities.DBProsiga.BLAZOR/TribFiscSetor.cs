using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribFiscSetor
    {
        public TribFiscSetor()
        {
            TribFiscTipoProcedimentos = new HashSet<TribFiscTipoProcedimento>();
        }

        public int SetorId { get; set; }
        public string? SetorNome { get; set; }
        public int GrupSetId { get; set; }

        public virtual TribFiscGrupoSetor GrupSet { get; set; } = null!;
        public virtual ICollection<TribFiscTipoProcedimento> TribFiscTipoProcedimentos { get; set; }
    }
}
