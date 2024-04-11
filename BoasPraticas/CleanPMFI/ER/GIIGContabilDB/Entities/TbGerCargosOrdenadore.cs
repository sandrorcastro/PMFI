using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerCargosOrdenadore
{
    public int IdCargoOrdenador { get; set; }

    public int? IdCargoServidor { get; set; }

    public int? IdServidor { get; set; }

    public DateTime? DtInicioAtividade { get; set; }

    public DateTime? DtFimAtividade { get; set; }

    public string? DsMotivo { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
