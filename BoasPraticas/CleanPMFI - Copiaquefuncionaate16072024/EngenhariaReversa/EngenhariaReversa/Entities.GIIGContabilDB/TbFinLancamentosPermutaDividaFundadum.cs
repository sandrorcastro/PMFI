using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinLancamentosPermutaDividaFundadum
    {
        public int IdPermuta { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string? TpOperacao { get; set; }
        public int? NrOperacao { get; set; }
        public long? IdDividaFundada { get; set; }
        public int? IdContaContabil { get; set; }
        public short? IdTipoPermuta { get; set; }
        public int? IdEmpenho { get; set; }
        public int? IdLancamento { get; set; }
        public DateTime? DtOperacao { get; set; }
        public decimal? VlOperacao { get; set; }

        public virtual TbFinContasContabei? IdContaContabilNavigation { get; set; }
        public virtual TbFinDividaFundadum? IdDividaFundadaNavigation { get; set; }
        public virtual TbFinTipoPermutaStatusDividum? IdTipoPermutaNavigation { get; set; }
    }
}
