using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbsimatualizacaocreditoAux
{
    public int Idlancamento { get; set; }

    public int? Nrsequenciacredito { get; set; }

    public int? Nranosequenciacredito { get; set; }

    public int? Tipooperacao { get; set; }

    public DateTime? Dtatualizacao { get; set; }

    public decimal? Vlatualizacao { get; set; }
}
