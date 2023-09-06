using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribRgParametro
    {
        public TribRgParametro()
        {
            IdFiltros = new HashSet<TribRgFiltro>();
        }

        public long IdParametro { get; set; }
        public string? NmParametro { get; set; }
        public string? TpParametro { get; set; }
        public string? NmIdentificador { get; set; }

        public virtual ICollection<TribRgFiltro> IdFiltros { get; set; }
    }
}
