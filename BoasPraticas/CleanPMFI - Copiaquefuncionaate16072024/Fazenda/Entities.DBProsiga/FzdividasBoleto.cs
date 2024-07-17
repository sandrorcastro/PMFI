using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FzdividasBoleto
{
    public string BoleNossoNumero { get; set; } = null!;

    public long DivId { get; set; }

    /// <summary>
    /// Valor do bloqueto bancário.
    /// </summary>
    public decimal? DivValorPrinc { get; set; }

    /// <summary>
    /// Valor do desconto do boleto bancário.
    /// </summary>
    public decimal DivValorDesconto { get; set; }

    public decimal? DivValorJuros { get; set; }

    public decimal? DivValorMulta { get; set; }

    public decimal? DivValorCorrecao { get; set; }

    public DateTime? DivVenc { get; set; }

    public decimal? DiBoValorDivida { get; set; }

    /// <summary>
    /// Valor pago da divida com boleto.
    /// </summary>
    public decimal? DiBoValorPagoDivida { get; set; }

    /// <summary>
    /// Valor a pagar da divida no momento do pagamento do boleto, ou seja, calcula novamente o valor pago com base na data de pagamento.
    /// </summary>
    public decimal? DiBoValorApagar { get; set; }

    public virtual Fzboleto BoleNossoNumeroNavigation { get; set; } = null!;

    public virtual Fzdivida Div { get; set; } = null!;
}
