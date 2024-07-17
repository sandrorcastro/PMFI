using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsSubvencaoSocial
    {
        public TbSbsSubvencaoSocial()
        {
            TbSbsAditivos = new HashSet<TbSbsAditivo>();
            TbSbsBensAdquiridos = new HashSet<TbSbsBensAdquirido>();
            TbSbsCronogramaDesembolsos = new HashSet<TbSbsCronogramaDesembolso>();
            TbSbsDevolucaoSaldos = new HashSet<TbSbsDevolucaoSaldo>();
            TbSbsEtapas = new HashSet<TbSbsEtapa>();
            TbSbsIntervenientes = new HashSet<TbSbsInterveniente>();
            TbSbsLegislacaoEspecificaConcedentes = new HashSet<TbSbsLegislacaoEspecificaConcedente>();
            TbSbsMembrosUgttomadors = new HashSet<TbSbsMembrosUgttomador>();
            TbSbsOutrasReceita = new HashSet<TbSbsOutrasReceita>();
            TbSbsPlanoAplicacoesAditivos = new HashSet<TbSbsPlanoAplicacoesAditivo>();
            TbSbsPlanoTrabalhos = new HashSet<TbSbsPlanoTrabalho>();
            TbSbsPrestacaoConta = new HashSet<TbSbsPrestacaoConta>();
            TbSbsPrevisaoOrcamentaria = new HashSet<TbSbsPrevisaoOrcamentarium>();
            TbSbsProjetos = new HashSet<TbSbsProjeto>();
            TbSbsRendimentos = new HashSet<TbSbsRendimento>();
            TbSbsSubvencaoSocialAnexosOldMigrados = new HashSet<TbSbsSubvencaoSocialAnexosOldMigrado>();
            TbSbsSubvencaoSocialEmpenhos = new HashSet<TbSbsSubvencaoSocialEmpenho>();
            TbSbsSubvencaoSocialPrestacaos = new HashSet<TbSbsSubvencaoSocialPrestacao>();
            TbsbsSaldoBancarios = new HashSet<TbsbsSaldoBancario>();
        }

        public int IdSubVencaoSocial { get; set; }
        public int IdEmpresa { get; set; }
        public short IdTipoExecucao { get; set; }
        public int? CdSubvencaoSocial { get; set; }
        public int NrAno { get; set; }
        public int? NrTermo { get; set; }
        public DateTime? DtCelebracao { get; set; }
        public string? DsLeiAutorizatoria { get; set; }
        public int? NrArtigoLdo { get; set; }
        public int? NrArtigoLoa { get; set; }
        public int IdPessoa { get; set; }
        public byte IdTpEntidade { get; set; }
        public string DsObjeto { get; set; } = null!;
        public int NrQtdPrevista { get; set; }
        public short IdUnidadeMedida { get; set; }
        public DateTime DtInicioConvenio { get; set; }
        public DateTime DtVencimentoConvenio { get; set; }
        public short CdPeriodicidadePrestacao { get; set; }
        public decimal VlPrevisto { get; set; }
        public decimal VlContrapartida { get; set; }
        public DateTime? DtPrazoInicial { get; set; }
        public DateTime DtPrazoFinal { get; set; }
        public DateTime DtPublicacao { get; set; }
        public short IdVeiculoPublicacao { get; set; }
        public int NrEdicaoPublicacao { get; set; }
        public string DsLogin { get; set; } = null!;
        public DateTime DtInclusao { get; set; }
        public string? CdContaContabil { get; set; }
        public string? CdContaContabilContraPartida { get; set; }
        public string? DsTipoPrestaConta { get; set; }
        public string? FlRecebeDoacaoPortal { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public int? IdTipoObjeto { get; set; }
        public int? IdLeiAto { get; set; }

        public virtual TbSbsTipoExecuco IdTipoExecucaoNavigation { get; set; } = null!;
        public virtual TbSbsTipoEntidade IdTpEntidadeNavigation { get; set; } = null!;
        public virtual TbPpaUnidadesMedidum IdUnidadeMedidaNavigation { get; set; } = null!;
        public virtual TbLicVeiculosPublicaco IdVeiculoPublicacaoNavigation { get; set; } = null!;
        public virtual TbSbsSubvencaoSocialCompl? TbSbsSubvencaoSocialCompl { get; set; }
        public virtual ICollection<TbSbsAditivo> TbSbsAditivos { get; set; }
        public virtual ICollection<TbSbsBensAdquirido> TbSbsBensAdquiridos { get; set; }
        public virtual ICollection<TbSbsCronogramaDesembolso> TbSbsCronogramaDesembolsos { get; set; }
        public virtual ICollection<TbSbsDevolucaoSaldo> TbSbsDevolucaoSaldos { get; set; }
        public virtual ICollection<TbSbsEtapa> TbSbsEtapas { get; set; }
        public virtual ICollection<TbSbsInterveniente> TbSbsIntervenientes { get; set; }
        public virtual ICollection<TbSbsLegislacaoEspecificaConcedente> TbSbsLegislacaoEspecificaConcedentes { get; set; }
        public virtual ICollection<TbSbsMembrosUgttomador> TbSbsMembrosUgttomadors { get; set; }
        public virtual ICollection<TbSbsOutrasReceita> TbSbsOutrasReceita { get; set; }
        public virtual ICollection<TbSbsPlanoAplicacoesAditivo> TbSbsPlanoAplicacoesAditivos { get; set; }
        public virtual ICollection<TbSbsPlanoTrabalho> TbSbsPlanoTrabalhos { get; set; }
        public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; }
        public virtual ICollection<TbSbsPrevisaoOrcamentarium> TbSbsPrevisaoOrcamentaria { get; set; }
        public virtual ICollection<TbSbsProjeto> TbSbsProjetos { get; set; }
        public virtual ICollection<TbSbsRendimento> TbSbsRendimentos { get; set; }
        public virtual ICollection<TbSbsSubvencaoSocialAnexosOldMigrado> TbSbsSubvencaoSocialAnexosOldMigrados { get; set; }
        public virtual ICollection<TbSbsSubvencaoSocialEmpenho> TbSbsSubvencaoSocialEmpenhos { get; set; }
        public virtual ICollection<TbSbsSubvencaoSocialPrestacao> TbSbsSubvencaoSocialPrestacaos { get; set; }
        public virtual ICollection<TbsbsSaldoBancario> TbsbsSaldoBancarios { get; set; }
    }
}
