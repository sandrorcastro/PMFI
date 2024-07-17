using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbStnCorrelacaoNaturezasDespesa
    {
        public int IdCorrelacao { get; set; }
        public string? CdNatDespesaGiig { get; set; }
        public string? CdNatDespesaStn { get; set; }
        public short? NrAno { get; set; }
    }
}
