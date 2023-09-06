using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbAmmEstornosRepasseConvenio
    {
        public int IdEstorno { get; set; }
        public short? NrMes { get; set; }
        public short? IdEmpresa { get; set; }
        public int? CdConvenioAuxilio { get; set; }
        public DateTime? DtEstorno { get; set; }
        public decimal? VlEstorno { get; set; }
        public string? DsMotivoEstorno { get; set; }
        public string? FlIndContrapartida { get; set; }
        public string? FlIndInterferencia { get; set; }
        public string? CdReceita { get; set; }
        public string? CdFonte { get; set; }
    }
}
