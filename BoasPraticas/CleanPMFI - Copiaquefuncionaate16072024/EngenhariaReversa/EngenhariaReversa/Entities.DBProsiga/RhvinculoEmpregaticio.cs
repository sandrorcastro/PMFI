using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class RhvinculoEmpregaticio
    {
        public RhvinculoEmpregaticio()
        {
            RhdadosFuncionais = new HashSet<RhdadosFuncionai>();
        }

        public long VincEid { get; set; }
        public string? VincEnome { get; set; }

        public virtual ICollection<RhdadosFuncionai> RhdadosFuncionais { get; set; }
    }
}
