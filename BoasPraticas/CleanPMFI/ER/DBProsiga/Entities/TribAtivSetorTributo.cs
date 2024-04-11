using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAtivSetorTributo
{
    public int AtSetId { get; set; }

    public int TipoTribId { get; set; }

    /// <summary>
    /// Incide Mensal/Anual
    /// </summary>
    public string? PeriodoIncidencia { get; set; }

    /// <summary>
    /// Incide no Alvara Inicial/Renovação ou ambos
    /// </summary>
    public string? GeraDividaAutomaticaNoAlvara { get; set; }

    /// <summary>
    /// Informa se o tributo incide nas Empresas Não Estabelecidas
    /// </summary>
    public string IncideNosDomicilioTributario { get; set; } = null!;

    public int Tcid { get; set; }

    /// <summary>
    /// Quantidade UF para este tributo dentro da atividade
    /// </summary>
    public decimal QtdeUf { get; set; }

    public int? UnMedId { get; set; }

    public virtual TribAtivSetor AtSet { get; set; } = null!;

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;
}
