using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsSubvencaoSocial
{
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

    public virtual ICollection<TbSbsAditivo> TbSbsAditivos { get; set; } = new List<TbSbsAditivo>();

    public virtual ICollection<TbSbsBensAdquirido> TbSbsBensAdquiridos { get; set; } = new List<TbSbsBensAdquirido>();

    public virtual ICollection<TbSbsCronogramaDesembolso> TbSbsCronogramaDesembolsos { get; set; } = new List<TbSbsCronogramaDesembolso>();

    public virtual ICollection<TbSbsDevolucaoSaldo> TbSbsDevolucaoSaldos { get; set; } = new List<TbSbsDevolucaoSaldo>();

    public virtual ICollection<TbSbsEtapa> TbSbsEtapas { get; set; } = new List<TbSbsEtapa>();

    public virtual ICollection<TbSbsInterveniente> TbSbsIntervenientes { get; set; } = new List<TbSbsInterveniente>();

    public virtual ICollection<TbSbsLegislacaoEspecificaConcedente> TbSbsLegislacaoEspecificaConcedentes { get; set; } = new List<TbSbsLegislacaoEspecificaConcedente>();

    public virtual ICollection<TbSbsMembrosUgttomador> TbSbsMembrosUgttomadors { get; set; } = new List<TbSbsMembrosUgttomador>();

    public virtual ICollection<TbSbsOutrasReceita> TbSbsOutrasReceita { get; set; } = new List<TbSbsOutrasReceita>();

    public virtual ICollection<TbSbsPlanoAplicacoesAditivo> TbSbsPlanoAplicacoesAditivos { get; set; } = new List<TbSbsPlanoAplicacoesAditivo>();

    public virtual ICollection<TbSbsPlanoTrabalho> TbSbsPlanoTrabalhos { get; set; } = new List<TbSbsPlanoTrabalho>();

    public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; } = new List<TbSbsPrestacaoConta>();

    public virtual ICollection<TbSbsPrevisaoOrcamentarium> TbSbsPrevisaoOrcamentaria { get; set; } = new List<TbSbsPrevisaoOrcamentarium>();

    public virtual ICollection<TbSbsProjeto> TbSbsProjetos { get; set; } = new List<TbSbsProjeto>();

    public virtual ICollection<TbSbsRendimento> TbSbsRendimentos { get; set; } = new List<TbSbsRendimento>();

    public virtual ICollection<TbSbsSubvencaoSocialAnexosOldMigrado> TbSbsSubvencaoSocialAnexosOldMigrados { get; set; } = new List<TbSbsSubvencaoSocialAnexosOldMigrado>();

    public virtual TbSbsSubvencaoSocialCompl? TbSbsSubvencaoSocialCompl { get; set; }

    public virtual ICollection<TbSbsSubvencaoSocialEmpenho> TbSbsSubvencaoSocialEmpenhos { get; set; } = new List<TbSbsSubvencaoSocialEmpenho>();

    public virtual ICollection<TbSbsSubvencaoSocialPrestacao> TbSbsSubvencaoSocialPrestacaos { get; set; } = new List<TbSbsSubvencaoSocialPrestacao>();

    public virtual ICollection<TbsbsSaldoBancario> TbsbsSaldoBancarios { get; set; } = new List<TbsbsSaldoBancario>();
}
