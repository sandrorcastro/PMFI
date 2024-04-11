using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudePacientePrograma
{
    public long Idpaciente { get; set; }

    public int Idprograma { get; set; }

    public int IdUnidadeSaude { get; set; }

    public DateTime? Data { get; set; }

    public string? Situacao { get; set; }
}
