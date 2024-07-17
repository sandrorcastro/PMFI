using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbAmmRessarcimentosDevolucoesSaldoConvenio
    {
        public int IdRessarcimento { get; set; }
        public short? IdEmpresa { get; set; }
        public string? CdConvenioAuxilio { get; set; }
        public string? CdReceita { get; set; }
        public decimal VlRessarcimento { get; set; }
        public decimal? VlEstornoRessarcimento { get; set; }
    }
}
