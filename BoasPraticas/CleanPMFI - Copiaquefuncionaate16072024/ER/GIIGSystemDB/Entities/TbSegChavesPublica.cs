using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegChavesPublica
{
    public short IdChavePublica { get; set; }

    public string DsLogin { get; set; } = null!;

    public DateTime DtCriacao { get; set; }

    public string DsChavePublica { get; set; } = null!;
}
