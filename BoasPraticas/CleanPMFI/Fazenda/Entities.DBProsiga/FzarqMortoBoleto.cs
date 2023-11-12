using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FzarqMortoBoleto
{
    public int Id { get; set; }

    public string? NossoNumero { get; set; }

    public long? FzveiId { get; set; }

    public long? VistId { get; set; }

    public int? TxId { get; set; }

    public DateTime? DivDtVenc { get; set; }

    public string? DataVencBoleto { get; set; }

    public DateTime? DataBoleto { get; set; }

    /// <summary>
    /// Valor do bloqueto bancário.
    /// </summary>
    public decimal? BoleValorPrinc { get; set; }

    /// <summary>
    /// Valor do desconto do boleto bancário.
    /// </summary>
    public decimal? BoleValorDesconto { get; set; }

    public decimal? BoleValorJuros { get; set; }

    public decimal? BoleValorMulta { get; set; }

    public decimal? BoleValorCorrecao { get; set; }

    public long? InfrId { get; set; }

    public long? AutiId { get; set; }
}
