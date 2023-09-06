using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAtivGrupo
    {
        public TribAtivGrupo()
        {
            TribAtivClasses = new HashSet<TribAtivClasse>();
            TipoEstabs = new HashSet<SerIturTipoEstabelecimento>();
        }

        public string AtivGrupo { get; set; } = null!;
        public string? AtivGrupoDenom { get; set; }
        public string? AtivDiv { get; set; }

        public virtual TribAtivDivisao? AtivDivNavigation { get; set; }
        public virtual ICollection<TribAtivClasse> TribAtivClasses { get; set; }

        public virtual ICollection<SerIturTipoEstabelecimento> TipoEstabs { get; set; }
    }
}
