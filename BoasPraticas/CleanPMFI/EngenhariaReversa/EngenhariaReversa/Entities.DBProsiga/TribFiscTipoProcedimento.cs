using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscTipoProcedimento
    {
        public TribFiscTipoProcedimento()
        {
            TribFiscProcedimentos = new HashSet<TribFiscProcedimento>();
        }

        public int TipoProcId { get; set; }
        public string? TipoProcNome { get; set; }
        public int? SetorId { get; set; }

        public virtual TribFiscSetor? Setor { get; set; }
        public virtual ICollection<TribFiscProcedimento> TribFiscProcedimentos { get; set; }
    }
}
