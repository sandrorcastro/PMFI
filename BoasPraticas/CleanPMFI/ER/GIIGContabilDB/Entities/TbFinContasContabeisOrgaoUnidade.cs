using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinContasContabeisOrgaoUnidade
{
    public int IdContaContabil { get; set; }

    public short NrAno { get; set; }

    public string CdOrgao { get; set; } = null!;

    public string CdUnidade { get; set; } = null!;

    public decimal? VlSaldoInicial { get; set; }

    public virtual TbFinContasContabei IdContaContabilNavigation { get; set; } = null!;
}
