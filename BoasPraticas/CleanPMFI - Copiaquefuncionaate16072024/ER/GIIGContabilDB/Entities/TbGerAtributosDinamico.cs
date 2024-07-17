using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerAtributosDinamico
{
    public string IdAtributo { get; set; } = null!;

    public string NmTabela { get; set; } = null!;

    public string? NmAtributo { get; set; }

    public string? TpAtributo { get; set; }

    public short? NrOrdem { get; set; }
}
