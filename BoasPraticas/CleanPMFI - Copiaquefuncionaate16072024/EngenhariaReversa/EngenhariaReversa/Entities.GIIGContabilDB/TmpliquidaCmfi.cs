using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TmpliquidaCmfi
    {
        public int? IdLiquidacao { get; set; }
        public int? Idempenho { get; set; }
        public short? Idempresa { get; set; }
        public short? Nrano { get; set; }
        public int? Nrsequencia { get; set; }
        public int? Nrsequenciaanual { get; set; }
        public DateTime? Dtliquidacao { get; set; }
        public decimal? Vlliquidacao { get; set; }
        public string? Dshistorico { get; set; }
        public DateTime? Dtinclusao { get; set; }
        public string? Dslogin { get; set; }
        public int? Idccgrafica { get; set; }
        public int? Idccarrecadadora { get; set; }
        public int? Idccfavorrecido { get; set; }
        public int? Idpessoaliquidante { get; set; }
        public bool? Flcisaofusao { get; set; }
        public string? Nrcpfservidor { get; set; }
        public string? Nmservidor { get; set; }
        public int? Idsolicitacao { get; set; }
    }
}
