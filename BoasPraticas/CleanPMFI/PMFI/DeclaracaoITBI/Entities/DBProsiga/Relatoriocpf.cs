using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Relatoriocpf
{
    public string? Pessoa { get; set; }

    public string? Nis { get; set; }

    public string? Cpf { get; set; }

    public string? Identidade { get; set; }

    public int? Ordem { get; set; }
}
