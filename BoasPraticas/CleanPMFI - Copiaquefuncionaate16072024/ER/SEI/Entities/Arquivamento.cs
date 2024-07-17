using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Arquivamento
{
    public long IdProtocolo { get; set; }

    public int? IdLocalizador { get; set; }

    public int? IdAtividadeArquivamento { get; set; }

    public int? IdAtividadeDesarquivamento { get; set; }

    public int? IdAtividadeRecebimento { get; set; }

    public int? IdAtividadeSolicitacao { get; set; }

    public string StaArquivamento { get; set; } = null!;

    public int? IdAtividadeCancelamento { get; set; }

    public string StaEliminacao { get; set; } = null!;

    public int? IdAtividadeEliminacao { get; set; }

    public virtual Atividade? IdAtividadeArquivamentoNavigation { get; set; }

    public virtual Atividade? IdAtividadeCancelamentoNavigation { get; set; }

    public virtual Atividade? IdAtividadeDesarquivamentoNavigation { get; set; }

    public virtual Atividade? IdAtividadeEliminacaoNavigation { get; set; }

    public virtual Atividade? IdAtividadeRecebimentoNavigation { get; set; }

    public virtual Atividade? IdAtividadeSolicitacaoNavigation { get; set; }

    public virtual Localizador? IdLocalizadorNavigation { get; set; }

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;
}
