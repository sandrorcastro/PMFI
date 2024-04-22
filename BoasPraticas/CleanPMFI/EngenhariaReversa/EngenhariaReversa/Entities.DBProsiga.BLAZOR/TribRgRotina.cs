using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribRgRotina
    {
        public TribRgRotina()
        {
            IdFiltros = new HashSet<TribRgFiltro>();
        }

        public int IdRotina { get; set; }
        public string? NmIdentificador { get; set; }
        public int? IdRegra { get; set; }

        public virtual ICollection<TribRgFiltro> IdFiltros { get; set; }
    }
}
