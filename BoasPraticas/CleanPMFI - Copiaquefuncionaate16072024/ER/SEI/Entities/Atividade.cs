using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Atividade
{
    public int IdAtividade { get; set; }

    public long IdProtocolo { get; set; }

    public int IdUnidade { get; set; }

    public DateTime DthAbertura { get; set; }

    public DateTime? DthConclusao { get; set; }

    public int? IdTarefa { get; set; }

    public int IdUnidadeOrigem { get; set; }

    public int? IdUsuarioConclusao { get; set; }

    public string SinInicial { get; set; } = null!;

    public int? IdUsuarioVisualizacao { get; set; }

    public int? IdUsuarioAtribuicao { get; set; }

    public DateTime? DtaPrazo { get; set; }

    public int TipoVisualizacao { get; set; }

    public int? IdUsuario { get; set; }

    public int IdUsuarioOrigem { get; set; }

    public virtual ICollection<AcessoExterno> AcessoExternos { get; set; } = new List<AcessoExterno>();

    public virtual ICollection<Arquivamento> ArquivamentoIdAtividadeArquivamentoNavigations { get; set; } = new List<Arquivamento>();

    public virtual ICollection<Arquivamento> ArquivamentoIdAtividadeCancelamentoNavigations { get; set; } = new List<Arquivamento>();

    public virtual ICollection<Arquivamento> ArquivamentoIdAtividadeDesarquivamentoNavigations { get; set; } = new List<Arquivamento>();

    public virtual ICollection<Arquivamento> ArquivamentoIdAtividadeEliminacaoNavigations { get; set; } = new List<Arquivamento>();

    public virtual ICollection<Arquivamento> ArquivamentoIdAtividadeRecebimentoNavigations { get; set; } = new List<Arquivamento>();

    public virtual ICollection<Arquivamento> ArquivamentoIdAtividadeSolicitacaoNavigations { get; set; } = new List<Arquivamento>();

    public virtual ICollection<Assinatura> Assinaturas { get; set; } = new List<Assinatura>();

    public virtual ICollection<AtributoAndamento> AtributoAndamentos { get; set; } = new List<AtributoAndamento>();

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Tarefa? IdTarefaNavigation { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeOrigemNavigation { get; set; } = null!;

    public virtual Usuario? IdUsuarioAtribuicaoNavigation { get; set; }

    public virtual Usuario? IdUsuarioConclusaoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual Usuario IdUsuarioOrigemNavigation { get; set; } = null!;

    public virtual Usuario? IdUsuarioVisualizacaoNavigation { get; set; }

    public virtual ICollection<Notificacao> Notificacaos { get; set; } = new List<Notificacao>();

    public virtual ICollection<Publicacao> Publicacaos { get; set; } = new List<Publicacao>();

    public virtual ICollection<ReaberturaProgramadum> ReaberturaProgramada { get; set; } = new List<ReaberturaProgramadum>();

    public virtual ICollection<RetornoProgramado> RetornoProgramadoIdAtividadeEnvioNavigations { get; set; } = new List<RetornoProgramado>();

    public virtual ICollection<RetornoProgramado> RetornoProgramadoIdAtividadeRetornoNavigations { get; set; } = new List<RetornoProgramado>();
}
