using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicLicitaco
{
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

    public virtual ICollection<TbCntContrato> TbCntContratos { get; set; } = new List<TbCntContrato>();

    public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; } = new List<TbDspEmpenho>();

    public virtual ICollection<TbGerOrgaoOficialPublicacao> TbGerOrgaoOficialPublicacaos { get; set; } = new List<TbGerOrgaoOficialPublicacao>();

    public virtual ICollection<TbLicComposicoesComissao> TbLicComposicoesComissaos { get; set; } = new List<TbLicComposicoesComissao>();

    public virtual ICollection<TbLicContratoOrgaoOficialPublicacao> TbLicContratoOrgaoOficialPublicacaos { get; set; } = new List<TbLicContratoOrgaoOficialPublicacao>();

    public virtual ICollection<TbLicCotacaoIten> TbLicCotacaoItens { get; set; } = new List<TbLicCotacaoIten>();

    public virtual ICollection<TbLicDotaco> TbLicDotacos { get; set; } = new List<TbLicDotaco>();

    public virtual ICollection<TbLicFaseLance> TbLicFaseLances { get; set; } = new List<TbLicFaseLance>();

    public virtual ICollection<TbLicLicitacaoTecnica> TbLicLicitacaoTecnicas { get; set; } = new List<TbLicLicitacaoTecnica>();

    public virtual ICollection<TbLicLicitacoesAnexo> TbLicLicitacoesAnexos { get; set; } = new List<TbLicLicitacoesAnexo>();

    public virtual ICollection<TbLicLicitacoesDocumento> TbLicLicitacoesDocumentos { get; set; } = new List<TbLicLicitacoesDocumento>();

    public virtual ICollection<TbLicLicitacoesIten> TbLicLicitacoesItens { get; set; } = new List<TbLicLicitacoesIten>();

    public virtual ICollection<TbLicLicitacoesUsuario> TbLicLicitacoesUsuarios { get; set; } = new List<TbLicLicitacoesUsuario>();

    public virtual ICollection<TbLicMovimentacoesParecer> TbLicMovimentacoesParecers { get; set; } = new List<TbLicMovimentacoesParecer>();

    public virtual ICollection<TbLicMovimentosSituaco> TbLicMovimentosSituacos { get; set; } = new List<TbLicMovimentosSituaco>();

    public virtual ICollection<TbLicPareceresAnexo> TbLicPareceresAnexos { get; set; } = new List<TbLicPareceresAnexo>();

    public virtual ICollection<TbLicParticipante> TbLicParticipantes { get; set; } = new List<TbLicParticipante>();

    public virtual ICollection<TbLicPesquisaCotacaoIten> TbLicPesquisaCotacaoItens { get; set; } = new List<TbLicPesquisaCotacaoIten>();

    public virtual ICollection<TbLicPublicaco> TbLicPublicacos { get; set; } = new List<TbLicPublicaco>();

    public virtual ICollection<TbLicRecurso> TbLicRecursos { get; set; } = new List<TbLicRecurso>();

    public virtual ICollection<TbPlaAco> IdAcaos { get; set; } = new List<TbPlaAco>();
}
