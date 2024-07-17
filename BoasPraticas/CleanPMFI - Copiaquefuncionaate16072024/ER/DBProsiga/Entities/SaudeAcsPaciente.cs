using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeAcsPaciente
{
    public int Idacs { get; set; }

    public long IdPaciente { get; set; }

    public virtual SaudePacienteXxxxxx IdPacienteNavigation { get; set; } = null!;
}
