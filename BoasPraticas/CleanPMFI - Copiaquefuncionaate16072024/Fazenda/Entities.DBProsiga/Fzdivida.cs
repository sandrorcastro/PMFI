using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Fzdivida
{
    public long DivId { get; set; }

    public int TxId { get; set; }

    public long FzveiId { get; set; }

    public DateTime? DivDtEmissao { get; set; }

    public DateTime? DivDtVenc { get; set; }

    public decimal? DivValor { get; set; }

    /// <summary>
    /// Numero da Parcela (1,2,3,4,...)
    /// </summary>
    public int? DivParcela { get; set; }

    /// <summary>
    /// Numero da Parcela (1,2,3,4,...)
    /// </summary>
    public int? DivQtdParcela { get; set; }

    public long? VistId { get; set; }

    public int? TipoBxId { get; set; }

    public string? DivObs { get; set; }

    public decimal DivValorPago { get; set; }

    public DateTime? DivDataPagto { get; set; }

    /// <summary>
    /// Controla a quantidade de vezes que a divida foi baixada.
    /// </summary>
    public int DivQtdeBaixas { get; set; }

    /// <summary>
    /// Motivo da baixa da divida.
    /// </summary>
    public string DivMotivoBaixa { get; set; } = null!;

    public long? InfrId { get; set; }

    public long? AutiId { get; set; }

    /// <summary>
    /// ID Contribuinte 
    /// </summary>
    public long? ConId { get; set; }

    public virtual FzautoInfracoesIten? FzautoInfracoesIten { get; set; }

    public virtual ICollection<FzdividasBoleto> FzdividasBoletos { get; set; } = new List<FzdividasBoleto>();

    public virtual Fzveiculo Fzvei { get; set; } = null!;

    public virtual TribTipoBaixa? TipoBx { get; set; }

    public virtual Fztaxa Tx { get; set; } = null!;

    public virtual FzvistoriaVeiculo? Vist { get; set; }
}
