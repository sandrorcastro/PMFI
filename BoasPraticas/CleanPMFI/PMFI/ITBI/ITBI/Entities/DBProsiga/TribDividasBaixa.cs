using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribDividasBaixa
{
    public long BaiId { get; set; }

    public string BoleNossoNumero { get; set; } = null!;

    public DateTime? BxData { get; set; }

    /// <summary>
    /// Valor do bloqueto bancário.
    /// </summary>
    public decimal? BoleValorPago { get; set; }

    public int? ConvenioId { get; set; }

    public int? TipoBxId { get; set; }

    public string? BxorigemBaixa { get; set; }

    /// <summary>
    /// Motivo da baixa.
    /// </summary>
    public string BxMotivoBaixa { get; set; } = null!;

    public string? BxArquivo { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? Host { get; set; }

    /// <summary>
    /// Juros cobrado pelo no pagamento da guia de compensação
    /// </summary>
    public decimal BoleJurosPago { get; set; }

    /// <summary>
    /// Multa cobrada pelo banco no pagamento da guia de compensação
    /// </summary>
    public decimal BoleMultaPago { get; set; }

    public DateTime? BxDataCredito { get; set; }

    public int? BxExcluido { get; set; }

    public DateTime? BxDataExclusao { get; set; }

    public string? BxUsuarioExclusao { get; set; }

    public int? BxNrSeqArquivo { get; set; }

    public string? BxMotivoExclusao { get; set; }

    public DateTime? BxDataAlteracao { get; set; }

    public string? BxBanco { get; set; }

    public virtual TribBoleto BoleNossoNumeroNavigation { get; set; } = null!;

    public virtual ConvenioBanco? Convenio { get; set; }

    public virtual ICollection<TribDividasBaixaBoleto> TribDividasBaixaBoletos { get; set; } = new List<TribDividasBaixaBoleto>();
}
