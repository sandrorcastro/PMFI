using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspLiquidacoesDoctosIntegrado
    {
        public int IdDoctoIntegrado { get; set; }
        public int? IdCompFiss { get; set; }
        public int? IdConsignacao { get; set; }
        public int? IdLiquidacaoDocto { get; set; }
        public int? IdNfse { get; set; }
        public int? IdDivida { get; set; }
        public string? DsSituacao { get; set; }
        public decimal? VlIss { get; set; }
        public decimal? VlAliquota { get; set; }

        public virtual TbDspConsignaco? IdConsignacaoNavigation { get; set; }
    }
}
