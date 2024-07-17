using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPpaVerso
{
    public short NrAnoPpa { get; set; }

    public short NrVersao { get; set; }

    public int? NrLeiPpa { get; set; }

    public short? NrAnoLeiPpa { get; set; }

    public DateTime? DtPubLeiPpa { get; set; }

    public int? NrLeiLdo { get; set; }

    public short? NrAnoLeiLdo { get; set; }

    public DateTime? DtPubLeiLdo { get; set; }

    public string? DsStatus { get; set; }

    public string? DsListaOrgaosPermitidos { get; set; }

    public DateTime? DtFinalizacao { get; set; }

    public virtual ICollection<TbPpaPrograma> TbPpaProgramas { get; set; } = new List<TbPpaPrograma>();
}
