using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAtivDivisao
    {
        public TribAtivDivisao()
        {
            TribAtivGrupos = new HashSet<TribAtivGrupo>();
        }

        public string AtivDiv { get; set; } = null!;
        public string? AtivDivDenom { get; set; }
        public string AtivSecao { get; set; } = null!;

        public virtual TribAtivSecao AtivSecaoNavigation { get; set; } = null!;
        public virtual ICollection<TribAtivGrupo> TribAtivGrupos { get; set; }
    }
}
