using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntOrgaosUnidadesVinculada
{
    public int IdContrato { get; set; }

    public short Idempresa { get; set; }

    public short NrAno { get; set; }

    public string CdOrgao { get; set; } = null!;

    public string CdUnidade { get; set; } = null!;

    public string DsTipoVinculo { get; set; } = null!;

    public virtual TbCntContrato IdContratoNavigation { get; set; } = null!;

    public virtual TbOrcUnidade TbOrcUnidade { get; set; } = null!;
}
