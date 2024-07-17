using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Moeda
{
    public short Idmoeda { get; set; }

    public string? Nome { get; set; }

    public string? Sigla { get; set; }

    public virtual ICollection<MoedasReferencia> MoedasReferencia { get; set; } = new List<MoedasReferencia>();

    public virtual ICollection<TribAutosInfracao> TribAutosInfracaos { get; set; } = new List<TribAutosInfracao>();

    public virtual ICollection<TribCoeficienteTaxasIptu> TribCoeficienteTaxasIptus { get; set; } = new List<TribCoeficienteTaxasIptu>();
}
