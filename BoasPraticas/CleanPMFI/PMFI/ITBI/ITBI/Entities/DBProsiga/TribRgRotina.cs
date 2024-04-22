using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribRgRotina
{
    public int IdRotina { get; set; }

    public string? NmIdentificador { get; set; }

    public int? IdRegra { get; set; }

    public virtual ICollection<TribRgFiltro> IdFiltros { get; set; } = new List<TribRgFiltro>();
}
