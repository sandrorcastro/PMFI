using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class ContribuintesLogIntegraSircof
{
    public int LogId { get; set; }

    public int? ConId { get; set; }

    public int? FunId { get; set; }

    public string? ConCnpjcpf { get; set; }

    public string? NomeSircof { get; set; }

    public string? NomeTribuno { get; set; }

    public DateTime DataLog { get; set; }
}
