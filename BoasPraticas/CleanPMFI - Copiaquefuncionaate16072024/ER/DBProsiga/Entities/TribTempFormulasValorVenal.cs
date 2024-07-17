using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTempFormulasValorVenal
{
    public int Idformulas { get; set; }

    public long? EdificacaoId { get; set; }

    public string? FormulaValorVenal { get; set; }

    public string? CalculoValorVenal { get; set; }

    public string? FormulaValorVenalIptu { get; set; }

    public string? CalculoValorVenalIptu { get; set; }

    public string? InscricaoImobiliaria { get; set; }

    /// <summary>
    /// I = Imovel, E = Englobado, T = Terreno
    /// </summary>
    public string? TipoCaracteristica { get; set; }

    public long? EdificacaoIdenglobado { get; set; }
}
