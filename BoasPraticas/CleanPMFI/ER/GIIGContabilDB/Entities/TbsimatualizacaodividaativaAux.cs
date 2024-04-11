using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbsimatualizacaodividaativaAux
{
    public int Idlancamento { get; set; }

    public int? NrsequenciaDa { get; set; }

    public int? NranosequenciaDa { get; set; }

    public int? Tipooperacao { get; set; }

    public DateTime? Dtatualizacao { get; set; }

    public decimal? Vlatualizacao { get; set; }
}
