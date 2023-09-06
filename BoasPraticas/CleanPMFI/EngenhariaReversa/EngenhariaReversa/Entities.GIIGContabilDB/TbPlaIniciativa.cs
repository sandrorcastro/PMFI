using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaIniciativa
    {
        public TbPlaIniciativa()
        {
            IdAcaos = new HashSet<TbOrcProgramasAco>();
        }

        public int IdIniciativa { get; set; }
        public string? Cdiniciativa { get; set; }
        public string? DsIniciativa { get; set; }
        public int IdObjetivo { get; set; }

        public virtual TbPlaObjetivo IdObjetivoNavigation { get; set; } = null!;

        public virtual ICollection<TbOrcProgramasAco> IdAcaos { get; set; }
    }
}
