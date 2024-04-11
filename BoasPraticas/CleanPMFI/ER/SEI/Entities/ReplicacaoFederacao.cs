using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ReplicacaoFederacao
{
    public string IdReplicacaoFederacao { get; set; } = null!;

    public string IdInstalacaoFederacao { get; set; } = null!;

    public string IdProtocoloFederacao { get; set; } = null!;

    public int StaTipo { get; set; }

    public DateTime DthCadastro { get; set; }

    public DateTime? DthReplicacao { get; set; }

    public int Tentativa { get; set; }

    public string? Erro { get; set; }

    public string SinAtivo { get; set; } = null!;

    public virtual InstalacaoFederacao IdInstalacaoFederacaoNavigation { get; set; } = null!;

    public virtual ProtocoloFederacao IdProtocoloFederacaoNavigation { get; set; } = null!;
}
