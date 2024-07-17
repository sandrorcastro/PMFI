using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribDividasEmpresa
{
    public long DivEmpId { get; set; }

    public long? EmprCmc { get; set; }

    public int? EmprDivAno { get; set; }

    public int? EmprDivMes { get; set; }

    public int? TipoTribId { get; set; }

    public int? EmprDivSubDivida { get; set; }

    public int? EmprDivParcela { get; set; }

    public DateTime? EmprDivVencimento { get; set; }

    public decimal? EmprDivVlrTributavel { get; set; }

    public decimal? EmprDivAliquota { get; set; }

    public string? EmprDivTipoMoeda { get; set; }

    public DateTime? EmprDivDataGeracao { get; set; }

    public int? EmprDivTipoDivida { get; set; }

    public DateTime? EmprDivDataBloqCorrecao { get; set; }

    public DateTime? EmprDivDataBloqJuros { get; set; }

    public DateTime? EmprDivDataBloqMulta { get; set; }

    public decimal? EmprDivVlrUltCorrecao { get; set; }

    public DateTime? EmprDivDataUltCorrecao { get; set; }

    public string? EmprDivOrigemLancamento { get; set; }

    public string? EmprDivParcelaUnica { get; set; }

    public int? TipoBxId { get; set; }

    public decimal EmprDivValorBaixa { get; set; }

    public string? EmprDivMotivoBaixa { get; set; }

    /// <summary>
    /// Data da baixa da dívida.
    /// </summary>
    public DateTime? EmprDivDataBaixa { get; set; }

    public string? UsuarioInclusao { get; set; }

    public short? EmprDivQtdeBaixas { get; set; }

    /// <summary>
    /// Código do auto de infração.
    /// </summary>
    public long? AutoInfrId { get; set; }

    public decimal? EmprDivBxVlrJuros { get; set; }

    public decimal? EmprDivBxVlrMulta { get; set; }

    public decimal? EmprDivBxVlrCorrecao { get; set; }

    public decimal? EmprDivBxVlrDesconto { get; set; }

    public decimal? EmprDivBxVlrMultaDa { get; set; }

    /// <summary>
    /// Observações sobre o lançamento da dívida.
    /// </summary>
    public string? EmprDivObs { get; set; }

    public decimal? ConDivDescDivida { get; set; }

    public string? EmprDivSaiBoleto { get; set; }

    public short? Idmoeda { get; set; }

    /// <summary>
    /// Criado para atender o modelo das moedas
    /// </summary>
    public decimal EmprDivValorHistorico { get; set; }

    public int? EdiId { get; set; }

    public decimal EmprDivValor { get; set; }

    public decimal? Multa { get; set; }

    public decimal? Juros { get; set; }

    public decimal? Correcao { get; set; }

    public decimal? MultaDividaAtiva { get; set; }

    public DateTime? DataCalculo { get; set; }

    public decimal? EmprDivValorBkp { get; set; }

    public bool? EmprDivExcluido { get; set; }

    public DateTime? EmprDataBloqueioSelic { get; set; }

    public virtual TribEmpresa? EmprCmcNavigation { get; set; }

    public virtual ICollection<FissCompDividum> FissCompDivida { get; set; } = new List<FissCompDividum>();

    public virtual ICollection<FissDocFiscaisDividum> FissDocFiscaisDivida { get; set; } = new List<FissDocFiscaisDividum>();

    public virtual ICollection<SimaminscricaoEmDividaAtiva> SimaminscricaoEmDividaAtivas { get; set; } = new List<SimaminscricaoEmDividaAtiva>();

    public virtual TribTipoTributo? TipoTrib { get; set; }

    public virtual ICollection<TribAdvertenciasDiv> TribAdvertenciasDivs { get; set; } = new List<TribAdvertenciasDiv>();

    public virtual ICollection<TribAinfarquivoDividasLancada> TribAinfarquivoDividasLancada { get; set; } = new List<TribAinfarquivoDividasLancada>();

    public virtual ICollection<TribAlvaraRenovacaoDivida> TribAlvaraRenovacaoDivida { get; set; } = new List<TribAlvaraRenovacaoDivida>();

    public virtual ICollection<TribBaixaMovimento> TribBaixaMovimentos { get; set; } = new List<TribBaixaMovimento>();

    public virtual ICollection<TribBoletosDivida> TribBoletosDivida { get; set; } = new List<TribBoletosDivida>();

    public virtual ICollection<TribComposicaoDivEmpresa> TribComposicaoDivEmpresas { get; set; } = new List<TribComposicaoDivEmpresa>();

    public virtual ICollection<TribDepositoJudicialBaixa> TribDepositoJudicialBaixas { get; set; } = new List<TribDepositoJudicialBaixa>();

    public virtual ICollection<TribDepositoJudicial> TribDepositoJudicials { get; set; } = new List<TribDepositoJudicial>();

    public virtual ICollection<TribEditalLancDivida> TribEditalLancDivida { get; set; } = new List<TribEditalLancDivida>();

    public virtual ICollection<TribEstornoPagamento> TribEstornoPagamentos { get; set; } = new List<TribEstornoPagamento>();

    public virtual ICollection<TribHonorariosDivida> TribHonorariosDivida { get; set; } = new List<TribHonorariosDivida>();

    public virtual ICollection<TribHonorariosSemCdum> TribHonorariosSemCda { get; set; } = new List<TribHonorariosSemCdum>();

    public virtual ICollection<TribLivroDividaAtiva> TribLivroDividaAtivas { get; set; } = new List<TribLivroDividaAtiva>();

    public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; } = new List<TribNotificacaoDivida>();

    public virtual ICollection<TribOrigemDividum> TribOrigemDivida { get; set; } = new List<TribOrigemDividum>();

    public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDivida { get; set; } = new List<TribProtestoLoteCdahistoricoSituacaoDividum>();

    public virtual ICollection<TribSndivida> TribSndivida { get; set; } = new List<TribSndivida>();

    public virtual ICollection<TribTapDestino> TribTapDestinos { get; set; } = new List<TribTapDestino>();

    public virtual ICollection<TribTapMapa> TribTapMapas { get; set; } = new List<TribTapMapa>();

    public virtual ICollection<TribTapOrigem> TribTapOrigems { get; set; } = new List<TribTapOrigem>();

    public virtual ICollection<TribTapRescisaoDiv> TribTapRescisaoDivs { get; set; } = new List<TribTapRescisaoDiv>();

    public virtual ICollection<TribTransfDividasDestino> TribTransfDividasDestinos { get; set; } = new List<TribTransfDividasDestino>();

    public virtual ICollection<TribTransfDividasOrigem> TribTransfDividasOrigems { get; set; } = new List<TribTransfDividasOrigem>();
}
