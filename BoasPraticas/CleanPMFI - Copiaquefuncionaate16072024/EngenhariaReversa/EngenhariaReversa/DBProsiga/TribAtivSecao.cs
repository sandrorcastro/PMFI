using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAtivSecao
    {
        public TribAtivSecao()
        {
            TribAtivDivisaos = new HashSet<TribAtivDivisao>();
        }

        public string AtivSecao { get; set; } = null!;
        public string? AtivSecaoDenom { get; set; }

        public virtual ICollection<TribAtivDivisao> TribAtivDivisaos { get; set; }
    }
}
