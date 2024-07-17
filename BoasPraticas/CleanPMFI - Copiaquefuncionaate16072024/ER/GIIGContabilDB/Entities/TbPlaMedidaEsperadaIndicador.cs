using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaMedidaEsperadaIndicador
{
    public int IdMovimento { get; set; }

    public short NrAnoBase { get; set; }

    public decimal NrMedidaEsperada { get; set; }

    public virtual TbPlaIndicadoresMovimento IdMovimentoNavigation { get; set; } = null!;
}
