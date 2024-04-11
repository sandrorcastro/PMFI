using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinTipoPermutaStatusDividum
{
    public short IdTipoPermuta { get; set; }

    public string? DsTipoPermuta { get; set; }

    public virtual ICollection<TbFinLancamentosPermutaDividaFundadum> TbFinLancamentosPermutaDividaFundada { get; set; } = new List<TbFinLancamentosPermutaDividaFundadum>();
}
