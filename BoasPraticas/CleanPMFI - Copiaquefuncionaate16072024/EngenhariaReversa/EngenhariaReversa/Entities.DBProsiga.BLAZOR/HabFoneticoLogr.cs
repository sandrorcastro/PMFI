using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class HabFoneticoLogr
    {
        public HabFoneticoLogr()
        {
            HabCruzamentoLogrChave1Navigations = new HashSet<HabCruzamentoLogr>();
            HabCruzamentoLogrChave2Navigations = new HashSet<HabCruzamentoLogr>();
        }

        public string Chave { get; set; } = null!;
        public string? Rua { get; set; }
        public string? Fonetico { get; set; }

        public virtual ICollection<HabCruzamentoLogr> HabCruzamentoLogrChave1Navigations { get; set; }
        public virtual ICollection<HabCruzamentoLogr> HabCruzamentoLogrChave2Navigations { get; set; }
    }
}
