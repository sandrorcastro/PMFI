using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribDucBloqueioInscricao
{
    public long IdBloqueio { get; set; }

    public long? ConId { get; set; }

    public string? TpSituacao { get; set; }
}
