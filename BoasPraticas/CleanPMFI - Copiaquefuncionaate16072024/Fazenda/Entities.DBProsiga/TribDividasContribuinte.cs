using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribDividasContribuinte
{
    public long ConIddivida { get; set; }

    public long? ConId { get; set; }

    public int? ConDivAno { get; set; }

    public int? TipoTribId { get; set; }

    public int? ConDivSubDivida { get; set; }

    public int? ConDivParcela { get; set; }

    public DateTime? ConDivVencimento { get; set; }

    public DateTime? ConDivDataGeracao { get; set; }

    public int? ConDivTipoDivida { get; set; }

    public DateTime? ConDivDataBloqCorrecao { get; set; }

    public DateTime? ConDivDataBloqJuros { get; set; }

    public DateTime? ConDivDataBloqMulta { get; set; }

    public decimal? ConDivVlrUltimaCorrecao { get; set; }

    public DateTime? ConDivDataUltimaCorrecao { get; set; }

    public string? ConDivOrigemLancamento { get; set; }

    public string? ConDivParcelaUnica { get; set; }

    public int? TipoBxId { get; set; }

    public int? ConDivMes { get; set; }

    /// <summary>
    /// Data da baixa da dívida.
    /// </summary>
    public DateTime? ConDivDataBaixa { get; set; }

    public decimal ConDivValorHistorico { get; set; }

    /// <summary>
    /// Valor Baixado da divida
    /// </summary>
    public decimal ConDivValorBaixa { get; set; }

    /// <summary>
    /// Motivo da baixa, gravada por trigger no movimento de baixa e tambem pelos formulários que baixa dividas sem movimento de baixa (ex.: isenção de dividas).
    /// </summary>
    public string? ConDivMotivoBaixa { get; set; }

    public short? ConDivQtdeBaixas { get; set; }

    /// <summary>
    /// Código do auto de infração.
    /// </summary>
    public long? AutoInfrId { get; set; }

    public string? UsuarioInclusao { get; set; }

    public decimal? ConDivBxVlrJuros { get; set; }

    public decimal? ConDivBxVlrMulta { get; set; }

    public decimal? ConDivBxVlrCorrecao { get; set; }

    public decimal? ConDivBxVlrDesconto { get; set; }

    public decimal? ConDivBxVlrMultaDa { get; set; }

    /// <summary>
    /// Observações sobre o lançamento da dívida.
    /// </summary>
    public string? ConDivObs { get; set; }

    public decimal? ConDivDescDivida { get; set; }

    public string? ConDivSaiBoleto { get; set; }

    public short? Idmoeda { get; set; }

    public int? EdiId { get; set; }

    public decimal ConDivValor { get; set; }

    public decimal? Multa { get; set; }

    public decimal? Juros { get; set; }

    public decimal? Correcao { get; set; }

    public decimal? MultaDividaAtiva { get; set; }

    public DateTime? DataCalculo { get; set; }

    public decimal? ConDivValorBkp { get; set; }

    public bool? ConDivExcluido { get; set; }

    public virtual ICollection<AguaDividasLeitura> AguaDividasLeituras { get; set; } = new List<AguaDividasLeitura>();

    public virtual Contribuinte? Con { get; set; }

    public virtual ICollection<SimaminscricaoEmDividaAtiva> SimaminscricaoEmDividaAtivas { get; set; } = new List<SimaminscricaoEmDividaAtiva>();

    public virtual ICollection<TribAdvertenciasDiv> TribAdvertenciasDivs { get; set; } = new List<TribAdvertenciasDiv>();

    public virtual ICollection<TribAinfarquivoDividasLancada> TribAinfarquivoDividasLancada { get; set; } = new List<TribAinfarquivoDividasLancada>();

    public virtual ICollection<TribAlvDividum> TribAlvDivida { get; set; } = new List<TribAlvDividum>();

    public virtual ICollection<TribAlvaraConstrucaoDividasContrib> TribAlvaraConstrucaoDividasContribs { get; set; } = new List<TribAlvaraConstrucaoDividasContrib>();

    public virtual ICollection<TribBaixaMovimento> TribBaixaMovimentos { get; set; } = new List<TribBaixaMovimento>();

    public virtual ICollection<TribBoletosDivida> TribBoletosDivida { get; set; } = new List<TribBoletosDivida>();

    public virtual ICollection<TribComposicaoDivContribuinte> TribComposicaoDivContribuintes { get; set; } = new List<TribComposicaoDivContribuinte>();

    public virtual ICollection<TribDepositoJudicialBaixa> TribDepositoJudicialBaixas { get; set; } = new List<TribDepositoJudicialBaixa>();

    public virtual ICollection<TribDepositoJudicial> TribDepositoJudicials { get; set; } = new List<TribDepositoJudicial>();

    public virtual ICollection<TribDividasContribuinteProcesso> TribDividasContribuinteProcessos { get; set; } = new List<TribDividasContribuinteProcesso>();

    public virtual ICollection<TribEditalComprasContribuinte> TribEditalComprasContribuintes { get; set; } = new List<TribEditalComprasContribuinte>();

    public virtual ICollection<TribEditalLancDivida> TribEditalLancDivida { get; set; } = new List<TribEditalLancDivida>();

    public virtual ICollection<TribEstornoPagamento> TribEstornoPagamentos { get; set; } = new List<TribEstornoPagamento>();

    public virtual ICollection<TribFunCriancaDividaContrib> TribFunCriancaDividaContribs { get; set; } = new List<TribFunCriancaDividaContrib>();

    public virtual ICollection<TribHonorariosDivida> TribHonorariosDivida { get; set; } = new List<TribHonorariosDivida>();

    public virtual ICollection<TribHonorariosSemCdum> TribHonorariosSemCda { get; set; } = new List<TribHonorariosSemCdum>();

    public virtual ICollection<TribItbiedif> TribItbiedifs { get; set; } = new List<TribItbiedif>();

    public virtual ICollection<TribLivroDividaAtiva> TribLivroDividaAtivas { get; set; } = new List<TribLivroDividaAtiva>();

    public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; } = new List<TribNotificacaoDivida>();

    public virtual ICollection<TribOrigemDividum> TribOrigemDivida { get; set; } = new List<TribOrigemDividum>();

    public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDivida { get; set; } = new List<TribProtestoLoteCdahistoricoSituacaoDividum>();

    public virtual ICollection<TribTapDestino> TribTapDestinos { get; set; } = new List<TribTapDestino>();

    public virtual ICollection<TribTapMapa> TribTapMapas { get; set; } = new List<TribTapMapa>();

    public virtual ICollection<TribTapOrigem> TribTapOrigems { get; set; } = new List<TribTapOrigem>();

    public virtual ICollection<TribTapRescisaoDiv> TribTapRescisaoDivs { get; set; } = new List<TribTapRescisaoDiv>();

    public virtual ICollection<TribTransfDividasDestino> TribTransfDividasDestinos { get; set; } = new List<TribTransfDividasDestino>();

    public virtual ICollection<TribTransfDividasOrigem> TribTransfDividasOrigems { get; set; } = new List<TribTransfDividasOrigem>();
}
