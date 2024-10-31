using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeProgramaSaude
    {
        public SaudeProgramaSaude()
        {
            IdMedicamentos = new HashSet<SaudeMedicamentoXxxxxx>();
        }

        public int IdPrograma { get; set; }
        public string? DsPrograma { get; set; }

        public virtual ICollection<SaudeMedicamentoXxxxxx> IdMedicamentos { get; set; }
    }
}
