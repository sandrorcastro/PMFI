using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class CnaetribAtivSecao
    {
        public CnaetribAtivSecao()
        {
            CnaetribAtivDivisaos = new HashSet<CnaetribAtivDivisao>();
        }

        public string AtivSecao { get; set; } = null!;
        public string? AtivSecaoDenom { get; set; }

        public virtual ICollection<CnaetribAtivDivisao> CnaetribAtivDivisaos { get; set; }
    }
}
