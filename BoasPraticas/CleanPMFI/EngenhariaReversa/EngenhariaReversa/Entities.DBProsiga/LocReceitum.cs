using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class LocReceitum
    {
        public LocReceitum()
        {
            LocTaxas = new HashSet<LocTaxa>();
        }

        public string ReceitaCodigo { get; set; } = null!;
        public string? RecDescricao { get; set; }
        public int? RecConvenioId { get; set; }

        public virtual ConvenioBanco? RecConvenio { get; set; }
        public virtual ICollection<LocTaxa> LocTaxas { get; set; }
    }
}
