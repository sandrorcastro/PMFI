using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerContasCorrOrgaosUnidade
{
    public int IdContaCorrOrgaoUnidade { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public int IdCc { get; set; }

    public string? DsTipo { get; set; }

    public virtual TbGerContasCorrente IdCcNavigation { get; set; } = null!;
}
