using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraDadoUsuario
{
    public int IdUsuario { get; set; }

    public string Nome { get; set; } = null!;

    public string? Valor { get; set; }
}
