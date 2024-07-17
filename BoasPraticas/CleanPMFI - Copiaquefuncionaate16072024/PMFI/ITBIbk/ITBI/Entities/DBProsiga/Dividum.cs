using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Dividum
{
    public int? AnoDivida { get; set; }

    public int? TipoTribId { get; set; }

    public string? TipoTribNome { get; set; }

    public int? TipoBxId { get; set; }

    public string? TipoBxNome { get; set; }

    public int? TipoDivida { get; set; }

    public int? AnoGeracao { get; set; }

    public decimal? Principal { get; set; }

    public decimal? Juros { get; set; }

    public decimal? Correcao { get; set; }

    public decimal? Mda { get; set; }

    public decimal? Multa { get; set; }

    public string? Cadastro { get; set; }
}
