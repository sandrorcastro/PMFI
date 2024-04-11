using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VisaoFormulario
{
    public string FrmId { get; set; } = null!;

    public string FrmTipo { get; set; } = null!;

    public string? FrmNome { get; set; }
}
