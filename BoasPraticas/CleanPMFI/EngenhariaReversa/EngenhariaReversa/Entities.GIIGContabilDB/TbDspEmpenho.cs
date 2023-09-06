using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspEmpenho
    {
        public TbDspEmpenho()
        {
            TbDspDiaria = new HashSet<TbDspDiaria>();
            TbDspEmpenhosCompoentesDespesas = new HashSet<TbDspEmpenhosCompoentesDespesa>();
            TbDspEmpenhosIntervencos = new HashSet<TbDspEmpenhosIntervenco>();
            TbDspEmpenhosItens = new HashSet<TbDspEmpenhosIten>();
            TbDspEstornosEmpenhos = new HashSet<TbDspEstornosEmpenho>();
            TbDspGps = new HashSet<TbDspGp>();
            TbDspInscricaoRestosApagars = new HashSet<TbDspInscricaoRestosApagar>();
            TbDspLiquidacos = new HashSet<TbDspLiquidaco>();
            TbDspOrdemCompras = new HashSet<TbDspOrdemCompra>();
            TbSbsSubvencaoSocialEmpenhos = new HashSet<TbSbsSubvencaoSocialEmpenho>();
            IdDoctoFiscals = new HashSet<TbDspDocumentosFiscai>();
            IdProcAdms = new HashSet<TbLicProcessosAdministrativo>();
        }

        public int IdEmpenho { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public short? NrEmpenho { get; set; }
        public DateTime? DtEmpenho { get; set; }
        public decimal? VlEmpenho { get; set; }
        public string? DsTipoEmpenho { get; set; }
        public short IdClassificacaoObjeto { get; set; }
        public int? IdNatDespesa { get; set; }
        public int? IdDotacao { get; set; }
        public int? IdRecurso { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdContrato { get; set; }
        public int? IdLicitacao { get; set; }
        public int? IdAtoContratual { get; set; }
        public string? FlContrapartida { get; set; }
        public string? DsHistorico { get; set; }
        public string? FlRateioAdiantamento { get; set; }
        public string? FlRestabelecimentoRap { get; set; }
        public short? NrMesCompetencia { get; set; }
        public short NrAnoCompetencia { get; set; }
        public short? IdCondicaoPgto { get; set; }
        public short? IdPrazoEntrega { get; set; }
        public int? IdSolicitacaoEmpenho { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public long? IdDividaFundada { get; set; }
        public int? CdLocalidade { get; set; }
        public int? CdIntervencao { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public int? IdSubAcaoTarefa { get; set; }
        public string? NrEmpenhoAnterior { get; set; }
        public short? IdEmpresaOrigem { get; set; }
        public int? IdNumeroAto { get; set; }
        public int? IdDoctoFiscal { get; set; }
        public string? NrAutoDirf { get; set; }
        public short? NrParcela { get; set; }
        public int? IdPessoaAdv { get; set; }
        public decimal? VlPagoAdv { get; set; }

        public virtual TbLicClassificacoesObjeto IdClassificacaoObjetoNavigation { get; set; } = null!;
        public virtual TbGerCondicoesPagamento? IdCondicaoPgtoNavigation { get; set; }
        public virtual TbCntContrato? IdContratoNavigation { get; set; }
        public virtual TbOrcDotaco? IdDotacaoNavigation { get; set; }
        public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }
        public virtual TbOrcNaturezasDespesa? IdNatDespesaNavigation { get; set; }
        public virtual TbGerPessoa? IdPessoaNavigation { get; set; }
        public virtual TbGerPrazosEntrega? IdPrazoEntregaNavigation { get; set; }
        public virtual TbCapRecurso? IdRecursoNavigation { get; set; }
        public virtual TbDspSolicitacoesEmpenho? IdSolicitacaoEmpenhoNavigation { get; set; }
        public virtual ICollection<TbDspDiaria> TbDspDiaria { get; set; }
        public virtual ICollection<TbDspEmpenhosCompoentesDespesa> TbDspEmpenhosCompoentesDespesas { get; set; }
        public virtual ICollection<TbDspEmpenhosIntervenco> TbDspEmpenhosIntervencos { get; set; }
        public virtual ICollection<TbDspEmpenhosIten> TbDspEmpenhosItens { get; set; }
        public virtual ICollection<TbDspEstornosEmpenho> TbDspEstornosEmpenhos { get; set; }
        public virtual ICollection<TbDspGp> TbDspGps { get; set; }
        public virtual ICollection<TbDspInscricaoRestosApagar> TbDspInscricaoRestosApagars { get; set; }
        public virtual ICollection<TbDspLiquidaco> TbDspLiquidacos { get; set; }
        public virtual ICollection<TbDspOrdemCompra> TbDspOrdemCompras { get; set; }
        public virtual ICollection<TbSbsSubvencaoSocialEmpenho> TbSbsSubvencaoSocialEmpenhos { get; set; }

        public virtual ICollection<TbDspDocumentosFiscai> IdDoctoFiscals { get; set; }
        public virtual ICollection<TbLicProcessosAdministrativo> IdProcAdms { get; set; }
    }
}
