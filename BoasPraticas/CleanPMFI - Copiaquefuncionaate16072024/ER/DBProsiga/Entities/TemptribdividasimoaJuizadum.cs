using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TemptribdividasimoaJuizadum
{
    public long ImoIddivida { get; set; }

    public long? EdificacaoId { get; set; }

    public int? ImoDivAno { get; set; }

    public int? TipoTribId { get; set; }

    public int? ImoDivSubDivida { get; set; }

    public int? ImoDivParcela { get; set; }

    public DateTime? ImoDivVencimento { get; set; }

    public DateTime? ImoDivDataGeracao { get; set; }

    public int? ImoDivTipoDivida { get; set; }

    public DateTime? ImoDivDataBloqCorrecao { get; set; }

    public DateTime? ImoDivDataBloqJuros { get; set; }

    public DateTime? ImoDivDataBloqMulta { get; set; }

    public decimal? ImoDivVlrUltimaCorrecao { get; set; }

    public DateTime? ImoDivDataUltimaCorrecao { get; set; }

    public string? ImoDivOrigemLancamento { get; set; }

    public string? ImoDivParcelaUnica { get; set; }

    public int? TipoBxId { get; set; }

    public int? ImoDivMes { get; set; }

    public DateTime? ImoDivDataBaixa { get; set; }

    public decimal ImoDivValorHistorico { get; set; }

    public decimal ImoDivValorBaixa { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? ImoDivMotivoBaixa { get; set; }

    public string? ImoDivObs { get; set; }

    public string? ImoDivTipoLancamentoIptu { get; set; }

    public short? ImoDivQtdeBaixas { get; set; }

    public long? AutoInfrId { get; set; }

    public decimal? ImoDivBxVlrJuros { get; set; }

    public decimal? ImoDivBxVlrMulta { get; set; }

    public decimal? ImoDivBxVlrCorrecao { get; set; }

    public decimal? ImoDivBxVlrDesconto { get; set; }

    public decimal? ImoDivBxVlrMultaDa { get; set; }

    public decimal? ImoDivDescDivida { get; set; }

    public string? ImoDivSaiBoleto { get; set; }

    public short? Idmoeda { get; set; }

    public int? EdiId { get; set; }

    public decimal ImoDivValor { get; set; }

    public decimal? Multa { get; set; }

    public decimal? Juros { get; set; }

    public decimal? Correcao { get; set; }

    public decimal? MultaDividaAtiva { get; set; }

    public DateTime? DataCalculo { get; set; }

    public decimal? ImoDivValorBkp { get; set; }

    public bool? ImoDivExcluido { get; set; }
}
