using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class HabCruzamentoLogr
    {
        public string Chave1 { get; set; } = null!;
        public string Chave2 { get; set; } = null!;
        public double? Gx { get; set; }
        public double? Gy { get; set; }

        public virtual HabFoneticoLogr Chave1Navigation { get; set; } = null!;
        public virtual HabFoneticoLogr Chave2Navigation { get; set; } = null!;
    }
}
