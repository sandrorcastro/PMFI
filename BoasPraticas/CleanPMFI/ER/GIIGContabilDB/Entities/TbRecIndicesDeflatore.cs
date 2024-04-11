using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRecIndicesDeflatore
{
    public int IdIndice { get; set; }

    public short? NrAno { get; set; }

    public byte? NrMes { get; set; }

    public decimal? VlInflacaoIbge { get; set; }

    public decimal? VlDeflator { get; set; }
}
