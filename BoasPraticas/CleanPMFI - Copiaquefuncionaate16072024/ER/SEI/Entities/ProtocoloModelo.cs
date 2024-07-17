using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ProtocoloModelo
{
    public int IdProtocoloModelo { get; set; }

    public int? IdGrupoProtocoloModelo { get; set; }

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public long IdProtocolo { get; set; }

    public string? Descricao { get; set; }

    public DateTime DthAlteracao { get; set; }

    public string? IdxProtocoloModelo { get; set; }

    public virtual GrupoProtocoloModelo? IdGrupoProtocoloModeloNavigation { get; set; }

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
