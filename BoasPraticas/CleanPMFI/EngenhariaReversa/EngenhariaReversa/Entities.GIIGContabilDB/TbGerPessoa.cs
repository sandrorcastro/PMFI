using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerPessoa
    {
        public TbGerPessoa()
        {
            TbCntContratosAssinaturas = new HashSet<TbCntContratosAssinatura>();
            TbCntContratosItensLicitacaos = new HashSet<TbCntContratosItensLicitacao>();
            TbCntResponsabilidadesAdministrativas = new HashSet<TbCntResponsabilidadesAdministrativa>();
            TbDspDespesaExtraOrcamentaria = new HashSet<TbDspDespesaExtraOrcamentarium>();
            TbDspEmpenhos = new HashSet<TbDspEmpenho>();
            TbDspOrdensPagamentos = new HashSet<TbDspOrdensPagamento>();
            TbDspSolicitacoesEmpenhos = new HashSet<TbDspSolicitacoesEmpenho>();
            TbGerOrgaoOficialPublicacaos = new HashSet<TbGerOrgaoOficialPublicacao>();
            TbGerPessoasAlteracos = new HashSet<TbGerPessoasAlteraco>();
            TbGerPessoasAtributos = new HashSet<TbGerPessoasAtributo>();
            TbGerPessoasCategoria = new HashSet<TbGerPessoasCategoria>();
            TbLicAtosNomeacaoComissaoPessoas = new HashSet<TbLicAtosNomeacaoComissaoPessoa>();
            TbLicContratoOrgaoOficialPublicacaos = new HashSet<TbLicContratoOrgaoOficialPublicacao>();
            TbLicCotacaoItens = new HashSet<TbLicCotacaoIten>();
            TbLicCotacaoSimples = new HashSet<TbLicCotacaoSimple>();
            TbLicDoctosApresentados = new HashSet<TbLicDoctosApresentado>();
            TbLicFaseLances = new HashSet<TbLicFaseLance>();
            TbLicParticipantes = new HashSet<TbLicParticipante>();
            TbLicPessoasInidoneas = new HashSet<TbLicPessoasInidonea>();
            TbSbsAditivos = new HashSet<TbSbsAditivo>();
            TbSbsIntervenientes = new HashSet<TbSbsInterveniente>();
            TbSbsMembrosUgttomadors = new HashSet<TbSbsMembrosUgttomador>();
            TbSbsPlanoTrabalhos = new HashSet<TbSbsPlanoTrabalho>();
            TbSbsSubvencaoSocialCompls = new HashSet<TbSbsSubvencaoSocialCompl>();
            TbSbsSubvencaoSocialEmpenhos = new HashSet<TbSbsSubvencaoSocialEmpenho>();
        }

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
        public virtual ICollection<TbCntContratosAssinatura> TbCntContratosAssinaturas { get; set; }
        public virtual ICollection<TbCntContratosItensLicitacao> TbCntContratosItensLicitacaos { get; set; }
        public virtual ICollection<TbCntResponsabilidadesAdministrativa> TbCntResponsabilidadesAdministrativas { get; set; }
        public virtual ICollection<TbDspDespesaExtraOrcamentarium> TbDspDespesaExtraOrcamentaria { get; set; }
        public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; }
        public virtual ICollection<TbDspOrdensPagamento> TbDspOrdensPagamentos { get; set; }
        public virtual ICollection<TbDspSolicitacoesEmpenho> TbDspSolicitacoesEmpenhos { get; set; }
        public virtual ICollection<TbGerOrgaoOficialPublicacao> TbGerOrgaoOficialPublicacaos { get; set; }
        public virtual ICollection<TbGerPessoasAlteraco> TbGerPessoasAlteracos { get; set; }
        public virtual ICollection<TbGerPessoasAtributo> TbGerPessoasAtributos { get; set; }
        public virtual ICollection<TbGerPessoasCategoria> TbGerPessoasCategoria { get; set; }
        public virtual ICollection<TbLicAtosNomeacaoComissaoPessoa> TbLicAtosNomeacaoComissaoPessoas { get; set; }
        public virtual ICollection<TbLicContratoOrgaoOficialPublicacao> TbLicContratoOrgaoOficialPublicacaos { get; set; }
        public virtual ICollection<TbLicCotacaoIten> TbLicCotacaoItens { get; set; }
        public virtual ICollection<TbLicCotacaoSimple> TbLicCotacaoSimples { get; set; }
        public virtual ICollection<TbLicDoctosApresentado> TbLicDoctosApresentados { get; set; }
        public virtual ICollection<TbLicFaseLance> TbLicFaseLances { get; set; }
        public virtual ICollection<TbLicParticipante> TbLicParticipantes { get; set; }
        public virtual ICollection<TbLicPessoasInidonea> TbLicPessoasInidoneas { get; set; }
        public virtual ICollection<TbSbsAditivo> TbSbsAditivos { get; set; }
        public virtual ICollection<TbSbsInterveniente> TbSbsIntervenientes { get; set; }
        public virtual ICollection<TbSbsMembrosUgttomador> TbSbsMembrosUgttomadors { get; set; }
        public virtual ICollection<TbSbsPlanoTrabalho> TbSbsPlanoTrabalhos { get; set; }
        public virtual ICollection<TbSbsSubvencaoSocialCompl> TbSbsSubvencaoSocialCompls { get; set; }
        public virtual ICollection<TbSbsSubvencaoSocialEmpenho> TbSbsSubvencaoSocialEmpenhos { get; set; }
    }
}
