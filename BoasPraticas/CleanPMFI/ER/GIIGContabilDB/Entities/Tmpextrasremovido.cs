using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Tmpextrasremovido
{
    public int IdEstorno { get; set; }

    public int IdDespesa { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public short? NrSequencia { get; set; }

    public DateTime? DtEstorno { get; set; }

    public decimal? VlEstorno { get; set; }

    public string? DsMotivo { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
