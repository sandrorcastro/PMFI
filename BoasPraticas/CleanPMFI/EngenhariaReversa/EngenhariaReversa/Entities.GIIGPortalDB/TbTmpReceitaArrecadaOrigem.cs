using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpReceitaArrecadaOrigem
    {
        public int IdReceitaArrecadada { get; set; }
        public short? Ano { get; set; }
        public short? Mes { get; set; }
        public decimal? ValorArrecadado { get; set; }
        public decimal? ValorPrevisto { get; set; }
    }
}
