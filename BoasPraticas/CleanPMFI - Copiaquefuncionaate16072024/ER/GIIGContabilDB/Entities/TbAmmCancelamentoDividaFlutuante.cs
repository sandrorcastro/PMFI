using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmCancelamentoDividaFlutuante
{
    public int IdCancelamento { get; set; }

    public short? IdEmpresa { get; set; }

    public short? CdTipoPassivo { get; set; }

    public string? CdFonte { get; set; }

    public string? DsCancelamento { get; set; }

    public decimal? VlCancelado { get; set; }
}
