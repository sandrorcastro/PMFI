using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeProntuario
{
    public int IdUnidadeSaude { get; set; }

    public int IdPaciente { get; set; }

    public long NroProntuario { get; set; }
}
