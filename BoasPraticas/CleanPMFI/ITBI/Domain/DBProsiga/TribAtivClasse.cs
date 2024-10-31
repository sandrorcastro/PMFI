using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAtivClasse
    {
        public TribAtivClasse()
        {
            TribAtivAtividades = new HashSet<TribAtivAtividade>();
        }

        public string AtivClasse { get; set; } = null!;
        public string? AtivClasseDenom { get; set; }
        public string? AtivGrupo { get; set; }

        public virtual TribAtivGrupo? AtivGrupoNavigation { get; set; }
        public virtual ICollection<TribAtivAtividade> TribAtivAtividades { get; set; }
    }
}
