using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraCaptcha
{
    public string Identificacao { get; set; } = null!;

    public int Dia { get; set; }

    public int Mes { get; set; }

    public int Ano { get; set; }

    public long Acertos { get; set; }

    public long Erros { get; set; }
}
