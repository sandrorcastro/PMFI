using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinPadraoContaCorrenteContaContabil
    {
        public int IdPadraoContaContabil { get; set; }
        public int? IdPadraoContaCorrente { get; set; }
        public string? CdContaContabil { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtIncluscao { get; set; }
    }
}
