using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Fzboleto
{
    public string BoleNossoNumero { get; set; } = null!;

    public DateTime? BoleData { get; set; }

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

    public string? BoleLinhaDigitavel { get; set; }

    public DateTime? BoleVencimento { get; set; }

    public string? BoleCodBarra { get; set; }

    /// <summary>
    /// Código da moeda que foi gerado o boleto.
    /// </summary>
    public string? BoleMoeda { get; set; }

    /// <summary>
    /// Data da inclusão do registro.
    /// </summary>
    public DateTime? BoleDataInclusao { get; set; }

    /// <summary>
    /// Nome do usuário que incluiu o registro.
    /// </summary>
    public string? BoleUsuarioInclusao { get; set; }

    public int? ConvenioId { get; set; }

    public string? BoleOrigem { get; set; }

    public decimal? BoleValorBoleto { get; set; }

    public virtual ICollection<Fzbaixa> Fzbaixas { get; set; } = new List<Fzbaixa>();

    public virtual ICollection<FzdividasBoleto> FzdividasBoletos { get; set; } = new List<FzdividasBoleto>();
}
