using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicLicitaco
    {
        public TbLicLicitaco()
        {
            TbCntContratos = new HashSet<TbCntContrato>();
            TbDspEmpenhos = new HashSet<TbDspEmpenho>();
            TbGerOrgaoOficialPublicacaos = new HashSet<TbGerOrgaoOficialPublicacao>();
            TbLicComposicoesComissaos = new HashSet<TbLicComposicoesComissao>();
            TbLicContratoOrgaoOficialPublicacaos = new HashSet<TbLicContratoOrgaoOficialPublicacao>();
            TbLicCotacaoItens = new HashSet<TbLicCotacaoIten>();
            TbLicDotacos = new HashSet<TbLicDotaco>();
            TbLicFaseLances = new HashSet<TbLicFaseLance>();
            TbLicLicitacaoTecnicas = new HashSet<TbLicLicitacaoTecnica>();
            TbLicLicitacoesAnexos = new HashSet<TbLicLicitacoesAnexo>();
            TbLicLicitacoesDocumentos = new HashSet<TbLicLicitacoesDocumento>();
            TbLicLicitacoesItens = new HashSet<TbLicLicitacoesIten>();
            TbLicLicitacoesUsuarios = new HashSet<TbLicLicitacoesUsuario>();
            TbLicMovimentacoesParecers = new HashSet<TbLicMovimentacoesParecer>();
            TbLicMovimentosSituacos = new HashSet<TbLicMovimentosSituaco>();
            TbLicPareceresAnexos = new HashSet<TbLicPareceresAnexo>();
            TbLicParticipantes = new HashSet<TbLicParticipante>();
            TbLicPesquisaCotacaoItens = new HashSet<TbLicPesquisaCotacaoIten>();
            TbLicPublicacos = new HashSet<TbLicPublicaco>();
            TbLicRecursos = new HashSet<TbLicRecurso>();
            IdAcaos = new HashSet<TbPlaAco>();
        }

        public int IdLicitacao { get; set; }
        public short IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public short? IdModalidade { get; set; }
        public short? IdNaturezaProcedimento { get; set; }
        public int? NrLicitacao { get; set; }
        public DateTime? DtEdital { get; set; }
        public DateTime? DtPublicacaoDoe { get; set; }
        public DateTime? DtAbertura { get; set; }
        public string? DsHoraAbertura { get; set; }
        public DateTime? DtJulgamento { get; set; }
        public string? DsHoraJulgamento { get; set; }
        public DateTime? DtHomologacao { get; set; }
        public short? IdLocal { get; set; }
        public string DsObjeto { get; set; } = null!;
        public short? IdTipoAvaliacao { get; set; }
        public short? NrPontuacaoMinima { get; set; }
        public short? IdClassificacaoObjeto { get; set; }
        public short? IdRegimeExecucao { get; set; }
        public short? IdEmpresaOrigem { get; set; }
        public decimal? VlMinimo { get; set; }
        public decimal? VlMaximo { get; set; }
        public string? DsClausulaProrrogacao { get; set; }
        public short? IdBemServico { get; set; }
        public string? FlVencedorPorLote { get; set; }
        public string? DsIndiceCorrecao { get; set; }
        public short? IdCondicaoPgto { get; set; }
        public short? IdPrazoEntrega { get; set; }
        public string? FlVencedorPorMaiorDesconto { get; set; }
        public short? NrPesoPreco { get; set; }
        public short? NrPesoTecnica { get; set; }
        public string? DsControleSaldo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public string? DsOrigemSaldo { get; set; }
        public string? NrEditalOrigem { get; set; }
        public short? IdSetorCompra { get; set; }
        public int? IdLicitacaoOrigem { get; set; }
        public int? IdProcesso { get; set; }
        public short? NrAnoEditalOrigem { get; set; }
        public string? FlProrrogacao { get; set; }
        public string? CdTcm { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public short? NrAnoProcesso { get; set; }
        public DateTime? DtBaseEditalTce { get; set; }
        public DateTime? DtBaseAberturaTce { get; set; }

        public virtual TbLicNaturezasProcedimento? Id { get; set; }
        public virtual TbLicEspeciesBensServico? IdBemServicoNavigation { get; set; }
        public virtual TbGerCondicoesPagamento? IdCondicaoPgtoNavigation { get; set; }
        public virtual TbGerEmpresasGoverno IdEmpresaNavigation { get; set; } = null!;
        public virtual TbLicLocai? IdLocalNavigation { get; set; }
        public virtual TbGerPrazosEntrega? IdPrazoEntregaNavigation { get; set; }
        public virtual TbDspSetoresCompra? IdSetorCompraNavigation { get; set; }
        public virtual ICollection<TbCntContrato> TbCntContratos { get; set; }
        public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; }
        public virtual ICollection<TbGerOrgaoOficialPublicacao> TbGerOrgaoOficialPublicacaos { get; set; }
        public virtual ICollection<TbLicComposicoesComissao> TbLicComposicoesComissaos { get; set; }
        public virtual ICollection<TbLicContratoOrgaoOficialPublicacao> TbLicContratoOrgaoOficialPublicacaos { get; set; }
        public virtual ICollection<TbLicCotacaoIten> TbLicCotacaoItens { get; set; }
        public virtual ICollection<TbLicDotaco> TbLicDotacos { get; set; }
        public virtual ICollection<TbLicFaseLance> TbLicFaseLances { get; set; }
        public virtual ICollection<TbLicLicitacaoTecnica> TbLicLicitacaoTecnicas { get; set; }
        public virtual ICollection<TbLicLicitacoesAnexo> TbLicLicitacoesAnexos { get; set; }
        public virtual ICollection<TbLicLicitacoesDocumento> TbLicLicitacoesDocumentos { get; set; }
        public virtual ICollection<TbLicLicitacoesIten> TbLicLicitacoesItens { get; set; }
        public virtual ICollection<TbLicLicitacoesUsuario> TbLicLicitacoesUsuarios { get; set; }
        public virtual ICollection<TbLicMovimentacoesParecer> TbLicMovimentacoesParecers { get; set; }
        public virtual ICollection<TbLicMovimentosSituaco> TbLicMovimentosSituacos { get; set; }
        public virtual ICollection<TbLicPareceresAnexo> TbLicPareceresAnexos { get; set; }
        public virtual ICollection<TbLicParticipante> TbLicParticipantes { get; set; }
        public virtual ICollection<TbLicPesquisaCotacaoIten> TbLicPesquisaCotacaoItens { get; set; }
        public virtual ICollection<TbLicPublicaco> TbLicPublicacos { get; set; }
        public virtual ICollection<TbLicRecurso> TbLicRecursos { get; set; }

        public virtual ICollection<TbPlaAco> IdAcaos { get; set; }
    }
}
