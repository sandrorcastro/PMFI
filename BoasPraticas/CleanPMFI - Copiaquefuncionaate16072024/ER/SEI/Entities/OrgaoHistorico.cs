using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class OrgaoHistorico
{
    public int IdOrgaoHistorico { get; set; }

    public int IdOrgao { get; set; }

    public string Sigla { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public DateTime DtaInicio { get; set; }

    public DateTime? DtaFim { get; set; }

    public virtual Orgao IdOrgaoNavigation { get; set; } = null!;
}
