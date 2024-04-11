using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Processos2019
{
    public double? ProcNum { get; set; }

    public double? ProcAno { get; set; }

    public DateTime? DataProc { get; set; }

    public string? ProcRequerente { get; set; }

    public string? Cpf { get; set; }

    public string? Inscricao { get; set; }
}
