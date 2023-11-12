using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Processos2019
{
    public double? ProcNum { get; set; }

    public double? ProcAno { get; set; }

    public DateTime? DataProc { get; set; }

    public string? ProcRequerente { get; set; }

    public string? Cpf { get; set; }

    public string? Inscricao { get; set; }
}
