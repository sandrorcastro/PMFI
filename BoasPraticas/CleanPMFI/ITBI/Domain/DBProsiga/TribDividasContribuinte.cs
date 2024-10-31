using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribDividasContribuinte
    {
        public TribDividasContribuinte()
        {
            AguaDividasLeituras = new HashSet<AguaDividasLeitura>();
            SimaminscricaoEmDividaAtivas = new HashSet<SimaminscricaoEmDividaAtiva>();
            TribAdvertenciasDivs = new HashSet<TribAdvertenciasDiv>();
            TribAinfarquivoDividasLancada = new HashSet<TribAinfarquivoDividasLancada>();
            TribAlvDivida = new HashSet<TribAlvDividum>();
            TribAlvaraConstrucaoDividasContribs = new HashSet<TribAlvaraConstrucaoDividasContrib>();
            TribBaixaMovimentos = new HashSet<TribBaixaMovimento>();
            TribBoletosDivida = new HashSet<TribBoletosDivida>();
            TribComposicaoDivContribuintes = new HashSet<TribComposicaoDivContribuinte>();
            TribDepositoJudicialBaixas = new HashSet<TribDepositoJudicialBaixa>();
            TribDepositoJudicials = new HashSet<TribDepositoJudicial>();
            TribDividasContribuinteProcessos = new HashSet<TribDividasContribuinteProcesso>();
            TribEditalComprasContribuintes = new HashSet<TribEditalComprasContribuinte>();
            TribEditalLancDivida = new HashSet<TribEditalLancDivida>();
            TribEstornoPagamentos = new HashSet<TribEstornoPagamento>();
            TribFunCriancaDividaContribs = new HashSet<TribFunCriancaDividaContrib>();
            TribHonorariosDivida = new HashSet<TribHonorariosDivida>();
            TribHonorariosSemCda = new HashSet<TribHonorariosSemCdum>();
            TribItbiedifs = new HashSet<TribItbiedif>();
            TribLivroDividaAtivas = new HashSet<TribLivroDividaAtiva>();
            TribNotificacaoDivida = new HashSet<TribNotificacaoDivida>();
            TribOrigemDivida = new HashSet<TribOrigemDividum>();
            TribProtestoLoteCdahistoricoSituacaoDivida = new HashSet<TribProtestoLoteCdahistoricoSituacaoDividum>();
            TribTapDestinos = new HashSet<TribTapDestino>();
            TribTapMapas = new HashSet<TribTapMapa>();
            TribTapOrigems = new HashSet<TribTapOrigem>();
            TribTapRescisaoDivs = new HashSet<TribTapRescisaoDiv>();
            TribTransfDividasDestinos = new HashSet<TribTransfDividasDestino>();
            TribTransfDividasOrigems = new HashSet<TribTransfDividasOrigem>();
        }

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

        public virtual Contribuinte? Con { get; set; }
        public virtual ICollection<AguaDividasLeitura> AguaDividasLeituras { get; set; }
        public virtual ICollection<SimaminscricaoEmDividaAtiva> SimaminscricaoEmDividaAtivas { get; set; }
        public virtual ICollection<TribAdvertenciasDiv> TribAdvertenciasDivs { get; set; }
        public virtual ICollection<TribAinfarquivoDividasLancada> TribAinfarquivoDividasLancada { get; set; }
        public virtual ICollection<TribAlvDividum> TribAlvDivida { get; set; }
        public virtual ICollection<TribAlvaraConstrucaoDividasContrib> TribAlvaraConstrucaoDividasContribs { get; set; }
        public virtual ICollection<TribBaixaMovimento> TribBaixaMovimentos { get; set; }
        public virtual ICollection<TribBoletosDivida> TribBoletosDivida { get; set; }
        public virtual ICollection<TribComposicaoDivContribuinte> TribComposicaoDivContribuintes { get; set; }
        public virtual ICollection<TribDepositoJudicialBaixa> TribDepositoJudicialBaixas { get; set; }
        public virtual ICollection<TribDepositoJudicial> TribDepositoJudicials { get; set; }
        public virtual ICollection<TribDividasContribuinteProcesso> TribDividasContribuinteProcessos { get; set; }
        public virtual ICollection<TribEditalComprasContribuinte> TribEditalComprasContribuintes { get; set; }
        public virtual ICollection<TribEditalLancDivida> TribEditalLancDivida { get; set; }
        public virtual ICollection<TribEstornoPagamento> TribEstornoPagamentos { get; set; }
        public virtual ICollection<TribFunCriancaDividaContrib> TribFunCriancaDividaContribs { get; set; }
        public virtual ICollection<TribHonorariosDivida> TribHonorariosDivida { get; set; }
        public virtual ICollection<TribHonorariosSemCdum> TribHonorariosSemCda { get; set; }
        public virtual ICollection<TribItbiedif> TribItbiedifs { get; set; }
        public virtual ICollection<TribLivroDividaAtiva> TribLivroDividaAtivas { get; set; }
        public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; }
        public virtual ICollection<TribOrigemDividum> TribOrigemDivida { get; set; }
        public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDivida { get; set; }
        public virtual ICollection<TribTapDestino> TribTapDestinos { get; set; }
        public virtual ICollection<TribTapMapa> TribTapMapas { get; set; }
        public virtual ICollection<TribTapOrigem> TribTapOrigems { get; set; }
        public virtual ICollection<TribTapRescisaoDiv> TribTapRescisaoDivs { get; set; }
        public virtual ICollection<TribTransfDividasDestino> TribTransfDividasDestinos { get; set; }
        public virtual ICollection<TribTransfDividasOrigem> TribTransfDividasOrigems { get; set; }
    }
}
