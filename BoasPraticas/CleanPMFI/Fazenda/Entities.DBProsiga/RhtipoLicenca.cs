using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class RhtipoLicenca
{
    public long TipoLicId { get; set; }

    public string? TipoLicNome { get; set; }

    public virtual ICollection<Rhlicenca> Rhlicencas { get; set; } = new List<Rhlicenca>();
}
