using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerPaise
{
    public int Idpais { get; set; }

    public string? NmPais { get; set; }

    public string? DsSigla { get; set; }

    public virtual ICollection<TbGerCidade> TbGerCidades { get; set; } = new List<TbGerCidade>();
}
