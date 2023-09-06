using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribIptufArrecadadoAno
    {
        public int? NrAno { get; set; }
        public decimal? VlValorTotalPago { get; set; }
        public decimal? VlValorPagoCotaUnica { get; set; }
        public decimal? VlValorPagoDemaisParcelas { get; set; }
        public int? NrQtdeContribuintesPagoCotaUnica { get; set; }
        public int? NrQtdeInscricoesPagoCotaUnica { get; set; }
        public int? NrQtdeContribuintesPagoDemaisParcelas { get; set; }
        public int? NrQtdeInscricoesPagoDemaisParcelas { get; set; }
        public int? NrQtdeContribuintesNaoPagaram { get; set; }
        public int? NrQtdeInscricoesNaoPagaram { get; set; }
    }
}
