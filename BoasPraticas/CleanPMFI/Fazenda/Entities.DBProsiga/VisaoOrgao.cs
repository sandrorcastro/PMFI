using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class VisaoOrgao
{
    public int Id { get; set; }

    public string? NomeDoÓrgão { get; set; }

    public string? RazãoSocial { get; set; }
}
