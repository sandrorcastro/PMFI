using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribDividasImo
    {
        public TribDividasImo()
        {
            SimaminscricaoEmDividaAtivas = new HashSet<SimaminscricaoEmDividaAtiva>();
            TribAdvertenciasDivs = new HashSet<TribAdvertenciasDiv>();
            TribAlvaraConstrucaoDividasImoveis = new HashSet<TribAlvaraConstrucaoDividasImovei>();
            TribBaixaMovimentos = new HashSet<TribBaixaMovimento>();
            TribBoletosDivida = new HashSet<TribBoletosDivida>();
            TribComposicaoDivImos = new HashSet<TribComposicaoDivImo>();
            TribDepositoJudicialBaixas = new HashSet<TribDepositoJudicialBaixa>();
            TribDepositoJudicials = new HashSet<TribDepositoJudicial>();
            TribDividasImoEditals = new HashSet<TribDividasImoEdital>();
            TribEditalLancDivida = new HashSet<TribEditalLancDivida>();
            TribEstornoPagamentos = new HashSet<TribEstornoPagamento>();
            TribHonorariosDivida = new HashSet<TribHonorariosDivida>();
            TribHonorariosSemCda = new HashSet<TribHonorariosSemCdum>();
            TribItbiedifs = new HashSet<TribItbiedif>();
            TribLivroDividaAtivas = new HashSet<TribLivroDividaAtiva>();
            TribNotificacaoDivida = new HashSet<TribNotificacaoDivida>();
            TribOrigemDivida = new HashSet<TribOrigemDividum>();
            TribProtestoLoteCdahistoricoSituacaoDivida = new HashSet<TribProtestoLoteCdahistoricoSituacaoDividum>();
            TribRequerimentoDivDesmembrada = new HashSet<TribRequerimentoDivDesmembradum>();
            TribRequerimentoDivOrigems = new HashSet<TribRequerimentoDivOrigem>();
            TribTapDestinos = new HashSet<TribTapDestino>();
            TribTapMapas = new HashSet<TribTapMapa>();
            TribTapOrigems = new HashSet<TribTapOrigem>();
            TribTapRescisaoDivs = new HashSet<TribTapRescisaoDiv>();
            TribTransfDividasDestinos = new HashSet<TribTransfDividasDestino>();
            TribTransfDividasOrigems = new HashSet<TribTransfDividasOrigem>();
            Cmprocs = new HashSet<TribCmprocesso>();
            IdIsencaos = new HashSet<TribEdificacoesInsencoesMinhaCasa>();
            IdIsencaosNavigation = new HashSet<TribEdificacoesInsencoesMinhaCasa>();
        }

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
        public virtual TribTipoBaixa? TipoBx { get; set; }
        public virtual TribTipoTributo? TipoTrib { get; set; }
        public virtual ICollection<SimaminscricaoEmDividaAtiva> SimaminscricaoEmDividaAtivas { get; set; }
        public virtual ICollection<TribAdvertenciasDiv> TribAdvertenciasDivs { get; set; }
        public virtual ICollection<TribAlvaraConstrucaoDividasImovei> TribAlvaraConstrucaoDividasImoveis { get; set; }
        public virtual ICollection<TribBaixaMovimento> TribBaixaMovimentos { get; set; }
        public virtual ICollection<TribBoletosDivida> TribBoletosDivida { get; set; }
        public virtual ICollection<TribComposicaoDivImo> TribComposicaoDivImos { get; set; }
        public virtual ICollection<TribDepositoJudicialBaixa> TribDepositoJudicialBaixas { get; set; }
        public virtual ICollection<TribDepositoJudicial> TribDepositoJudicials { get; set; }
        public virtual ICollection<TribDividasImoEdital> TribDividasImoEditals { get; set; }
        public virtual ICollection<TribEditalLancDivida> TribEditalLancDivida { get; set; }
        public virtual ICollection<TribEstornoPagamento> TribEstornoPagamentos { get; set; }
        public virtual ICollection<TribHonorariosDivida> TribHonorariosDivida { get; set; }
        public virtual ICollection<TribHonorariosSemCdum> TribHonorariosSemCda { get; set; }
        public virtual ICollection<TribItbiedif> TribItbiedifs { get; set; }
        public virtual ICollection<TribLivroDividaAtiva> TribLivroDividaAtivas { get; set; }
        public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; }
        public virtual ICollection<TribOrigemDividum> TribOrigemDivida { get; set; }
        public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDivida { get; set; }
        public virtual ICollection<TribRequerimentoDivDesmembradum> TribRequerimentoDivDesmembrada { get; set; }
        public virtual ICollection<TribRequerimentoDivOrigem> TribRequerimentoDivOrigems { get; set; }
        public virtual ICollection<TribTapDestino> TribTapDestinos { get; set; }
        public virtual ICollection<TribTapMapa> TribTapMapas { get; set; }
        public virtual ICollection<TribTapOrigem> TribTapOrigems { get; set; }
        public virtual ICollection<TribTapRescisaoDiv> TribTapRescisaoDivs { get; set; }
        public virtual ICollection<TribTransfDividasDestino> TribTransfDividasDestinos { get; set; }
        public virtual ICollection<TribTransfDividasOrigem> TribTransfDividasOrigems { get; set; }

        public virtual ICollection<TribCmprocesso> Cmprocs { get; set; }
        public virtual ICollection<TribEdificacoesInsencoesMinhaCasa> IdIsencaos { get; set; }
        public virtual ICollection<TribEdificacoesInsencoesMinhaCasa> IdIsencaosNavigation { get; set; }
    }
}
