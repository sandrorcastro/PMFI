using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicLicitacoesRepublicaco
{
    public int IdRepublicacao { get; set; }

    public int IdLicitacao { get; set; }

    public string? DsRepublicacao { get; set; }

    public DateTime? DtEdital { get; set; }

    public DateTime? DtAbertura { get; set; }

    public string? DsHoraAbertura { get; set; }

    public DateTime? DtJulgamento { get; set; }

    public string? DsHoraJulgamento { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
