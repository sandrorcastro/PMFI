using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsTipoBeneficiario
{
    public int IdTipoBeneficiario { get; set; }

    public string? NmTipoBeneficiario { get; set; }

    public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; } = new List<TbSbsPrestacaoConta>();
}
