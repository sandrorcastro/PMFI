using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoReceitasProjecao
{
    public int IdReceita { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdReceita { get; set; }

    public string? DsReceita { get; set; }

    public string? FlTipo { get; set; }

    public int? IdReceitaNivelSuper { get; set; }
}
