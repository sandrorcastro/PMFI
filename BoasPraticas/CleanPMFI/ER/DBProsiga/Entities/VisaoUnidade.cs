using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VisaoUnidade
{
    public int UniId { get; set; }

    public string? UniNome { get; set; }

    public string? OrgNome { get; set; }

    public string? MemRazaoSocial { get; set; }
}
