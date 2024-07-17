using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProcEmbargoTipo
    {
        public long ProcEmbId { get; set; }
        public int ProcTipoEmbId { get; set; }
        public DateTime? ProcTipoEmbData { get; set; }
        public int? ProcTipoEmbNumero { get; set; }
        public int? ProcTipoEmbAno { get; set; }

        public virtual TribProcEmbargo ProcEmb { get; set; } = null!;
        public virtual TribProcTipoEmbargo ProcTipoEmb { get; set; } = null!;
    }
}
