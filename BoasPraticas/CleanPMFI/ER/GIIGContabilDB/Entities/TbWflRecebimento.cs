using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbWflRecebimento
{
    public int IdRecebimento { get; set; }

    public DateTime? DtRecebimento { get; set; }

    public string? DsLogin { get; set; }

    public virtual ICollection<TbWflRemessa> IdRemessas { get; set; } = new List<TbWflRemessa>();
}
