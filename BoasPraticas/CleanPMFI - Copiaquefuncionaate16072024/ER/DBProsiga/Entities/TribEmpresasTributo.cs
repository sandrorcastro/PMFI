using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEmpresasTributo
{
    public long EmprCmc { get; set; }

    public int TipoTribId { get; set; }

    public string? PeriodoIncidencia { get; set; }

    public string? GeraDividaAutomaticaNoAlvara { get; set; }

    /// <summary>
    /// Informa se o tributo incide nas Empresas Não Estabelecidas
    /// </summary>
    public string IncideNosDomicilioTributario { get; set; } = null!;

    public DateTime? IsenDataIni { get; set; }

    public DateTime? IsenDataFim { get; set; }

    public string? IsenMotivo { get; set; }

    /// <summary>
    /// Marca se a empresa é isenta do tributo
    /// </summary>
    public string Isento { get; set; } = null!;

    public int? Tcid { get; set; }

    /// <summary>
    /// Quantidade da base calculo
    /// </summary>
    public decimal? QtdeBaseCalculo { get; set; }

    public int? ParamCalcId { get; set; }

    /// <summary>
    /// Quantidade da Unidade de medida
    /// </summary>
    public decimal QtdeUnidMed { get; set; }

    /// <summary>
    /// Quantidade de UF para calculo do Tributo
    /// </summary>
    public decimal QtdeUf { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? HostInclusao { get; set; }

    public int? TipoBxId { get; set; }

    public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;

    public virtual TribEmpresasParamCalc? ParamCalc { get; set; }

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;

    public virtual ICollection<TribEmpresasTipoAlvaraTributo> TribEmpresasTipoAlvaraTributos { get; set; } = new List<TribEmpresasTipoAlvaraTributo>();
}
