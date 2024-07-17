using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribDucBloqueioInscricao
{
    public long IdBloqueio { get; set; }

    public long? ConId { get; set; }

    public string? TpSituacao { get; set; }
}
