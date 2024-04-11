using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class CargoFuncao
{
    public int IdUnidade { get; set; }

    public int IdCargoFuncao { get; set; }

    public string Nome { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;
}
