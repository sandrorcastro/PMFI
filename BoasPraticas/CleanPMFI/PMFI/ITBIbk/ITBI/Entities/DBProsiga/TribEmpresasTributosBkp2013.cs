using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEmpresasTributosBkp2013
{
    public long EmprCmc { get; set; }

    public int TipoTribId { get; set; }

    public string? PeriodoIncidencia { get; set; }

    public string? GeraDividaAutomaticaNoAlvara { get; set; }

    public string IncideNosDomicilioTributario { get; set; } = null!;

    public DateTime? IsenDataIni { get; set; }

    public DateTime? IsenDataFim { get; set; }

    public string? IsenMotivo { get; set; }

    public string Isento { get; set; } = null!;

    public int? Tcid { get; set; }

    public decimal? QtdeBaseCalculo { get; set; }

    public int? ParamCalcId { get; set; }

    public decimal QtdeUnidMed { get; set; }

    public decimal QtdeUf { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? HostInclusao { get; set; }

    public int? TipoBxId { get; set; }

    public string EmprEnqSimples { get; set; } = null!;
}
