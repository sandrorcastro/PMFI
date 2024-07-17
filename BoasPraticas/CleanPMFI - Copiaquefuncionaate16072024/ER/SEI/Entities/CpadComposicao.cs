using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class CpadComposicao
{
    public int IdCpadComposicao { get; set; }

    public int IdCpadVersao { get; set; }

    public int IdUsuario { get; set; }

    public int IdCargo { get; set; }

    public string SinPresidente { get; set; } = null!;

    public int Ordem { get; set; }

    public virtual ICollection<CpadAvaliacao> CpadAvaliacaos { get; set; } = new List<CpadAvaliacao>();

    public virtual Cargo IdCargoNavigation { get; set; } = null!;

    public virtual CpadVersao IdCpadVersaoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
