using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinContasContabeisContasCorrente
{
    public int IdCorrelacao { get; set; }

    public int IdContaContabil { get; set; }

    public short IdTipoInvestimento { get; set; }

    public int IdCc { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public virtual TbGerContasCorrente IdCcNavigation { get; set; } = null!;

    public virtual TbFinContasContabei IdContaContabilNavigation { get; set; } = null!;
}
