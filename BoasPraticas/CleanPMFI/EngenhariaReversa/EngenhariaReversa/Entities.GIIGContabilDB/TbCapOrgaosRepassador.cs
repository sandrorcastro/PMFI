using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapOrgaosRepassador
    {
        public TbCapOrgaosRepassador()
        {
            TbCapRecursos = new HashSet<TbCapRecurso>();
        }

        public int IdOrgaoRepassador { get; set; }
        public string? DsOrgaoRepassador { get; set; }
        public int? IdTcerepassador { get; set; }
        public string? DsOrigem { get; set; }
        public int? IdPessoa { get; set; }

        public virtual ICollection<TbCapRecurso> TbCapRecursos { get; set; }
    }
}
