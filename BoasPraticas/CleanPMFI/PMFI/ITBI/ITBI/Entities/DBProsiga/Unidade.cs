using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Unidade
{
    public int UniId { get; set; }

    public string? UniNome { get; set; }

    public int? UniOrgaoId { get; set; }

    public string? UniExtincao { get; set; }

    public DateTime? UniDtExtincao { get; set; }

    public virtual ICollection<Diviso> Divisos { get; set; } = new List<Diviso>();

    public virtual Orgao? UniOrgao { get; set; }
}
