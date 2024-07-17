using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class EdutipoFormacao
{
    public long TipoFormId { get; set; }

    public string? TipoFormNome { get; set; }

    public virtual ICollection<Eduformacao> Eduformacaos { get; set; } = new List<Eduformacao>();
}
