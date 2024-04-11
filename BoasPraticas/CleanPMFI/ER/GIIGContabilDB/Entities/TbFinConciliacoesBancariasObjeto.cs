using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinConciliacoesBancariasObjeto
{
    public int IdConciliacao { get; set; }

    public string TpObjeto { get; set; } = null!;

    public int IdObjeto { get; set; }

    public string? TpSigla { get; set; }

    public virtual TbFinConciliacoesBancaria IdConciliacaoNavigation { get; set; } = null!;
}
