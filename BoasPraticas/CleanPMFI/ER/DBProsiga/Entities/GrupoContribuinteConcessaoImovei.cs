using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class GrupoContribuinteConcessaoImovei
{
    public long IdContratoConcessao { get; set; }

    public long ConId { get; set; }

    public virtual Contribuinte Con { get; set; } = null!;
}
