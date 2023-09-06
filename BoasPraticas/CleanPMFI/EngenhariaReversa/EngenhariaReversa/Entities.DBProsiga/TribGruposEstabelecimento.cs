using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribGruposEstabelecimento
    {
        public TribGruposEstabelecimento()
        {
            TribEmpresas = new HashSet<TribEmpresa>();
        }

        public string EstabGrupo { get; set; } = null!;
        public string? EstabGrupoNome { get; set; }
        public decimal QtdeUfmbombeiros { get; set; }

        public virtual ICollection<TribEmpresa> TribEmpresas { get; set; }
    }
}
