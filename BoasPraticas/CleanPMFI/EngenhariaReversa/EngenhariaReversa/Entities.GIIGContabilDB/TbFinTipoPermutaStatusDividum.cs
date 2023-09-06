using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinTipoPermutaStatusDividum
    {
        public TbFinTipoPermutaStatusDividum()
        {
            TbFinLancamentosPermutaDividaFundada = new HashSet<TbFinLancamentosPermutaDividaFundadum>();
        }

        public short IdTipoPermuta { get; set; }
        public string? DsTipoPermuta { get; set; }

        public virtual ICollection<TbFinLancamentosPermutaDividaFundadum> TbFinLancamentosPermutaDividaFundada { get; set; }
    }
}
