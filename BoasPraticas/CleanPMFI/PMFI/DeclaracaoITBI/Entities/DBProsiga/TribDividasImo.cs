using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribDividasImo
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

    /// <summary>
    /// Data da baixa da dívida.
    /// </summary>
    public DateTime? ImoDivDataBaixa { get; set; }

    public decimal ImoDivValorHistorico { get; set; }

    /// <summary>
    /// Valor Baixado da divida
    /// </summary>
    public decimal ImoDivValorBaixa { get; set; }

    public string? UsuarioInclusao { get; set; }

    /// <summary>
    /// Motivo da baixa, gravada por trigger no movimento de baixa e tambem pelos formulários que baixa dividas sem movimento de baixa (ex.: isenção de dividas).
    /// </summary>
    public string? ImoDivMotivoBaixa { get; set; }

    /// <summary>
    /// Observações sobre o lançamento da dívida.
    /// </summary>
    public string? ImoDivObs { get; set; }

    public string? ImoDivTipoLancamentoIptu { get; set; }

    public short? ImoDivQtdeBaixas { get; set; }

    /// <summary>
    /// Código do auto de infração.
    /// </summary>
    public long? AutoInfrId { get; set; }

    public decimal? ImoDivBxVlrJuros { get; set; }

    public decimal? ImoDivBxVlrMulta { get; set; }

    public decimal? ImoDivBxVlrCorrecao { get; set; }

    public decimal? ImoDivBxVlrDesconto { get; set; }

    public decimal? ImoDivBxVlrMultaDa { get; set; }

    /// <summary>
    /// Desconto individualizado da dívida.
    /// </summary>
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

    public virtual TribAutosInfracao? AutoInfr { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }

    public virtual TribTipoDividum? ImoDivTipoDividaNavigation { get; set; }

    public virtual ICollection<SimaminscricaoEmDividaAtiva> SimaminscricaoEmDividaAtivas { get; set; } = new List<SimaminscricaoEmDividaAtiva>();

    public virtual TribTipoBaixa? TipoBx { get; set; }

    public virtual TribTipoTributo? TipoTrib { get; set; }

    public virtual ICollection<TribAdvertenciasDiv> TribAdvertenciasDivs { get; set; } = new List<TribAdvertenciasDiv>();

    public virtual ICollection<TribAlvaraConstrucaoDividasImovei> TribAlvaraConstrucaoDividasImoveis { get; set; } = new List<TribAlvaraConstrucaoDividasImovei>();

    public virtual ICollection<TribBaixaMovimento> TribBaixaMovimentos { get; set; } = new List<TribBaixaMovimento>();

    public virtual ICollection<TribBoletosDivida> TribBoletosDivida { get; set; } = new List<TribBoletosDivida>();

    public virtual ICollection<TribComposicaoDivImo> TribComposicaoDivImos { get; set; } = new List<TribComposicaoDivImo>();

    public virtual ICollection<TribDepositoJudicialBaixa> TribDepositoJudicialBaixas { get; set; } = new List<TribDepositoJudicialBaixa>();

    public virtual ICollection<TribDepositoJudicial> TribDepositoJudicials { get; set; } = new List<TribDepositoJudicial>();

    public virtual ICollection<TribDividasImoEdital> TribDividasImoEditals { get; set; } = new List<TribDividasImoEdital>();

    public virtual ICollection<TribEditalLancDivida> TribEditalLancDivida { get; set; } = new List<TribEditalLancDivida>();

    public virtual ICollection<TribEstornoPagamento> TribEstornoPagamentos { get; set; } = new List<TribEstornoPagamento>();

    public virtual ICollection<TribHonorariosDivida> TribHonorariosDivida { get; set; } = new List<TribHonorariosDivida>();

    public virtual ICollection<TribHonorariosSemCdum> TribHonorariosSemCda { get; set; } = new List<TribHonorariosSemCdum>();

    public virtual ICollection<TribItbiedif> TribItbiedifs { get; set; } = new List<TribItbiedif>();

    public virtual ICollection<TribLivroDividaAtiva> TribLivroDividaAtivas { get; set; } = new List<TribLivroDividaAtiva>();

    public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; } = new List<TribNotificacaoDivida>();

    public virtual ICollection<TribOrigemDividum> TribOrigemDivida { get; set; } = new List<TribOrigemDividum>();

    public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDivida { get; set; } = new List<TribProtestoLoteCdahistoricoSituacaoDividum>();

    public virtual ICollection<TribRequerimentoDivDesmembradum> TribRequerimentoDivDesmembrada { get; set; } = new List<TribRequerimentoDivDesmembradum>();

    public virtual ICollection<TribRequerimentoDivOrigem> TribRequerimentoDivOrigems { get; set; } = new List<TribRequerimentoDivOrigem>();

    public virtual ICollection<TribTapDestino> TribTapDestinos { get; set; } = new List<TribTapDestino>();

    public virtual ICollection<TribTapMapa> TribTapMapas { get; set; } = new List<TribTapMapa>();

    public virtual ICollection<TribTapOrigem> TribTapOrigems { get; set; } = new List<TribTapOrigem>();

    public virtual ICollection<TribTapRescisaoDiv> TribTapRescisaoDivs { get; set; } = new List<TribTapRescisaoDiv>();

    public virtual ICollection<TribTransfDividasDestino> TribTransfDividasDestinos { get; set; } = new List<TribTransfDividasDestino>();

    public virtual ICollection<TribTransfDividasOrigem> TribTransfDividasOrigems { get; set; } = new List<TribTransfDividasOrigem>();

    public virtual ICollection<TribCmprocesso> Cmprocs { get; set; } = new List<TribCmprocesso>();

    public virtual ICollection<TribEdificacoesInsencoesMinhaCasa> IdIsencaos { get; set; } = new List<TribEdificacoesInsencoesMinhaCasa>();

    public virtual ICollection<TribEdificacoesInsencoesMinhaCasa> IdIsencaosNavigation { get; set; } = new List<TribEdificacoesInsencoesMinhaCasa>();
}
