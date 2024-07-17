using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class EmailUtilizado
{
    public int IdEmailUtilizado { get; set; }

    public int IdUnidade { get; set; }

    public string Email { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;
}
