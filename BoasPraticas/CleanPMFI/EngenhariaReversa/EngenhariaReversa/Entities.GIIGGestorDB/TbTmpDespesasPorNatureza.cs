using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGGestorDB
{
    public partial class TbTmpDespesasPorNatureza
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtExecucao { get; set; }
        public int? Idnatdespesa { get; set; }
        public int? Idnatdespesanivelsuper { get; set; }
        public string? Naturezadespesa { get; set; }
        public string? Descrição { get; set; }
        public decimal? Vltotalempenhado { get; set; }
        public decimal? Vltotalliquidado { get; set; }
        public decimal? Vltotalpago { get; set; }
    }
}
