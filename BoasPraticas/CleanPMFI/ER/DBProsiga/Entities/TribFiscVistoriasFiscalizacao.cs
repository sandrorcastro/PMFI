using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscVistoriasFiscalizacao
{
    public int VistFiscId { get; set; }

    public int? FiscOfid { get; set; }

    public DateTime? VistFiscDataInclusao { get; set; }

    public int? TipoVistId { get; set; }

    public string? VistFiscObs { get; set; }

    public DateTime? VistFiscDataIni { get; set; }

    public DateTime? VistFiscDataFim { get; set; }

    public string? VistFiscNotaIni { get; set; }

    public string? VistFiscNotaFim { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? VistFiscTipoNf { get; set; }
}
