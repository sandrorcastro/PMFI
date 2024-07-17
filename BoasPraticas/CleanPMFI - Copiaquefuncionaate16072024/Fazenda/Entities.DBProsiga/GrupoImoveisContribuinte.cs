using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class GrupoImoveisContribuinte
{
    public string ImoCnpjfilial { get; set; } = null!;

    public string ImoInscricao { get; set; } = null!;

    public long ConId { get; set; }

    public virtual ImobensImovei Imo { get; set; } = null!;
}
