using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinDividaFundadaContasContabei
    {
        public int IdDividaContaContabel { get; set; }
        public long IdDividaFundada { get; set; }
        public int IdTipoContaContabil { get; set; }
        public string CdContacontabil { get; set; } = null!;
        public short NrExercicio { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
    }
}
