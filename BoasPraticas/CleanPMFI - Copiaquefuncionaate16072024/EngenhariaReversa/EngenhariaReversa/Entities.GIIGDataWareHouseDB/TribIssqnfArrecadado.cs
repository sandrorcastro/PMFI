using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribIssqnfArrecadado
    {
        public int? IdEmpresa { get; set; }
        public int? NrAnoCompetencia { get; set; }
        public int? NrMesCompetencia { get; set; }
        public decimal? VlValorArrecadado { get; set; }
        public string? IdCnae { get; set; }
        public string? IdServico { get; set; }
    }
}
