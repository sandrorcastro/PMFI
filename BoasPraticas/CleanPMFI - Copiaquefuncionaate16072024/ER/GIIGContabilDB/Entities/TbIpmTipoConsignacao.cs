using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbIpmTipoConsignacao
{
    public int IdTipoConsignacao { get; set; }

    public string? DsTipoPlano { get; set; }

    public string? FlRepercuteGuia { get; set; }
}
