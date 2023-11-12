using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Eduformacao
{
    public long FormId { get; set; }

    public string? FormNome { get; set; }

    public long? TipoFormId { get; set; }

    public virtual ICollection<EduformacaoContribuinte> EduformacaoContribuintes { get; set; } = new List<EduformacaoContribuinte>();

    public virtual EdutipoFormacao? TipoForm { get; set; }
}
