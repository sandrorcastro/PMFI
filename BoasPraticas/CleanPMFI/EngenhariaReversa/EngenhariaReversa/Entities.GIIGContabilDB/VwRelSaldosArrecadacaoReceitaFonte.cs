using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class VwRelSaldosArrecadacaoReceitaFonte
    {
        public short? IdEmpresa { get; set; }
        public short NrAno { get; set; }
        public int? NrMes { get; set; }
        public string CdFonte { get; set; } = null!;
        public string? CdFonteNormal { get; set; }
        public string? CdReceita { get; set; }
        public string? CdCategoriaEconomica { get; set; }
        public string? CdOrigem { get; set; }
        public string? CdAplicacaoFonte { get; set; }
        public string? CdDesdobramentoFonte { get; set; }
        public string? CdDetalhamentoFonte { get; set; }
        public decimal? VlArrecadado { get; set; }
    }
}
