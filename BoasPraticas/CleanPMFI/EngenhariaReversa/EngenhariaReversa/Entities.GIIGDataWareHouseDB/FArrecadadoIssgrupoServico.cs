using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class FArrecadadoIssgrupoServico
    {
        public DateTime? DtBaixa { get; set; }
        public decimal? VlArrecadadoForaExercicio { get; set; }
        public decimal? VlArrecadadoExercicio { get; set; }
        public decimal? VlArrecadadoTotal { get; set; }
        public int? NrQtdeNotas { get; set; }
        public int? IdServico { get; set; }
        public int? IdEmpresa { get; set; }
    }
}
