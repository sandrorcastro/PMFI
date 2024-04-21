using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscGrupoSetor
    {
        public TribFiscGrupoSetor()
        {
            TribFiscSetors = new HashSet<TribFiscSetor>();
        }

        public int GrupSetId { get; set; }
        public string? GrupSetNome { get; set; }

        public virtual ICollection<TribFiscSetor> TribFiscSetors { get; set; }
    }
}
