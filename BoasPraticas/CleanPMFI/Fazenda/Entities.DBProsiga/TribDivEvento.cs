using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribDivEvento
{
    public int IdEvento { get; set; }

    public long? ConIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ImoIddivida { get; set; }

    public DateTime? DtEvento { get; set; }

    public int? IdLeiAto { get; set; }

    public string? TpEvento { get; set; }

    public string? DsAcao { get; set; }

    public decimal? VlEvento { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public bool? FlProcessado { get; set; }

    public DateTime? DtProcessamento { get; set; }

    public string? DsErro { get; set; }

    public string? NrGuid { get; set; }

    public string? NmObjeto { get; set; }

    public long? IdObjeto { get; set; }
}
