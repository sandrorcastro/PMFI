using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProcTipoEmbargo
    {
        public TribProcTipoEmbargo()
        {
            TribProcEmbargoTipos = new HashSet<TribProcEmbargoTipo>();
        }

        public int ProcTipoEmbId { get; set; }
        public string? ProcTipoEmbNome { get; set; }

        public virtual ICollection<TribProcEmbargoTipo> TribProcEmbargoTipos { get; set; }
    }
}
