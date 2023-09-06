using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbEstornoCombustivelCupomFiscal
    {
        public int IdEstorno { get; set; }
        public long NumDocFiscal { get; set; }
        public long Reqnum { get; set; }
        public decimal QtdeLitrosAbast { get; set; }
        public decimal ValorCupom { get; set; }
        public decimal KmAnterior { get; set; }
        public decimal KmAtual { get; set; }
    }
}
