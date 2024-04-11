using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerPessoa
{
    public int IdPessoa { get; set; }

    public string? DsTipoPessoa { get; set; }

    public string? NmPessoa { get; set; }

    public string? NmFantasia { get; set; }

    public string? NrCnpjcpf { get; set; }

    public string? NrRgIe { get; set; }

    public string? DsOrgaoExp { get; set; }

    public string? DsufExp { get; set; }

    public string? NrRegistroJuntaComercial { get; set; }

    public decimal? VlCapitalSocial { get; set; }

    public int? IdEndereco { get; set; }

    public string? NrPredial { get; set; }

    public string? DsComplEndereco { get; set; }

    public string? NrTelefones { get; set; }

    public string? DsEmail { get; set; }

    public string? DsSite { get; set; }

    public DateTime? DtInclusao { get; set; }

    public DateTime? DtAlteracao { get; set; }

    public string? DsObservacao { get; set; }

    public string? DsAtividade { get; set; }

    public string? FlMicroEmpresa { get; set; }

    public DateTime? DtRegistroJuntaComercial { get; set; }

    public string? DsObjetoContratual { get; set; }

    public string? DsCategoriaCadastramento { get; set; }

    public decimal? VlPatrimonioLiquido { get; set; }

    public decimal? NrIlcorrente { get; set; }

    public decimal? NrIlglobal { get; set; }

    public decimal? NrSolvenciaGeral { get; set; }

    public string? DsEntidadeProfissional { get; set; }

    public string? NrFax { get; set; }

    public string? DsOrigemCadastro { get; set; }

    public DateTime? DtEmissaoRg { get; set; }

    public DateTime? DtNascimento { get; set; }

    public DateTime? DtBaseTce { get; set; }

    public string? FlTratamentoDiferenciado { get; set; }

    public int? IdPessoaOrigem { get; set; }

    public virtual TbGerEndereco? IdEnderecoNavigation { get; set; }

    public virtual ICollection<TbCntContratosAssinatura> TbCntContratosAssinaturas { get; set; } = new List<TbCntContratosAssinatura>();

    public virtual ICollection<TbCntContratosItensLicitacao> TbCntContratosItensLicitacaos { get; set; } = new List<TbCntContratosItensLicitacao>();

    public virtual ICollection<TbCntResponsabilidadesAdministrativa> TbCntResponsabilidadesAdministrativas { get; set; } = new List<TbCntResponsabilidadesAdministrativa>();

    public virtual ICollection<TbDspDespesaExtraOrcamentarium> TbDspDespesaExtraOrcamentaria { get; set; } = new List<TbDspDespesaExtraOrcamentarium>();

    public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; } = new List<TbDspEmpenho>();

    public virtual ICollection<TbDspOrdensPagamento> TbDspOrdensPagamentos { get; set; } = new List<TbDspOrdensPagamento>();

    public virtual ICollection<TbDspSolicitacoesEmpenho> TbDspSolicitacoesEmpenhos { get; set; } = new List<TbDspSolicitacoesEmpenho>();

    public virtual ICollection<TbGerOrgaoOficialPublicacao> TbGerOrgaoOficialPublicacaos { get; set; } = new List<TbGerOrgaoOficialPublicacao>();

    public virtual ICollection<TbGerPessoasAlteraco> TbGerPessoasAlteracos { get; set; } = new List<TbGerPessoasAlteraco>();

    public virtual ICollection<TbGerPessoasAtributo> TbGerPessoasAtributos { get; set; } = new List<TbGerPessoasAtributo>();

    public virtual ICollection<TbGerPessoasCategoria> TbGerPessoasCategoria { get; set; } = new List<TbGerPessoasCategoria>();

    public virtual ICollection<TbLicAtosNomeacaoComissaoPessoa> TbLicAtosNomeacaoComissaoPessoas { get; set; } = new List<TbLicAtosNomeacaoComissaoPessoa>();

    public virtual ICollection<TbLicContratoOrgaoOficialPublicacao> TbLicContratoOrgaoOficialPublicacaos { get; set; } = new List<TbLicContratoOrgaoOficialPublicacao>();

    public virtual ICollection<TbLicCotacaoIten> TbLicCotacaoItens { get; set; } = new List<TbLicCotacaoIten>();

    public virtual ICollection<TbLicCotacaoSimple> TbLicCotacaoSimples { get; set; } = new List<TbLicCotacaoSimple>();

    public virtual ICollection<TbLicDoctosApresentado> TbLicDoctosApresentados { get; set; } = new List<TbLicDoctosApresentado>();

    public virtual ICollection<TbLicFaseLance> TbLicFaseLances { get; set; } = new List<TbLicFaseLance>();

    public virtual ICollection<TbLicParticipante> TbLicParticipantes { get; set; } = new List<TbLicParticipante>();

    public virtual ICollection<TbLicPessoasInidonea> TbLicPessoasInidoneas { get; set; } = new List<TbLicPessoasInidonea>();

    public virtual ICollection<TbSbsAditivo> TbSbsAditivos { get; set; } = new List<TbSbsAditivo>();

    public virtual ICollection<TbSbsInterveniente> TbSbsIntervenientes { get; set; } = new List<TbSbsInterveniente>();

    public virtual ICollection<TbSbsMembrosUgttomador> TbSbsMembrosUgttomadors { get; set; } = new List<TbSbsMembrosUgttomador>();

    public virtual ICollection<TbSbsPlanoTrabalho> TbSbsPlanoTrabalhos { get; set; } = new List<TbSbsPlanoTrabalho>();

    public virtual ICollection<TbSbsSubvencaoSocialCompl> TbSbsSubvencaoSocialCompls { get; set; } = new List<TbSbsSubvencaoSocialCompl>();

    public virtual ICollection<TbSbsSubvencaoSocialEmpenho> TbSbsSubvencaoSocialEmpenhos { get; set; } = new List<TbSbsSubvencaoSocialEmpenho>();
}
