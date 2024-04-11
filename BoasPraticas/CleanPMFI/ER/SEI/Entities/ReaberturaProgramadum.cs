using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ReaberturaProgramadum
{
    public int IdReaberturaProgramada { get; set; }

    public long IdProtocolo { get; set; }

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public int? IdAtividade { get; set; }

    public DateTime DtaProgramada { get; set; }

    public DateTime DthAlteracao { get; set; }

    public DateTime? DthProcessamento { get; set; }

    public DateTime? DthVisualizacao { get; set; }

    public string? Erro { get; set; }

    public virtual Atividade? IdAtividadeNavigation { get; set; }

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
