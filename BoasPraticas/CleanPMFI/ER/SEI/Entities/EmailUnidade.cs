using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class EmailUnidade
{
    public int IdEmailUnidade { get; set; }

    public int IdUnidade { get; set; }

    public string Email { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int Sequencia { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;
}
