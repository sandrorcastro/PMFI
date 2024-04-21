using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class GccGruposFase
    {
        public GccGruposFase()
        {
            GccFases = new HashSet<GccFase>();
        }

        public string GrpCnpjmembro { get; set; } = null!;
        public int GrupoId { get; set; }
        public string? GrpDescr { get; set; }

        public virtual ICollection<GccFase> GccFases { get; set; }
    }
}
