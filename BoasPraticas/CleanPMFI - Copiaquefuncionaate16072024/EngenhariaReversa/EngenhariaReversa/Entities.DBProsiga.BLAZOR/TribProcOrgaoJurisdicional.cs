using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribProcOrgaoJurisdicional
    {
        public TribProcOrgaoJurisdicional()
        {
            TribProcProcessos = new HashSet<TribProcProcesso>();
        }

        public int ProcOrgJurisId { get; set; }
        public string ProOrgJurisNome { get; set; } = null!;

        public virtual ICollection<TribProcProcesso> TribProcProcessos { get; set; }
    }
}
