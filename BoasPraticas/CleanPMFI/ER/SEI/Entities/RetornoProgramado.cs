using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RetornoProgramado
{
    public int IdRetornoProgramado { get; set; }

    public int IdAtividadeEnvio { get; set; }

    public int? IdAtividadeRetorno { get; set; }

    public int IdUsuario { get; set; }

    public DateTime DtaProgramada { get; set; }

    public DateTime? DthAlteracao { get; set; }

    public int IdUnidadeEnvio { get; set; }

    public int IdUnidadeRetorno { get; set; }

    public long IdProtocolo { get; set; }

    public virtual Atividade IdAtividadeEnvioNavigation { get; set; } = null!;

    public virtual Atividade? IdAtividadeRetornoNavigation { get; set; }

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeEnvioNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeRetornoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
