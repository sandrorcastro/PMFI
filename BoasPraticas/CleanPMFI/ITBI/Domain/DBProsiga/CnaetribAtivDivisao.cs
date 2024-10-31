using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class CnaetribAtivDivisao
    {
        public CnaetribAtivDivisao()
        {
            CnaetribAtivGrupos = new HashSet<CnaetribAtivGrupo>();
        }

        public string AtivDiv { get; set; } = null!;
        public string? AtivDivDenom { get; set; }
        public string AtivSecao { get; set; } = null!;

        public virtual CnaetribAtivSecao AtivSecaoNavigation { get; set; } = null!;
        public virtual ICollection<CnaetribAtivGrupo> CnaetribAtivGrupos { get; set; }
    }
}
