﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeAcsPaciente
{
    public int Idacs { get; set; }

    public long IdPaciente { get; set; }

    public virtual SaudePacienteXxxxxx IdPacienteNavigation { get; set; } = null!;
}
