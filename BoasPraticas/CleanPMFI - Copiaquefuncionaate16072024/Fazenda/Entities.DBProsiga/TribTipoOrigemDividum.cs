using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribTipoOrigemDividum
{
    public int TribTipoId { get; set; }

    public string? TribTipoNome { get; set; }

    public string? TribTipoSigla { get; set; }

    public string? PossuiEdital { get; set; }

    public virtual ICollection<TribOrigemDividum> TribOrigemDivida { get; set; } = new List<TribOrigemDividum>();
}
