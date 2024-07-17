using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class VwRelSaldosReceitasFonte
    {
        public int? NrMes { get; set; }
        public short? IdEmpresa { get; set; }
        public int? NrAno { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? CdReceita { get; set; }
        public string CdFonte { get; set; } = null!;
        public string? CdFonteNormal { get; set; }
        public decimal? VlArrecadado { get; set; }
    }
}
