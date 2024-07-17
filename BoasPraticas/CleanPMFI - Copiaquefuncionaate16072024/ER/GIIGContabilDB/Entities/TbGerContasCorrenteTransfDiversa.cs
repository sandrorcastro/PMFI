using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerContasCorrenteTransfDiversa
{
    public int IdCctransfDiversas { get; set; }

    public int? IdCc { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }
}
