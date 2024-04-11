using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Tbsimarrecadacaocredito
{
    public int Idarrecadacao { get; set; }

    public int? Nrsequencial { get; set; }

    public int? Nranosequencial { get; set; }

    public int? Idtipoorigemreceita { get; set; }

    public int? NrsequencialInscricao { get; set; }

    public int? Nranosequencialinscricao { get; set; }

    public int? NrsequencialDa { get; set; }

    public int? NranosequencialDa { get; set; }

    public int? Idtipoarrecadacao { get; set; }

    public int? Nrmesarrecadacao { get; set; }

    public int? Nranoarrecadacao { get; set; }

    public decimal? Vloperacao { get; set; }
}
