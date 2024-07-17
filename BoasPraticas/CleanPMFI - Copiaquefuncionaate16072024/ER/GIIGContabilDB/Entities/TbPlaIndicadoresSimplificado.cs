using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaIndicadoresSimplificado
{
    public int IdIndicador { get; set; }

    public string? CdIndicador { get; set; }

    public string? DsIndicador { get; set; }

    public short IdUnidadeMedida { get; set; }

    public string? DsMedida { get; set; }

    public DateTime? DtBase { get; set; }

    public string? DsIndiceFinal { get; set; }

    public int IdPrograma { get; set; }

    public short? NrAnoBase { get; set; }

    public virtual TbPlaPrograma IdProgramaNavigation { get; set; } = null!;

    public virtual TbPlaUnidadesMedidum IdUnidadeMedidaNavigation { get; set; } = null!;
}
