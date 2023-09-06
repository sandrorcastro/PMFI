using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribBancosFdividum
    {
        public short? Dia { get; set; }
        public short? Mes { get; set; }
        public short? Ano { get; set; }
        public int? NrCme { get; set; }
        public int? IdTipoTributo { get; set; }
        public decimal? VlArrecadado { get; set; }
    }
}
