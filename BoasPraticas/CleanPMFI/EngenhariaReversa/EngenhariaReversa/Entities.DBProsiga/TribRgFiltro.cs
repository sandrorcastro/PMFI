using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribRgFiltro
    {
        public TribRgFiltro()
        {
            IdParametros = new HashSet<TribRgParametro>();
            IdRotinas = new HashSet<TribRgRotina>();
        }

        public int IdFiltro { get; set; }
        public string? NmFiltro { get; set; }
        public string? TpFiltro { get; set; }
        public long? IdRegra { get; set; }

        public virtual ICollection<TribRgParametro> IdParametros { get; set; }
        public virtual ICollection<TribRgRotina> IdRotinas { get; set; }
    }
}
