using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribEmpresasfDivida
    {
        public int? IdCmcempresa { get; set; }
        public int? NrAno { get; set; }
        public int? IdTipoTributo { get; set; }
        public int? IdTipoBaixa { get; set; }
        public decimal? VlLancado { get; set; }
        public decimal? VlArrecadado { get; set; }
        public decimal? VlPendente { get; set; }
        public decimal? VlOutros { get; set; }
    }
}
