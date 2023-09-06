using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribTributosfResumoTributo
    {
        public int? AnoDivida { get; set; }
        public int? MesDivida { get; set; }
        public int? IdGrupoTributo { get; set; }
        public int? IdTipoTributo { get; set; }
        public int? IdGrupoTipoBaixa { get; set; }
        public int? IdTipoBaixa { get; set; }
        public int? IdTipoDivida { get; set; }
        public decimal? VlValorDivida { get; set; }
    }
}
