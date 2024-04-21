using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProcTipoInformacao
    {
        public TribProcTipoInformacao()
        {
            TribProcInfoComplementars = new HashSet<TribProcInfoComplementar>();
        }

        public int ProcTipoInfoId { get; set; }
        public string? ProcTipoInfoNome { get; set; }

        public virtual ICollection<TribProcInfoComplementar> TribProcInfoComplementars { get; set; }
    }
}
