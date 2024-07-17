using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class GrupoProtocoloModelo
{
    public int IdGrupoProtocoloModelo { get; set; }

    public string Nome { get; set; } = null!;

    public int IdUnidade { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual ICollection<ProtocoloModelo> ProtocoloModelos { get; set; } = new List<ProtocoloModelo>();
}
