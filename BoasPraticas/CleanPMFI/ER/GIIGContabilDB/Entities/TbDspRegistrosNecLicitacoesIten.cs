using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspRegistrosNecLicitacoesIten
{
    public int IdRegistro { get; set; }

    public int IdItem { get; set; }

    public decimal? VlUnitario { get; set; }

    public decimal? NrQtdTotal { get; set; }

    public virtual TbDspIten IdItemNavigation { get; set; } = null!;

    public virtual TbDspRegistrosNecessidadeLicitaco IdRegistroNavigation { get; set; } = null!;
}
