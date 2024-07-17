using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class CnaetribAtivClasse
    {
        public CnaetribAtivClasse()
        {
            CnaetribAtivAtividades = new HashSet<CnaetribAtivAtividade>();
        }

        public string AtivClasse { get; set; } = null!;
        public string? AtivClasseDenom { get; set; }
        public string? AtivGrupo { get; set; }

        public virtual CnaetribAtivGrupo? AtivGrupoNavigation { get; set; }
        public virtual ICollection<CnaetribAtivAtividade> CnaetribAtivAtividades { get; set; }
    }
}
