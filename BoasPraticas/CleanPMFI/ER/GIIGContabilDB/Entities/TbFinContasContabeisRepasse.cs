using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinContasContabeisRepasse
{
    public int IdContaContabilRepasse { get; set; }

    public short? IdEmpresa { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string? CdContaContabil { get; set; }

    public short? NrAno { get; set; }
}
