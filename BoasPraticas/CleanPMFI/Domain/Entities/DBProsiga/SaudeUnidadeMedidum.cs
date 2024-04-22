using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeUnidadeMedidum
    {
        public SaudeUnidadeMedidum()
        {
            SaudeMedicamentoXxxxxxes = new HashSet<SaudeMedicamentoXxxxxx>();
        }

        public int IdUnidadeMedida { get; set; }
        public string? DsUnidadeMedida { get; set; }

        public virtual ICollection<SaudeMedicamentoXxxxxx> SaudeMedicamentoXxxxxxes { get; set; }
    }
}
