using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ControlePrazo
{
    public int IdControlePrazo { get; set; }

    public long IdProtocolo { get; set; }

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public DateTime DtaPrazo { get; set; }

    public DateTime? DtaConclusao { get; set; }

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
