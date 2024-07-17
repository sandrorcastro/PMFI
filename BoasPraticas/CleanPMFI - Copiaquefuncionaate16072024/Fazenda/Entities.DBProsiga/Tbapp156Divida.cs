using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbapp156Divida
{
    public string? Cpfcnpj { get; set; }

    public string? Tipo { get; set; }

    public int? TipoTribId { get; set; }

    public string? Tributo { get; set; }

    public int? Ano { get; set; }

    public int? Parcela { get; set; }

    public decimal? ValorPrincipal { get; set; }

    public DateTime? Vencimento { get; set; }

    public int? Iddivida { get; set; }

    public byte? Tipocadastro { get; set; }

    public decimal? ValorAcrescimos { get; set; }

    public string? TipoDivida { get; set; }

    public string? Detalhes { get; set; }

    public bool? Cotaunica { get; set; }

    public int? Idlei { get; set; }
}
