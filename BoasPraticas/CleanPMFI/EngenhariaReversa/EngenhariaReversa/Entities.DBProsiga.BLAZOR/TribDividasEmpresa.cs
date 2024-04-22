using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribDividasEmpresa
    {
        public TribDividasEmpresa()
        {
            FissCompDivida = new HashSet<FissCompDividum>();
            FissDocFiscaisDivida = new HashSet<FissDocFiscaisDividum>();
            SimaminscricaoEmDividaAtivas = new HashSet<SimaminscricaoEmDividaAtiva>();
            TribAdvertenciasDivs = new HashSet<TribAdvertenciasDiv>();
            TribAinfarquivoDividasLancada = new HashSet<TribAinfarquivoDividasLancada>();
            TribAlvaraRenovacaoDivida = new HashSet<TribAlvaraRenovacaoDivida>();
            TribBaixaMovimentos = new HashSet<TribBaixaMovimento>();
            TribBoletosDivida = new HashSet<TribBoletosDivida>();
            TribComposicaoDivEmpresas = new HashSet<TribComposicaoDivEmpresa>();
            TribDepositoJudicialBaixas = new HashSet<TribDepositoJudicialBaixa>();
            TribDepositoJudicials = new HashSet<TribDepositoJudicial>();
            TribEditalLancDivida = new HashSet<TribEditalLancDivida>();
            TribEstornoPagamentos = new HashSet<TribEstornoPagamento>();
            TribHonorariosDivida = new HashSet<TribHonorariosDivida>();
            TribHonorariosSemCda = new HashSet<TribHonorariosSemCdum>();
            TribLivroDividaAtivas = new HashSet<TribLivroDividaAtiva>();
            TribNotificacaoDivida = new HashSet<TribNotificacaoDivida>();
            TribOrigemDivida = new HashSet<TribOrigemDividum>();
            TribProtestoLoteCdahistoricoSituacaoDivida = new HashSet<TribProtestoLoteCdahistoricoSituacaoDividum>();
            TribSndivida = new HashSet<TribSndivida>();
            TribTapDestinos = new HashSet<TribTapDestino>();
            TribTapMapas = new HashSet<TribTapMapa>();
            TribTapOrigems = new HashSet<TribTapOrigem>();
            TribTapRescisaoDivs = new HashSet<TribTapRescisaoDiv>();
            TribTransfDividasDestinos = new HashSet<TribTransfDividasDestino>();
            TribTransfDividasOrigems = new HashSet<TribTransfDividasOrigem>();
        }

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
        public virtual TribTipoTributo? TipoTrib { get; set; }
        public virtual ICollection<FissCompDividum> FissCompDivida { get; set; }
        public virtual ICollection<FissDocFiscaisDividum> FissDocFiscaisDivida { get; set; }
        public virtual ICollection<SimaminscricaoEmDividaAtiva> SimaminscricaoEmDividaAtivas { get; set; }
        public virtual ICollection<TribAdvertenciasDiv> TribAdvertenciasDivs { get; set; }
        public virtual ICollection<TribAinfarquivoDividasLancada> TribAinfarquivoDividasLancada { get; set; }
        public virtual ICollection<TribAlvaraRenovacaoDivida> TribAlvaraRenovacaoDivida { get; set; }
        public virtual ICollection<TribBaixaMovimento> TribBaixaMovimentos { get; set; }
        public virtual ICollection<TribBoletosDivida> TribBoletosDivida { get; set; }
        public virtual ICollection<TribComposicaoDivEmpresa> TribComposicaoDivEmpresas { get; set; }
        public virtual ICollection<TribDepositoJudicialBaixa> TribDepositoJudicialBaixas { get; set; }
        public virtual ICollection<TribDepositoJudicial> TribDepositoJudicials { get; set; }
        public virtual ICollection<TribEditalLancDivida> TribEditalLancDivida { get; set; }
        public virtual ICollection<TribEstornoPagamento> TribEstornoPagamentos { get; set; }
        public virtual ICollection<TribHonorariosDivida> TribHonorariosDivida { get; set; }
        public virtual ICollection<TribHonorariosSemCdum> TribHonorariosSemCda { get; set; }
        public virtual ICollection<TribLivroDividaAtiva> TribLivroDividaAtivas { get; set; }
        public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; }
        public virtual ICollection<TribOrigemDividum> TribOrigemDivida { get; set; }
        public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDivida { get; set; }
        public virtual ICollection<TribSndivida> TribSndivida { get; set; }
        public virtual ICollection<TribTapDestino> TribTapDestinos { get; set; }
        public virtual ICollection<TribTapMapa> TribTapMapas { get; set; }
        public virtual ICollection<TribTapOrigem> TribTapOrigems { get; set; }
        public virtual ICollection<TribTapRescisaoDiv> TribTapRescisaoDivs { get; set; }
        public virtual ICollection<TribTransfDividasDestino> TribTransfDividasDestinos { get; set; }
        public virtual ICollection<TribTransfDividasOrigem> TribTransfDividasOrigems { get; set; }
    }
}
