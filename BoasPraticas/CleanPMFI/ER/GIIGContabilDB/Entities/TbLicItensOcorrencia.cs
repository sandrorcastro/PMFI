using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicItensOcorrencia
{
    public int IdImpugnacao { get; set; }

    public int? IdLicitacao { get; set; }

    public int? NrLote { get; set; }

    public int? IdItem { get; set; }

    public int? IdPessoa { get; set; }

    public string? DsMotivo { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public string? DsTipo { get; set; }
}
