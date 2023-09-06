using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscVistoriaItensVistoriadosPrevisao
    {
        public long Idprevisao { get; set; }
        public long? IdnotaVist { get; set; }
        public int? TipoTribId { get; set; }
        public DateTime? PrevVencimento { get; set; }
        public string? PrevObs { get; set; }
        public DateTime? PrevDataBase { get; set; }
        public decimal? PrevValor { get; set; }
        public string? PrevParcelaUnica { get; set; }
        public decimal? PrevValorDesconto { get; set; }
        public int? PrevTipoTribIddesconto { get; set; }
    }
}
