using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaProgramasValore
{
    public int IdPrograma { get; set; }

    public short NrAno { get; set; }

    public decimal? VlFiscal { get; set; }

    public decimal? VlSeguridade { get; set; }

    public decimal? VlSeguridadeFiscal { get; set; }

    public virtual TbPlaPrograma IdProgramaNavigation { get; set; } = null!;
}
