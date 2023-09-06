using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class ContabilResumoFvalore
    {
        public short? Ano { get; set; }
        public short? Mes { get; set; }
        public short? Dia { get; set; }
        public short? IdGrupo { get; set; }
        public short? IdTipoValor { get; set; }
        public decimal? VlArrecadado { get; set; }
    }
}
