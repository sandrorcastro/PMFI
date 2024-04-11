using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicTipoCrcf
{
    public short IdTipoCrcf { get; set; }

    public string? NmTipoCrcf { get; set; }

    public int? IdTexto { get; set; }

    public bool? FlNumeraAnual { get; set; }

    public string? DsSigla { get; set; }

    public bool? FlSomenteDoctosVinculados { get; set; }

    public bool? FlMostrarNumDocto { get; set; }

    public string? NmRelatorio { get; set; }

    public virtual ICollection<TbLicDoctosCrcf> IdDocCrcfs { get; set; } = new List<TbLicDoctosCrcf>();
}
