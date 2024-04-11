using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinContaContabilEstatal
{
    public int IdContaContabilEstatal { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdContaContabilEstatal { get; set; }

    public string? DsContaContabil { get; set; }

    public string? TpNaturazaSaldo { get; set; }

    public string? TpEscrituracao { get; set; }

    public virtual ICollection<TbFinContasContabei> IdContaContabils { get; set; } = new List<TbFinContasContabei>();
}
