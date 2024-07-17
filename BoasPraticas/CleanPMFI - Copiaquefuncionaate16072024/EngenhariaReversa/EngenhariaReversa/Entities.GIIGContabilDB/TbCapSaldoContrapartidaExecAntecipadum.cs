using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapSaldoContrapartidaExecAntecipadum
    {
        public int IdSaldo { get; set; }
        public int? IdEmpresa { get; set; }
        public short? NrAnoAplicacao { get; set; }
        public short? IdTipoExecucaoAntecipada { get; set; }
        public short? IdTipoContrapartida { get; set; }
        public string? CdFonteOrigem { get; set; }
        public string? CdFonteDestino { get; set; }
        public string? NrDocumento { get; set; }
        public short? NrAnoDocumento { get; set; }
        public decimal? VlSaldo { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
    }
}
