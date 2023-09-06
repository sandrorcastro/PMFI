using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeTipoMedicamento
    {
        public SaudeTipoMedicamento()
        {
            SaudeMedicamentoXxxxxxes = new HashSet<SaudeMedicamentoXxxxxx>();
        }

        public int IdTipoMedicamento { get; set; }
        public string? DsTipoMedicamento { get; set; }

        public virtual ICollection<SaudeMedicamentoXxxxxx> SaudeMedicamentoXxxxxxes { get; set; }
    }
}
