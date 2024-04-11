using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscOrdemServicoOcorrencia
{
    public int FisOsocId { get; set; }

    public int FiscOsid { get; set; }

    public DateTime? FisOsocData { get; set; }

    public string? FisOsocDescricao { get; set; }

    public int? TipoOcorId { get; set; }

    public int? FiscalId { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public virtual TribFiscOrdemServico FiscOs { get; set; } = null!;

    public virtual TribFiscFiscai? Fiscal { get; set; }

    public virtual TribFiscTipoOcorrencium? TipoOcor { get; set; }
}
